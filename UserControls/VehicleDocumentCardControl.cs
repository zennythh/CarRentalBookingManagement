using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
        }

        private void IntializeData() {
            labelType.Text = _document.Category;
            labelTitle.Text = _document.Title;
            labelExpirationDate.Text = _document.ExpirationDate?.ToString("d") ?? "N/A";
            labelExtension.Text = _document.Extension.ToUpper();

            if(_document.Category != "Required Renewal") {
                btnRenew.Visible = false;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e) {
            string fullFilePath = Path.Combine(AppConfig.AppData.RootPath, _document.FilePath);

            switch (_document.Extension) {
                case ".docx":
                case ".doc":
                case ".pdf":
                    if (!string.IsNullOrEmpty(fullFilePath)) {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(fullFilePath) { UseShellExecute = true });
                    }
                    break;
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

                _vehicleDocumentServices.DeleteVehicleDocument(_document.DocumentID);
                ReloadDocuments();
            }
        }
    }
}
