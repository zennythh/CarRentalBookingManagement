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
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class MaintenanceCardControl : UserControl {
        VehicleMaintenanceScheduleDto _maintenanceSchedule;

        public MaintenanceCardControl() {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        private Action _reloadDisplay;

        public void BindAction(Action ReloadDisplay) {
            _reloadDisplay = ReloadDisplay;
        }

        public void Bind(VehicleMaintenanceScheduleDto maintenanceSchedule) {
            if (maintenanceSchedule == null) {
                return;
            }

            _maintenanceSchedule = maintenanceSchedule;

            int mileageInt = (int)maintenanceSchedule.CurrentVehicleMileage;
            string currentStatus = maintenanceSchedule.IsUpcoming ? "Upcoming" :
                                   maintenanceSchedule.IsDueSoon ? "Due Soon" :
                                   maintenanceSchedule.IsOverdue ? "Over Due" :
                                   maintenanceSchedule.Status == "Completed" ? "Completed" 
                                   : "Cancelled";

            if(maintenanceSchedule.ScheduleType == "OneTime") {
                labelInterval.Text = "One time maintenance";
            } else {
                labelInterval.Text = GetInterval(maintenanceSchedule);
            }

            labelMaintenanceType.Text = maintenanceSchedule.MaintenanceName.ToString();
            labelMaintenanceType.ForeColor = GetStatusColor(maintenanceSchedule);
            
            labelStatus.Text = currentStatus;
            labelStatus.ForeColor = GetStatusColor(maintenanceSchedule);

            progressCIrcle.ProgressColor = GetStatusColor(maintenanceSchedule);
            progressCIrcle.ProgressColor2 = GetStatusColor(maintenanceSchedule);
            
            progressCIrcle.Value = maintenanceSchedule.MaintenanceProgressPercentage;

            labelDueDate.Text = maintenanceSchedule.NextDueDate?
                                .ToString("MMM dd, yyyy")
                                ?? "—-";
            string nextDueMillage = maintenanceSchedule.NextDueMileage != null ?
                                maintenanceSchedule.NextDueMileage.ToString() + " km" :
                                null;
            

            labelDueOdometer.Text = nextDueMillage != null ? $"In {maintenanceSchedule.MilesUntilDue}Km (At {nextDueMillage})" : "--";
            ;
        }

        private double GetOdometerIntervalPercentage( int startKm,int intervalKm, int currentKm) {
                    if (intervalKm <= 0)
                        return 0;

                    // Clamp currentKm within range
                    if (currentKm <= startKm)
                        return 0;

                    if (currentKm >= startKm + intervalKm)
                        return 100;

                    double progress = (double)(currentKm - startKm) / intervalKm * 100;
                    return Math.Round(progress, 2);
        }

        private Color GetStatusColor(VehicleMaintenanceScheduleDto maintenanceSchedule) {
            if (maintenanceSchedule.Status == "Completed") {
                return Color.SeaGreen;
            } else if (maintenanceSchedule.IsUpcoming) {
                return Color.SteelBlue; 
            } else if (maintenanceSchedule.IsDueSoon) {
                return Color.Goldenrod; 
            } else if (maintenanceSchedule.IsOverdue) {
                return Color.IndianRed; 
            }  else {
                return Color.Gray; 
            }
        }

        private string GetInterval(VehicleMaintenanceScheduleDto maintenanceSchedule) {
            var parts = new List<string>();

            if (maintenanceSchedule.MileageInterval.HasValue)
                parts.Add($"{maintenanceSchedule.MileageInterval.Value:N0} km");

            if (maintenanceSchedule.MonthInterval.HasValue)
                parts.Add($"{maintenanceSchedule.MonthInterval.Value} month/s");

            if (parts.Count == 0)
                return "—";

            return "Every " + string.Join(" or ", parts);
        }

        private void Card_Click(object sender, EventArgs e) {
            using(var viewCardModal = new ViewVehicleMaintenanceModal(_maintenanceSchedule)) {
                DialogResult dialogResult = viewCardModal.ShowDialog();

                if (dialogResult != DialogResult.OK) return;

                if(_reloadDisplay == null) return;

                _reloadDisplay();
            }
        }
    }
}
