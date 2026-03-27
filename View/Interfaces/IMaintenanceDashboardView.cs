using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Interfaces {
    internal interface IMaintenanceDashboardView {
        void SetIsLoading(bool isLoading);
        void DisplayDashboard(List<VehicleMaintenanceScheduleDto> schedules);
        void DisplayUrgents(List<VehicleMaintenanceScheduleDto> schedules);
        void DisplayUpcoming(List<VehicleMaintenanceScheduleDto> schedules);
    }
}
