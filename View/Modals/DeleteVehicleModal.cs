using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Modals {
    public partial class DeleteVehicleModal : Form {
        public DeleteVehicleModal(VehicleDto vehicle) {
            InitializeComponent();

            labelHeader.Text = $"Deletion of Vehicle ({vehicle.LicensePlate})";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(inputReason.Text)) {
                MessageBox.Show("Reason is required.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
