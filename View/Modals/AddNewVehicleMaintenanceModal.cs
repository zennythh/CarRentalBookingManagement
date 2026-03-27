using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleMaintenanceModal : Form, IAddNewVehicleMaintenanceView {
        AddNewVehicleMaintenancePresenter _presenter;
        VehicleDto _vehicle;

        public string VehiclePlateNum => _vehicle.LicensePlate;
        public decimal VehicleCurrentOdometer => _vehicle.CurrentOdometerReading;
        public int MaintenanceTypeID => (inputType.SelectedItem as VehicleMaintenanceTypeDto)?.MaintenanceTypeID ?? 0;
        public string ScheduleType => inputScheduleType.Text;
        public string Description => (inputType.SelectedItem as VehicleMaintenanceTypeDto)?.Description.ToString() ?? " ";

        // One time
        public DateTime? DueDate => inputDueDate.Value;
        public int? DueMileage => int.TryParse(inputDueMileige.Text, out int res) ? res : (int?)null;


        // Recuurence
        public int? MileageInterval { get {
                if (int.TryParse(inputMilleageInterval.Text, out int result)) return result;
                return null;
            }
        }

        public int? MonthInterval { get {
                if (int.TryParse(inputMonthlyInterval.Text, out int result)) return result;
                return null;
            }
        }

        public string MaintenanceName => inputType.Text;


        public void CloseModal() {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void ShowSuccess(string message) {
            MessageBox.Show(message, "Success");
        }

        public void ShowError(string message) {
            MessageBox.Show(message, "Error");
        }

        public DateTime LastServiceDate => inputLastServiceDate.Value;

        public VehicleMaintenanceTypeDto SelectedType {
            get { return inputType.SelectedItem as VehicleMaintenanceTypeDto; }
        }

        public AddNewVehicleMaintenanceModal(VehicleDto vehicle) {
            InitializeComponent();
            _vehicle = vehicle;
            _presenter = new AddNewVehicleMaintenancePresenter(this, new Services.Implementations.VehicleMaintenanceServices());

            inputLastServiceDate.Value = DateTime.Today;
            inputLastServiceDate.MaxDate = DateTime.Today;

            inputDueDate.MinDate = DateTime.Today;

            labelHeader.Text = "Adding new maintenance schedule to " + _vehicle.LicensePlate;

            string[] priorities = { "Recurring", "OneTime" };
            inputScheduleType.Items.AddRange(priorities);
            inputScheduleType.SelectedIndex = 0;
        }

        private void LoadPreviewCard() {
            var newMaintenanceSchedule = new VehicleMaintenanceScheduleDto {
                MaintenanceTypeID = MaintenanceTypeID,
                MaintenanceName = MaintenanceName,
                ScheduleType = ScheduleType,
                DueDate = DueDate,
                DueMileage = DueMileage,
                MileageInterval = MileageInterval,
                MonthInterval = MonthInterval,
                LastServiceDate = LastServiceDate,
                VehiclePlateNum = _vehicle.LicensePlate,
                CurrentVehicleMileage = _vehicle.CurrentOdometerReading,
                Status = "Upcoming"
            };

            maintenanceCardControl.Bind(newMaintenanceSchedule);
        }

        public void LoadMaintenanceTypesInInput(List<VehicleMaintenanceTypeDto> types) {
            inputType.DataSource = null; 
            inputType.DataSource = types;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddNewVehicleMaintenanceModal_Load(object sender, EventArgs e) {
            _presenter.LoadMaintenanceTypes(true, VehiclePlateNum);
            LoadPreviewCard();
        }

        private void PreviewCard_Load(object sender, EventArgs e) {
            LoadPreviewCard();
        }

        private void cmbMaintenanceTask_SelectedIndexChanged(object sender, EventArgs e) {
            if (SelectedType != null) {
                inputMilleageInterval.Text = SelectedType.SuggestedMileageInterval?.ToString() ?? "";
                inputMonthlyInterval.Text = SelectedType.SuggestedMonthInterval?.ToString() ?? "";
            }

            LoadPreviewCard();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            saveBtn.Click -= saveBtn_Click;
            saveBtn.Text = "Saving...";
            _presenter.SaveMaintenanceSchedule();
            saveBtn.Text = "Save Schedule";
            saveBtn.Click += saveBtn_Click;
        }

        private void inputScheduleType_SelectedIndexChanged(object sender, EventArgs e) {
            if(ScheduleType == "OneTime") {
                panelIntervalSettings.Visible = false;
                panelDueSettings.Visible = true;
                _presenter.LoadMaintenanceTypes(false, VehiclePlateNum);
            } else {
                panelDueSettings.Visible = false;
                panelIntervalSettings.Visible = true;
                _presenter.LoadMaintenanceTypes(true, VehiclePlateNum);
            }

            LoadPreviewCard();
        }

    }
}
