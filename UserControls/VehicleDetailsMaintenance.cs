using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDetailsMaintenance : UserControl {
        private VehicleDto _vehicle;
        private List<VehicleMaintenanceScheduleDto> _maintenanceSchedules;

        private void InitializeMockData() {

            return;

            //_maintenanceSchedules = new List<VehicleMaintenanceScheduleDto>
            //    {
            //    new VehicleMaintenanceScheduleDto
            //    {
            //        PlateNumber = "ABC-1234",
            //        MaintenanceType = "Oil & Filter Change",
            //        Description = "Replace engine oil and oil filter",
            //        IntervalKm = 10000,
            //        IntervalMonths = 6,
            //        LastPerformedDate = new DateTime(2023, 11, 12),
            //        LastPerformedOdometer = 33560,
            //        NextDueDate = new DateTime(2024, 5, 12),
            //        NextDueOdometer = 43680,
            //    },

            //    new VehicleMaintenanceScheduleDto
            //    {
            //        PlateNumber = "ABC-1234",
            //        MaintenanceType = "Tire Rotation",
            //        Description = "Rotate tires for even tread wear",
            //        IntervalKm = 20000,
            //        IntervalMonths = 12,
            //        LastPerformedDate = new DateTime(2023, 4, 10),
            //        LastPerformedOdometer = 23560,
            //        NextDueOdometer = 43560,
            //    },

            //    new VehicleMaintenanceScheduleDto
            //    {
            //        PlateNumber = "ABC-1234",
            //        MaintenanceType = "Brake Inspection",
            //        Description = "Inspect brake pads, discs, and brake fluid",
            //        IntervalKm = 20000,
            //        IntervalMonths = 12,
            //        LastPerformedDate = new DateTime(2022, 10, 10),
            //        LastPerformedOdometer = 15560,
            //        NextDueOdometer = 35560,
            //    },

            //    new VehicleMaintenanceScheduleDto
            //    {
            //        PlateNumber = "ABC-1234",
            //        MaintenanceType = "Transmission Fluid Change",
            //        Description = "Replace automatic transmission fluid",
            //        IntervalKm = 40000,
            //        IntervalMonths = 24,
            //        LastPerformedDate = new DateTime(2021, 4, 15),
            //        LastPerformedOdometer = 5600,
            //        NextDueOdometer = 45600,
            //    },

            //    new VehicleMaintenanceScheduleDto
            //    {
            //        PlateNumber = "ABC-1234",
            //        MaintenanceType = "Air Filter Replacement",
            //        Description = "Replace engine air filter",
            //        IntervalKm = 20000,
            //        IntervalMonths = 12,
            //        LastPerformedDate = new DateTime(2023, 11, 12),
            //        LastPerformedOdometer = 33560,
            //        NextDueOdometer = 53560,
            //    },

            //    new VehicleMaintenanceScheduleDto
            //    {
            //        PlateNumber = "ABC-1234",
            //        MaintenanceType = "Coolant Replacement",
            //        IntervalKm = 50000,
            //        IntervalMonths = 24,
            //        LastPerformedDate = new DateTime(2022, 5, 5),
            //        LastPerformedOdometer = 18560,
            //        NextDueOdometer = 68560,
            //    }
            //};
        }

        int GetPriorityOrder(string priority) {
            if (priority == "High") return 0;
            if (priority == "Medium") return 1;
            if (priority == "Low") return 2;
            return 3;
        }

        public VehicleDetailsMaintenance(VehicleDto vehicle) {
            _vehicle = vehicle;
            InitializeComponent();

            InitializeMockData();
            //DisplayMaintenanceSchedule(_maintenanceSchedules);
            LoadInformation();
        }

        private void LoadInformation() {
            labelCurrentOdometer.Text = _vehicle.CurrentOdometerReading.ToString();
            
        }

        private void DisplayMaintenanceSchedule(List<VehicleMaintenanceScheduleDto> maintenanceSchedule) {
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
                card.Bind(vehicleMaintenanceSchedule, _vehicle.CurrentOdometerReading);
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
