using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Data.Enums;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleDocumentModal : Form {

        string documentType;
        string documentTitle => inputDocumentTitle.Text;
        

        public AddNewVehicleDocumentModal(string PlateNumber) {
            InitializeComponent();

            labelHeader.Text = "Adding new document to " + PlateNumber;
        }

   

        // Should have a notice before closing the modal if there was change/s in the input fields
        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Radio_CheckedChanged(object sender, EventArgs e) {
            var selectedRadio = this.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);

            documentType = selectedRadio.Text;

            if(documentType != "Permanent") {
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    if (vehiclePictureBox.Image != null) {
                        vehiclePictureBox.Image.Dispose();
                    }

                    _userInputted = true;
                    clearImageInputError();

                    string fullPath = openFileDialog.FileName;
                    string fileNameOnly = Path.GetFileName(fullPath);

                    _tempSelectedImagePath = fullPath;

                    vehiclePictureBox.Image = Image.FromFile(fullPath);

                    closeImageBtn.Visible = true;
                    addImageBtn.Visible = false;

                }
            }
        }

        private void AddNewVehicleDocumentModal_Load(object sender, EventArgs e) {
            inputDocumentTitle.Focus();
            inputExpirationDate.MinDate = DateTime.Today;
            inputExpirationDate.Value = DateTime.Today.AddYears(1);

            inputIssueDate.MaxDate = DateTime.Today;
            inputIssueDate.Value = DateTime.Today;
        }
    }
}
