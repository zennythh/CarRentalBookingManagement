using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Interfaces {
    internal interface IVehicleDetialsMaintenanceView {
        string VehiclePlateNum { get; }

        void DisplayDashboard(List<VehicleMaintenanceScheduleDto> schedules);
        void DisplayMaintenanceSchedule(List<VehicleMaintenanceScheduleDto> maintenanceSchedule);
        void ShowError(string message);
    }
}
