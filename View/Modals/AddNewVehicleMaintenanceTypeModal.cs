using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleMaintenanceTypeModal : Form, IAddNewVehicleMaintenanceTypeView {
        addNewVehicleMaintenanceTypePresenter _presenter;

        public string TaskName => inputTaskName.Text.Trim();
        public string Description => inputDescription.Text.Trim();

        public int? DefaultMileageInterval {
            get {
                if (int.TryParse(inputSuggestedMilleage.Text.Trim(), out int result)) {
                    return result;
                }
                return null;
            }
        }

        public int? DefaultMonthInterval {
            get {
                if (int.TryParse(inputSuggestedMonthly.Text.Trim(), out int result)) {
                    return result;
                }
                return null;
            }
        }

        public void ShowSuccess(string message) {
            MessageBox.Show(message, "Success!");
        }

        public void ShowError(string message) {
            MessageBox.Show(message, "Error");
        }

        public void CloseModal() {
            this.Close();
        }

        public AddNewVehicleMaintenanceTypeModal() {
            InitializeComponent();
            _presenter = new addNewVehicleMaintenanceTypePresenter(this, new Services.Implementations.VehicleMaintenanceServices());
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            saveBtn.Text = "Saving...";
            saveBtn.Click -= saveBtn_Click;
            _presenter.SaveMaintenanceType();
            saveBtn.Click += saveBtn_Click;
        }

    }
}
