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

        public void Bind(VehicleMaintenanceScheduleDto maintenanceSchedule, decimal currentMileage) {
            if (maintenanceSchedule == null) {
                return;
            }
            int mileageInt = (int)currentMileage;
            string currentStatus = maintenanceSchedule.GetStatus(mileageInt);

            labelMaintenanceType.Text = maintenanceSchedule.TypeId.ToString();
            labelMaintenanceType.ForeColor = GetStatusColor(currentStatus);
            labelInterval.Text = GetInterval(maintenanceSchedule);
            labelStatus.Text = currentStatus;
            labelStatus.ForeColor = GetStatusColor(currentStatus);

            progressCIrcle.ProgressColor = GetStatusColor(currentStatus);
            progressCIrcle.ProgressColor2 = GetStatusColor(currentStatus);

            double progress = CalculateOverallProgress(maintenanceSchedule, mileageInt);
            progressCIrcle.Value = (int)progress;

            labelDueDate.Text = maintenanceSchedule.NextDueDate?
                                .ToString("MMM dd, yyyy")
                                ?? "—";
            labelDueOdometer.Text = maintenanceSchedule.NextDueOdometer != null ?
                                maintenanceSchedule.NextDueOdometer.ToString() + " km" :
                                "—";
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

            if (maintenanceSchedule.IntervalKm.HasValue)
                parts.Add($"{maintenanceSchedule.IntervalKm.Value:N0} km");

            if (maintenanceSchedule.IntervalMonths.HasValue)
                parts.Add($"{maintenanceSchedule.IntervalMonths.Value} months");

            if (parts.Count == 0)
                return "—";

            return "Every " + string.Join(" or ", parts);
        }


        private double CalculateOverallProgress(VehicleMaintenanceScheduleDto schedule, int currentKm) {
            // 1. Priority: Mileage
            if (schedule.IntervalKm.HasValue && schedule.LastPerformedOdometer.HasValue) {
                return GetOdometerIntervalPercentage(
                    schedule.LastPerformedOdometer.Value,
                    schedule.IntervalKm.Value,
                    currentKm
                );
            }

            // 2. Fallback: Date
            if (schedule.IntervalMonths.HasValue && schedule.LastPerformedDate.HasValue) {
                return GetDateIntervalPercentage(
                    schedule.LastPerformedDate.Value,
                    schedule.IntervalMonths.Value
                );
            }

            return 0;
        }

        private double GetDateIntervalPercentage(DateTime startDate, int intervalMonths) {
            DateTime dueDate = startDate.AddMonths(intervalMonths);
            DateTime today = DateTime.Today;

            if (today <= startDate) return 0;
            if (today >= dueDate) return 100;

            double totalDays = (dueDate - startDate).TotalDays;
            double daysElapsed = (today - startDate).TotalDays;

            if (totalDays <= 0) return 0;

            double progress = (daysElapsed / totalDays) * 100;
            return Math.Round(progress, 2);
        }
    }
}
