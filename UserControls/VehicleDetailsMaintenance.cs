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

        public void DisplayDashboard(List<VehicleMaintenanceScheduleDto> schedules) {
            int total = schedules.Count;
            int upcoming = schedules.Count(s => s.IsUpcoming);
            int dueSoon = schedules.Count(s => s.IsDueSoon);
            int overdue = schedules.Count(s => s.IsOverdue);

            labelTotalCount.Text = total.ToString();
            labelUpcomingCount.Text = upcoming.ToString();
            labelDueSoonCount.Text = dueSoon.ToString();
            labelOverDueCount.Text = overdue.ToString();

            DisplayMostUpcoming(schedules);
        }

        public void DisplayMostUpcoming(List<VehicleMaintenanceScheduleDto> schedules) {
            var mostUrgent = schedules
                .Where(s => s.Status == "Scheduled")
                .OrderByDescending(s => s.MaintenanceProgressPercentage)
                .FirstOrDefault();

            if (mostUrgent != null) {
                labelMostUpcomingName.Text = mostUrgent.MaintenanceName;

                labelMostUpcomingDetials.Text = mostUrgent.MilesUntilDue < mostUrgent.DaysUntilDue * 50
                    ? $"{mostUrgent.MilesUntilDue:N0} km remaining"
                    : $"{mostUrgent.DaysUntilDue} days remaining";
            }
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
                card.BindAction(LoadAllData);
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

        public void LoadAllData() {
            _presenter.LoadDashboard();
            _presenter.LoadMaintenance();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            using(var addVehicleMaintenanceForm = new AddNewVehicleMaintenanceModal(_vehicle)) {
                DialogResult dialogResult = addVehicleMaintenanceForm.ShowDialog();

                if (dialogResult != DialogResult.OK) return;

                LoadAllData();
            }
            
        }

        private void btnAddType_Click(object sender, EventArgs e) {
            using (var AddNewVehicleMaintenanceTypeModal = new AddNewVehicleMaintenanceTypeModal()) {
                AddNewVehicleMaintenanceTypeModal.ShowDialog();
            }
        }
    }
}
