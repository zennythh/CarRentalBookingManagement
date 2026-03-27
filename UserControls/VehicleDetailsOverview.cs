using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Forms;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Modals;


using MySqlX.XDevAPI;
using PL_VehicleRental.Services.Security;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDetailsOverview : UserControl {
        private VehicleDto _vehicle;
        private VehicleServices _vehicleServices;

        public VehicleDetailsOverview(VehicleDto vehicle) {
            _vehicle = vehicle;
            _vehicleServices = new VehicleServices();
            InitializeComponent();
            LoadVehicleImage();
            InitializeCombos();

            LoadVehicleInformation();
            LoadComboBoxInformation();
            deleteBtn.Visible = PL_VehicleRental.Services.Security.Session.User.Role != UserRole.Staff;
        }

        private void editBtn_Click(object sender, EventArgs e) {        
            ToggleUIVisibility();
            ToggleInputsEnable();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            // Require Validationr

            ToggleUIVisibility();
            ToggleInputsEnable();
        }

        private void LoadVehicleImage() {
            pictureVehicle.Image = VehicleManagementSystem.Classes.Helpers.GetVehicleImage(_vehicle.ImagePath);
        }

        private void LoadVehicleInformation() {
            inputOdomter.Text = _vehicle.CurrentOdometerReading.ToString() + " km";

            inputCategory.Text = _vehicle.Category;
            labelStatus.Text = _vehicle.CurrentStatus;
            inputColor.Text = _vehicle.Color;
            inputManufacturer.Text = _vehicle.Manufacturer;
            inputModel.Text = _vehicle.Model;
            inputPlateNum.Text = _vehicle.LicensePlate;
            inputPurchasePrice.Text = "₱" + _vehicle.PurchasePrice.ToString();
            inputSeatingCap.Text = _vehicle.SeatingCapacity.ToString();
            inputVehicleIdentification.Text = _vehicle.VIN;
            inputYearModel.Text = _vehicle.YearModel.ToString();

            inputPurchaseDate.Value = _vehicle.PurchaseDate;
            inputPurchaseDate.Enabled = false;
        }

        private void LoadComboBoxInformation() {
            var fuelTypeMap = new Dictionary<string, VehicleEnums.FuelType>{
                { "Gasoline", VehicleEnums.FuelType.Gasoline },
                { "Diesel", VehicleEnums.FuelType.Diesel },
                { "Electric", VehicleEnums.FuelType.Electric }
            };

            if (fuelTypeMap.TryGetValue(_vehicle.FuelType, out var fuelType)) {
                inputFuelType.SelectedItem = fuelType;
            }

            inputFuelType.Enabled = false;

            var transmissionTypeMap = new Dictionary<string, VehicleEnums.TransmissionType>{
                { "Manual", VehicleEnums.TransmissionType.Manual},
                { "Automatic", VehicleEnums.TransmissionType.Automatic },
                { "SemiAutomatic", VehicleEnums.TransmissionType.SemiAutomatic }
            };

            if (transmissionTypeMap.TryGetValue(_vehicle.FuelType, out var transmissionType)) {
                inputTransmissionType.SelectedItem = transmissionType;
            }

            inputTransmissionType.Enabled = false;
        }


        private void ToggleUIVisibility() {
            //labelEdittingModeNotice.Visible = !labelEdittingModeNotice.Visible;
            editBtn.Visible = !editBtn.Visible;
            saveBtn.Visible = !saveBtn.Visible;
            deleteBtn.Visible = !deleteBtn.Visible;
        }

        private void ToggleInputsEnable() {
            inputOdomter.ReadOnly = !inputOdomter.ReadOnly;
            inputFuelType.Enabled = !inputFuelType.Enabled;
            inputTransmissionType.Enabled = !inputTransmissionType.Enabled;

            inputVehicleIdentification.ReadOnly = !inputVehicleIdentification.ReadOnly;
            inputPlateNum.ReadOnly = !inputPlateNum.ReadOnly;
            inputManufacturer.ReadOnly = !inputManufacturer.ReadOnly;
            inputModel.ReadOnly = !inputModel.ReadOnly;
            inputYearModel.ReadOnly = !inputYearModel.ReadOnly;

            inputColor.ReadOnly = !inputColor.ReadOnly;
            inputSeatingCap.ReadOnly = !inputSeatingCap.ReadOnly;
            inputPurchasePrice.ReadOnly = !inputPurchasePrice.ReadOnly;

            inputPurchaseDate.Enabled = !inputPurchaseDate.Enabled;
        }

        private void InitializeCombos() {
            inputFuelType.DataSource = Enum.GetValues(typeof(VehicleEnums.FuelType));
            inputTransmissionType.DataSource = Enum.GetValues(typeof(VehicleEnums.TransmissionType));
        }


        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        

        private void viewMaintenanceBtn_Click(object sender, EventArgs e) {
         //   frmVehicleDetails.Instance.OpenSubPanel(new VehicleDetailsDocuments(_vehicle));
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this vehicle? This action will be recorded in the system audit logs.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;
            
            using (var DeleteVehicleModal = new DeleteVehicleModal(_vehicle)) {
                if (DeleteVehicleModal.ShowDialog() == DialogResult.OK) {
                    DeleteVehicleByPlateNum(_vehicle.LicensePlate);
                }
            }

        }

        private async void DeleteVehicleByPlateNum(string plateNumber) {
            try {
                await _vehicleServices.SoftDeleteVehicle(plateNumber);
                NavigationHelper.OpenForm(new frmVehicleManagement());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
