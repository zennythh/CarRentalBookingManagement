using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Dto {
    public class VehicleMaintenanceScheduleDto {
        public int ScheduleID { get; set; }
        public string VehiclePlateNum { get; set; }
        public int MaintenanceTypeID { get; set; }
        public string MaintenanceName { get; set; }
        public string ScheduleType { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }

        // One-time fields
        public DateTime? DueDate { get; set; }
        public decimal? DueMileage { get; set; }

        // Recurring fields
        public int? MileageInterval { get; set; }
        public int? MonthInterval { get; set; }
        public decimal? LastServiceMileage { get; set; }
        public DateTime? LastServiceDate { get; set; }

        public DateTime? CompletedDate { get; set; }

        public decimal CurrentVehicleMileage { get; set; }

        public DateTime? NextDueDate {
            get {
                if (ScheduleType == "OneTime") {
                    return DueDate;
                } else if (ScheduleType == "Recurring" && MonthInterval.HasValue && LastServiceDate.HasValue) {
                    return LastServiceDate.Value.AddMonths(MonthInterval.Value);
                }
                return null;
            }
        }

        public decimal? NextDueMileage {
            get {
                if (ScheduleType == "OneTime") {
                    return DueMileage + CurrentVehicleMileage;
                } else if (ScheduleType == "Recurring" && MileageInterval.HasValue) {
                    if (LastServiceMileage.HasValue) {
                        return LastServiceMileage.Value + MileageInterval.Value;
                    } else {
                        return CurrentVehicleMileage + MileageInterval;
                    }
                }

                return null;
            }
        }

        public int? DaysUntilDue {
            get {
                if (NextDueDate.HasValue) {
                    return (NextDueDate.Value - DateTime.Now).Days;
                }
                return null;
            }
        }

        public decimal? MilesUntilDue {
            get {
                if (NextDueMileage.HasValue) {
                    return NextDueMileage.Value - CurrentVehicleMileage;
                }
                return null;
            }
        }

        public int MaintenanceProgressPercentage {
            get {
                if (ScheduleType == "Recurring") {
                    if (MileageInterval.HasValue && LastServiceMileage.HasValue && NextDueMileage.HasValue) {
                        decimal milesSinceLastService = CurrentVehicleMileage - LastServiceMileage.Value;
                        decimal progress = (milesSinceLastService / MileageInterval.Value) * 100;
                        return (int)Math.Min(100, Math.Max(0, progress));
                    }

                    if (MonthInterval.HasValue && LastServiceDate.HasValue && NextDueDate.HasValue) {
                        double totalDays = (NextDueDate.Value - LastServiceDate.Value).TotalDays;
                        double daysPassed = (DateTime.Now - LastServiceDate.Value).TotalDays;
                        double progress = (daysPassed / totalDays) * 100;
                        return (int)Math.Min(100, Math.Max(0, progress));
                    }
                } else // OneTime
                  {
                    if (DueMileage.HasValue) {
                        // Calculate how close we are to due mileage
                        decimal milesRemaining = DueMileage.Value - CurrentVehicleMileage;
                        if (milesRemaining <= 0) return 100;
                        if (milesRemaining >= 1000) return 0;

                        return (int)((1000 - milesRemaining) / 1000 * 100);
                    }

                    if (DueDate.HasValue) {
                        int daysRemaining = (DueDate.Value - DateTime.Now).Days;
                        if (daysRemaining <= 0) return 100;
                        if (daysRemaining >= 30) return 0;

                        return (int)((30 - daysRemaining) / 30.0 * 100);
                    }
                }

                return 0;
            }
        }

        public bool IsOverdue {
            get {
                if (Status != "Scheduled") return false;

                bool dateOverdue = NextDueDate.HasValue && NextDueDate.Value < DateTime.Now;
                bool mileageOverdue = MilesUntilDue.HasValue && MilesUntilDue.Value <= 0;

                return dateOverdue || mileageOverdue;
            }
        }

        public bool IsDueSoon {
            get {
                if (Status != "Scheduled") return false;

                bool dateDueSoon = DaysUntilDue.HasValue && DaysUntilDue.Value >= 0 && DaysUntilDue.Value <= 7;
                bool mileageDueSoon = MilesUntilDue.HasValue && MilesUntilDue.Value > 0 && MilesUntilDue.Value <= 500;

                return dateDueSoon || mileageDueSoon;
            }
        }


    }
}
