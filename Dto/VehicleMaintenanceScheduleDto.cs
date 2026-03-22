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
        public string PlateNumber { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }

        public int? IntervalKm { get; set; }
        public int? IntervalMonths { get; set; }

        public DateTime? LastPerformedDate { get; set; }
        public int? LastPerformedOdometer { get; set; }

        public DateTime? NextDueDate { get; set; }
        public int? NextDueOdometer { get; set; }

        public string GetStatus(int currentMileage) {
            if (NextDueOdometer == null && NextDueDate == null) return "Inactive";

            bool isMileageOverdue = NextDueOdometer.HasValue && currentMileage >= NextDueOdometer.Value;
            bool isDateOverdue = NextDueDate.HasValue && DateTime.Today >= NextDueDate.Value;

            if (isMileageOverdue || isDateOverdue) return "Overdue";

            bool isMileageSoon = NextDueOdometer.HasValue && (NextDueOdometer.Value - currentMileage) <= 500;
            bool isDateSoon = NextDueDate.HasValue && (NextDueDate.Value - DateTime.Today).TotalDays <= 14;

            if (isMileageSoon || isDateSoon) return "Due Soon";

            return "Upcoming";
        }
    }
}
