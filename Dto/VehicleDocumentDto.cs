using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Dto {
    public class VehicleDocumentDto {
        public string Title { get; set; }
        public string Category { get; set; } // e.g., "Registration", "Insurance"
        public string IssuingAuthority { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public string VehiclePlateNum { get; set; }

        public bool IsExpired => ExpirationDate.HasValue && ExpirationDate.Value < DateTime.Now;

        public string FilePath { get; set; }
        public string Extension { get; set; }
    }
}
