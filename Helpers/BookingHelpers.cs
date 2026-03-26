using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Helpers {
    public static class BookingHelpers {
        public static string GenerateCustomBookingID() {
            string yearMonth = DateTime.Now.ToString("yyyyMM");
            int randomPart = new Random().Next(1000, 9999);

            return $"BK{yearMonth}-{randomPart}";
        }
    }
}
