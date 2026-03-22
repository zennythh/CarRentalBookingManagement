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

namespace VehicleManagementSystem.UserControls {
    public partial class MaintenanceCardControl : UserControl {
        public MaintenanceCardControl() {
            InitializeComponent();
        }

        public void Bind(VehicleMaintenanceScheduleDto maintenanceSchedule) {
            if (maintenanceSchedule == null) {
                return;
            }

            int mileageInt = (int)maintenanceSchedule.CurrentVehicleMileage;
            string currentStatus = maintenanceSchedule.Status;

            if(maintenanceSchedule.ScheduleType == "OneTime") {
                labelInterval.Text = "One time maintenance";
            } else {
                labelInterval.Text = GetInterval(maintenanceSchedule);
            }

            labelMaintenanceType.Text = maintenanceSchedule.MaintenanceName.ToString();
            labelMaintenanceType.ForeColor = GetStatusColor(currentStatus);
            
            labelStatus.Text = currentStatus;
            labelStatus.ForeColor = GetStatusColor(currentStatus);

            progressCIrcle.ProgressColor = GetStatusColor(currentStatus);
            progressCIrcle.ProgressColor2 = GetStatusColor(currentStatus);

            //double progress = CalculateOverallProgress(maintenanceSchedule, mileageInt);
            //progressCIrcle.Value = (int)progress;

            labelDueDate.Text = maintenanceSchedule.NextDueDate?
                                .ToString("MMM dd, yyyy")
                                ?? "—";
            string nextDueMillage = maintenanceSchedule.NextDueMileage != null ?
                                maintenanceSchedule.NextDueMileage.ToString() + " km" :
                                "—";
            

            labelDueOdometer.Text = $"{maintenanceSchedule.MilesUntilDue} (At {nextDueMillage})";
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

        private Color GetStatusColor(string status) {
            if (status == "Upcoming") {
                return Color.SteelBlue; 
            } else if (status == "Due Soon") {
                return Color.Goldenrod; 
            } else if (status == "Overdue") {
                return Color.IndianRed; 
            } else if (status == "Completed") {
                return Color.SeaGreen; 
            } else {
                return Color.Gray; 
            }
        }

        private string GetInterval(VehicleMaintenanceScheduleDto maintenanceSchedule) {
            var parts = new List<string>();

            if (maintenanceSchedule.MileageInterval.HasValue)
                parts.Add($"{maintenanceSchedule.MileageInterval.Value:N0} km");

            if (maintenanceSchedule.MonthInterval.HasValue)
                parts.Add($"{maintenanceSchedule.MonthInterval.Value} months");

            if (parts.Count == 0)
                return "—";

            return "Every " + string.Join(" or ", parts);
        }

    }
}
