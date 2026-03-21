using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Services.Implementations;
using static System.Net.Mime.MediaTypeNames;

namespace VehicleManagementSystem.View.Modals {
    public partial class RenewVehicleDocumentModal : Form {
        VehicleDocumentDto _document;
        VehicleDocumentServices _vehicleDocumentServices;

        string _tempSelectedFilePath;

        public RenewVehicleDocumentModal(VehicleDocumentDto document) {
            InitializeComponent();

            _document = document; 

            _vehicleDocumentServices = new VehicleDocumentServices();

            labelHeader.Text = "Renewing the document of " + document.VehiclePlateNum;
            labelDocumentTitle.Text = document.Title;
            labelDocumentType.Text = document.Category;
            labelIssueDate.Text = document.IssueDate.ToString("d");
            labelExtension.Text = document.Extension.Replace('.', ' ').ToUpper().TrimStart();
            labelIssuingAuthority.Text = document.IssuingAuthority;

            inputExpirationDate.Value = (DateTime)document.ExpirationDate;
            inputExpirationDate.MinDate = DateTime.Today;
        }

        private void addImageBtn_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
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

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
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

        private void guna2Button1_Click(object sender, EventArgs e) {
            inputExpirationDate.Value = inputExpirationDate.Value.AddDays(1); ;
        }

        private void btnMonth_Click(object sender, EventArgs e) {
            inputExpirationDate.Value = inputExpirationDate.Value.AddMonths(1); 
        }

        private void btnYear_Click(object sender, EventArgs e) {
            inputExpirationDate.Value = inputExpirationDate.Value.AddYears(1);
        }

        // REQUIRE ITS OWN PRESENTER AND INTERFACE
        private void saveBtn_Click(object sender, EventArgs e) {
            saveBtn.Text = "Updating...";
            saveBtn.Click -= saveBtn_Click;

            if (String.IsNullOrEmpty(_tempSelectedFilePath)) {
                return;
            }

            try {
                string finalPath = _document.FilePath;
                string extension = _document.Extension;

                
                string ext = Path.GetExtension(_tempSelectedFilePath).ToLower();

                

                if (ext == ".docx" || ext == ".doc") {
                    finalPath = ConvertAndSaveDocx(_tempSelectedFilePath, _document.VehiclePlateNum);
                   
                    extension = ".pdf";
                    if (File.Exists(_document.FilePath)) {
                        File.Delete(_document.FilePath);
                    }
                } else {
                    // Use your existing helper for normal images/PDFs
                    string subFolder = Path.Combine(AppConfig.AppData.VehicleImagePath, _document.VehiclePlateNum);
                    string cleanTitle = _document.Title.Replace(" ", "_");
                    string fileName = $"{_document.Category}-{cleanTitle}-{Guid.NewGuid()}{ext}";
                    finalPath = Classes.Helpers.SaveDocumentToAppData(_tempSelectedFilePath, subFolder, fileName);
                    extension = ext;
                }

                VehicleDocumentDto updatedData = new VehicleDocumentDto {
                    DocumentID = _document.DocumentID,
                    Title = _document.Title,
                    Category = _document.Category,
                    IssuingAuthority = _document.IssuingAuthority,
                    IssueDate = _document.IssueDate,
                    ExpirationDate = inputExpirationDate.Value,
                    FilePath = finalPath,
                    Extension = extension
                };

                _vehicleDocumentServices.UpdateVehicleDocument(updatedData);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveBtn.Text = "Renew Document";
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

            string cleanTitle = _document.Title.Replace(" ", "_");
            string fileName = $"{_document.Category}-{cleanTitle}-{Guid.NewGuid()}.pdf";

            string fullPhysicalPath = Path.Combine(physicalFolder, fileName);

            MessageBox.Show("Error: 1");

            using (Spire.Doc.Document document = new Spire.Doc.Document()) {
                document.LoadFromFile(originalPath);
                document.SaveToFile(fullPhysicalPath, Spire.Doc.FileFormat.PDF);
                document.Close();
            }

            MessageBox.Show("Error: ");

            return Path.Combine(relativeFolder, fileName);
        }



    }
}
