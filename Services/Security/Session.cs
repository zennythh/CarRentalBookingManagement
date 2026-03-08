using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Services.Security
{
    public static class Session
    {
        public static CurrentUser User { get; set; }
    }
}
