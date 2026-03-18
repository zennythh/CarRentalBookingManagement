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

        public AddNewVehicleDocumentModal(string PlateNumber) {
            InitializeComponent();
            InitializeComboBox();

            labelHeader.Text = "Adding new document to " + PlateNumber;
        }

        private void InitializeComboBox() {
            inputDocumentType.DataSource = Enum.GetValues(typeof(VehicleDocumentEnums.Type));
            
        }

        // Should have a notice before closing the modal if there was change/s in the input fields
        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void inputHasExpirationDate_CheckedChanged(object sender, EventArgs e) {
            inputExpirationDate.Visible = inputHasExpirationDate.Checked;
            labelExpirationDate.Visible = inputHasExpirationDate.Checked;
        }
    }
}
