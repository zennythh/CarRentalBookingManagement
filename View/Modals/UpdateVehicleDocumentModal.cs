using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Services.Implementations;

namespace VehicleManagementSystem.View.Modals {
    public partial class UpdateVehicleDocumentModal : Form {
        VehicleDocumentDto _currentDocument;
        VehicleDocumentServices _vehicleDocumentServices;

        public string DocumentType => this.Controls.OfType<System.Windows.Forms.RadioButton>()
                                        .FirstOrDefault(r => r.Checked)?.Text ?? "";

        public string DocumentTitle => inputDocumentTitle.Text;
        public string DocumentIssuingAuthority => inputIssuingAuthority.Text;

        public string DocumentExpirationDate => DocumentType != "Permanent" ? inputExpirationDate.Text : null;
        public string DocumentIssueDate => inputIssueDate.Text;
        public string DocumentPath => _tempSelectedFilePath;

        string _tempSelectedFilePath;

        public UpdateVehicleDocumentModal(VehicleDocumentDto document) {
            InitializeComponent();
            _currentDocument = document;
            _vehicleDocumentServices = new VehicleDocumentServices();
            labelHeader.Text = "Updating the document of " + document.VehiclePlateNum;

            LoadCurrentData();
            LoadCurrentFile();
        }

        // Should have a notice before closing the modal if there was change/s in the input fields
        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LoadCurrentData() {
            var targetRadio = this.Controls.OfType<System.Windows.Forms.RadioButton>()
                          .FirstOrDefault(r => r.Text == _currentDocument.Category);

            if (targetRadio != null) {
                targetRadio.Select();
            }

            inputDocumentTitle.Text = _currentDocument.Title;
            inputIssuingAuthority.Text = _currentDocument.IssuingAuthority;
            inputIssueDate.Value = _currentDocument.IssueDate;
            inputExpirationDate.Value = _currentDocument?.ExpirationDate ?? inputExpirationDate.Value;
        }

        private void LoadCurrentFile() {
            string fullPath = Path.Combine(AppConfig.AppData.RootPath, _currentDocument.FilePath);
            string fileNameOnly = Path.GetFileName(fullPath);
            string extension = Path.GetExtension(fullPath).ToLower();

            _tempSelectedFilePath = fullPath;

            switch (extension) {
                case ".docx":
                case ".doc":
                case ".pdf":
                    long bytes = new System.IO.FileInfo(fullPath).Length;
                    double mb = (double)bytes / (1024 * 1024);
                    labelFileName.Text = $"{fileNameOnly} ({mb:F2} MB)";

                    panelFile.BringToFront();
                    panelFile.Visible = true;

                    break;
                case ".jpg":
                case ".png":
                case ".jpeg":
                    documentPictureBox.Image = System.Drawing.Image.FromFile(fullPath);
                    documentPictureBox.BringToFront();
                    documentPictureBox.Visible = true;
                    break;
            }

            _tempSelectedFilePath = fullPath;
            closeImageBtn.BringToFront();
            closeImageBtn.Visible = true;
        }

        private void Radio_CheckedChanged(object sender, EventArgs e) {
            if (DocumentType != "Permanent") {
                ToggleExpirationDateVisibility(true);
            } else {
                ToggleExpirationDateVisibility(false);
            }
        }

        private void ToggleExpirationDateVisibility(bool isVisible) {
            inputExpirationDate.Visible = isVisible;
            labelExpirationDate.Visible = isVisible;
        }

        private void addImageBtn_Click(object sender, EventArgs e) {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog()) {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "All Supported Files|*.jpg;*.jpeg;*.png;*.pdf;*.doc;*.docx|" +
                        "Image Files|*.jpg;*.jpeg;*.png|" +
                        "PDF Documents|*.pdf|" +
                        "Word Documents|*.doc;*.docx";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                if (documentPictureBox.Image != null) {
                    documentPictureBox.Image.Dispose();
                }

                string fullPath = openFileDialog.FileName;
                string fileNameOnly = Path.GetFileName(fullPath);
                string extension = Path.GetExtension(fullPath).ToLower();

                switch (extension) {
                    case ".docx":
                    case ".doc":
                    case ".pdf":
                        long bytes = new System.IO.FileInfo(fullPath).Length;
                        double mb = (double)bytes / (1024 * 1024);
                        labelFileName.Text = $"{fileNameOnly} ({mb:F2} MB)";

                        panelFile.BringToFront();
                        panelFile.Visible = true;

                        break;
                    case ".jpg":
                    case ".png":
                    case ".jpeg":
                        documentPictureBox.Image = System.Drawing.Image.FromFile(fullPath);
                        documentPictureBox.BringToFront();
                        documentPictureBox.Visible = true;
                        break;
                }

                _tempSelectedFilePath = fullPath;
                closeImageBtn.BringToFront();
                closeImageBtn.Visible = true;
            }
        }

        private void closeImageBtn_Click(object sender, EventArgs e) {
            if (documentPictureBox.Image != null) {
                documentPictureBox.Image.Dispose();
                documentPictureBox.Image = null;
            }
            panelFile.Visible = false;
            documentPictureBox.Visible = false;

            _tempSelectedFilePath = null;

            closeImageBtn.Visible = false;
            addImageBtn.Visible = true;
            labelFileName.Text = "No file selected";
        }

        // REQUIRE ITS OWN PRESENTER AND INTERFACE
        private void saveBtn_Click(object sender, EventArgs e) {
            string message = $"Are you sure you want to update this {DocumentType} document?";
            if (System.Windows.Forms.MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            saveBtn.Text = "Updating...";
            saveBtn.Click -= saveBtn_Click;

            try {
                string finalPath = _currentDocument.FilePath;
                string extension = _currentDocument.Extension;

                if (_tempSelectedFilePath != _currentDocument.FilePath) {
                    string ext = Path.GetExtension(_tempSelectedFilePath).ToLower();
                    if (ext == ".docx" || ext == ".doc") {
                        finalPath = ConvertAndSaveDocx(_tempSelectedFilePath, _currentDocument.VehiclePlateNum);
                        extension = ".pdf";
                        if (File.Exists(_currentDocument.FilePath)) {
                            File.Delete(_currentDocument.FilePath);
                        }
                    } else {
                        // Use your existing helper for normal images/PDFs
                        string subFolder = Path.Combine(AppConfig.AppData.VehicleImagePath, _currentDocument.VehiclePlateNum);
                        string cleanTitle = DocumentTitle.Replace(" ", "_");
                        string fileName = $"{DocumentType}-{cleanTitle}-{Guid.NewGuid()}{ext}";
                        finalPath = Classes.Helpers.SaveDocumentToAppData(_tempSelectedFilePath, subFolder, fileName);
                        extension = ext;
                    }
                }

                VehicleDocumentDto updatedData = new VehicleDocumentDto {
                    DocumentID = _currentDocument.DocumentID,
                    Title = Classes.Helpers.ConvertToCapitalized(DocumentTitle),
                    Category = DocumentType,
                    IssuingAuthority = Classes.Helpers.ConvertToCapitalized(DocumentIssuingAuthority),
                    IssueDate = DateTime.Parse(DocumentIssueDate),
                    ExpirationDate = string.IsNullOrEmpty(DocumentExpirationDate)
                                     ? (DateTime?)null : DateTime.Parse(DocumentExpirationDate),
                    FilePath = finalPath,
                    Extension = extension
                };

                if (!IsDocumentModified(_currentDocument, updatedData)) {
                    System.Windows.Forms.MessageBox.Show("No changes were detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                _vehicleDocumentServices.UpdateVehicleDocument(updatedData);

                //System.Windows.Forms.MessageBox.Show("Document updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK; 
                this.Close();
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveBtn.Text = "Update";
                saveBtn.Click += saveBtn_Click;
            }
        }

        private string ConvertAndSaveDocx(string originalPath, string plateNum) {
            string relativeFolder = Path.Combine(
                AppConfig.AppData.DocumentsPath,
                AppConfig.AppData.VehicleImagePath,
                plateNum
            );

            string physicalFolder = Path.Combine(AppConfig.AppData.RootPath, relativeFolder);

            if (!Directory.Exists(physicalFolder)) Directory.CreateDirectory(physicalFolder);

            string cleanTitle = DocumentTitle.Replace(" ", "_");
            string fileName = $"{DocumentType}-{cleanTitle}-{Guid.NewGuid()}.pdf";

            string fullPhysicalPath = Path.Combine(physicalFolder, fileName);

            using (Spire.Doc.Document document = new Spire.Doc.Document()) {
                document.LoadFromFile(originalPath);
                document.SaveToFile(fullPhysicalPath, Spire.Doc.FileFormat.PDF);
                document.Close();
            }

            return Path.Combine(relativeFolder, fileName);
        }

        private bool IsDocumentModified(VehicleDocumentDto original, VehicleDocumentDto updated) {
            return original.Title != updated.Title ||
                   original.Category != updated.Category ||
                   original.IssuingAuthority != updated.IssuingAuthority ||
                   original.IssueDate != updated.IssueDate ||
                   original.ExpirationDate != updated.ExpirationDate ||
                   original.FilePath != updated.FilePath;
        }

        private void UpdateVehicleDocumentModal_Load(object sender, EventArgs e) {
            inputDocumentTitle.Focus();
            inputExpirationDate.MinDate = DateTime.Today;
            inputIssueDate.MaxDate = DateTime.Today;
        }
    }
}
    
