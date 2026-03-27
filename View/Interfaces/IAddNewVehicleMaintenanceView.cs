using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Interfaces {
    internal interface IAddNewVehicleMaintenanceView {
        string VehiclePlateNum { get; }
        string Description { get;}
        int MaintenanceTypeID { get; }

        decimal VehicleCurrentOdometer { get; }

        string ScheduleType { get; }

        DateTime? DueDate { get; }
        int? DueMileage { get; }

        // Recurrence
        int? MileageInterval { get;}
        int? MonthInterval { get; }

        DateTime LastServiceDate { get; }

        void CloseModal();
        void ShowSuccess(string message);
        void ShowError(string message);
        void LoadMaintenanceTypesInInput(List<VehicleMaintenanceTypeDto> tasks);
    }
}
