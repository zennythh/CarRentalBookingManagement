using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Dto {
    public class VehicleMaintenanceTypeDto {
        public int MaintenanceTypeID { get; set; }
        public string MaintenanceName { get; set; }
        public string Description { get; set; }

        public string Priority { get; set; }

        public int? SuggestedMileageInterval { get; set; }
        public int? SuggestedMonthInterval { get; set; }

        public override string ToString() {
            return MaintenanceName;
        }
    }
}
