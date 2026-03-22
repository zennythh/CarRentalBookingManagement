using System;
using System.Windows.Forms;
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleMaintenanceTypeModal : Form, IAddNewVehicleMaintenanceTypeView {
        addNewVehicleMaintenanceTypePresenter _presenter;

        public string MaintenanceName => inputTaskName.Text.Trim();
        public string Description => inputDescription.Text.Trim();
        public string Priority => inputPriotiyLevel.Text.Trim();

        public int? SuggestedMileageInterval { get {
            if (int.TryParse(inputSuggestedMilleage.Text.Trim(), out int result)) {
                return result;
            }
            return null;
        } }

        public int? SuggestedMonthInterval { get {
            if (int.TryParse(inputSuggestedMonthly.Text.Trim(), out int result)) {
                return result;
            }
            return null;
        }}

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

            string[] priorities = { "Critical", "High", "Normal", "Low" };
            inputPriotiyLevel.Items.AddRange(priorities);
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
