using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDetailsMaintenance : UserControl, IVehicleDetialsMaintenanceView {
        private VehicleDto _vehicle;
        private vehicleDetailsMaintenancePresenter _presenter;

        public string VehiclePlateNum => _vehicle.LicensePlate;

        public VehicleDetailsMaintenance(VehicleDto vehicle) {
            _vehicle = vehicle;
            _presenter = new vehicleDetailsMaintenancePresenter(this, new Services.Implementations.VehicleMaintenanceServices());
            InitializeComponent();

            LoadInformation();
        }

        public void ShowError(string message) {
            MessageBox.Show(message);
        }

        private void LoadInformation() {
            labelCurrentOdometer.Text = _vehicle.CurrentOdometerReading.ToString();
            _presenter.LoadMaintenance();
        }

        public void DisplayMaintenanceSchedule(List<VehicleMaintenanceScheduleDto> maintenanceSchedule) {
            tableMain.SuspendLayout();

            tableMain.Controls.Clear();
            tableMain.RowStyles.Clear();
            tableMain.RowCount = 0;

            int col = 0;
            int row = 0;
            int maxCols = 4;

            var sortedSchedules = maintenanceSchedule
                                .OrderBy(x => x.NextDueDate ?? DateTime.MaxValue)
                                .ToList();


            foreach (var vehicleMaintenanceSchedule in sortedSchedules) {
                if (col == 0) {
                    tableMain.RowCount++;
                    tableMain.RowStyles.Add(
                        new RowStyle(SizeType.AutoSize)
                    );
                }

                var card = new MaintenanceCardControl();
                card.Bind(vehicleMaintenanceSchedule);
                card.Dock = DockStyle.Fill;
                card.Margin = new Padding(10);

                tableMain.Controls.Add(card, col, row);

                col++;
                if (col >= maxCols) {
                    col = 0;
                    row++;
                }
            }

            tableMain.ResumeLayout();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            var addVehicleMaintenanceForm = new AddNewVehicleMaintenanceModal(_vehicle);
            addVehicleMaintenanceForm.ShowDialog();
        }
    }
}
