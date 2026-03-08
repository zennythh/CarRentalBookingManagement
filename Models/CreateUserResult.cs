using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_VehicleRental.Model
{
    public class CreateUserResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
    }
}
