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
