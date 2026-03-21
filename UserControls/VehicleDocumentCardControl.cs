using Sprache;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Media;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDocumentCardControl : UserControl {
        VehicleDocumentDto _document;
        VehicleDocumentServices _vehicleDocumentServices;

        private Action ReloadDocuments;

        public VehicleDocumentCardControl() {
            InitializeComponent();
        }

        public void Bind(VehicleDocumentDto document, Action PassedReloadDocuments) {
            _document = document;
            ReloadDocuments = PassedReloadDocuments;
            _vehicleDocumentServices = new VehicleDocumentServices();
            IntializeData();
            SetStatus();
        }

        private void SetStatus() {
            if (!_document.ExpirationDate.HasValue) {
                labelStatus.Text = "Active";
                panelStatus.FillColor = System.Drawing.Color.FromArgb(82, 183, 136);
                return;
            }

            DateTime expiration = _document.ExpirationDate.Value;
            DateTime today = DateTime.Today;

            if (expiration <= today) {
                labelStatus.Text = "Expired";
                panelStatus.FillColor = System.Drawing.Color.FromArgb(230, 57, 70);
            } else if ((expiration - today).TotalDays <= 30) {
                // Within the 30-day warning window
                labelStatus.Text = "Expiring Soon";
                panelStatus.FillColor = System.Drawing.Color.FromArgb(255, 183, 3); ;
            } else {
                // More than 30 days remaining
                labelStatus.Text = "Active";
                panelStatus.FillColor = System.Drawing.Color.FromArgb(82, 183, 136);
            }
        }

        private void IntializeData() {
            labelType.Text = _document.Category;
            labelTitle.Text = _document.Title;
            labelExpirationDate.Text = _document.ExpirationDate?.ToString("d") ?? "N/A";
            labelExtension.Text = _document.Extension.ToUpper();

            if(_document.Category != "Required Renewal") {
                btnRenew.Visible = false;
                btnDelete.Location = new Point(btnDelete.Location.X - btnDelete.Width - 5, btnDelete.Location.Y);
            }
        }

        private void viewBtn_Click(object sender, EventArgs e) {
            string fullFilePath = Path.Combine(AppConfig.AppData.RootPath, _document.FilePath);

            switch (_document.Extension) {
                case ".docx":
                case ".doc":
                    if (!string.IsNullOrEmpty(fullFilePath)) {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(fullFilePath) { UseShellExecute = true });
                    }
                    break;
                case ".pdf":
                case ".jpg":
                case ".png":
                case ".jpeg":
                    var ImagePreviewModal = new ImagePreviewModal(_document.Title, fullFilePath);
                    ImagePreviewModal.ShowDialog();
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            using (var DeleteDocumentModal = new DeleteVehcleDocumentModal(_document)) {
                DialogResult result = DeleteDocumentModal.ShowDialog();

                if (result != DialogResult.OK) return;

                try {
                    string fullPath = Path.Combine(AppConfig.AppData.RootPath, _document.FilePath);

                    if (File.Exists(fullPath)) {
                        File.Delete(fullPath);
                    }
   
                    _vehicleDocumentServices.DeleteVehicleDocument(_document.DocumentID);
                    ReloadDocuments?.Invoke();

                } catch (IOException ex) {
                    MessageBox.Show("The file is currently in use by another process and cannot be deleted.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex) {
                    MessageBox.Show($"An error occurred while deleting: {ex.Message}");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            using (var UpdateVehicleDocumentModal = new UpdateVehicleDocumentModal(_document)) {
                DialogResult result = UpdateVehicleDocumentModal.ShowDialog();

                if (result != DialogResult.OK) return;
                ReloadDocuments?.Invoke();
            }
        }

        private void btnRenew_Click(object sender, EventArgs e) {
            using (var RenewVehicleDocumentModal = new RenewVehicleDocumentModal(_document)) {
                DialogResult result = RenewVehicleDocumentModal.ShowDialog();

                if (result != DialogResult.OK) return;
                ReloadDocuments?.Invoke();
            }
        }



    }
}
