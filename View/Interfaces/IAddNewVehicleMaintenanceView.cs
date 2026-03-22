using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Interfaces {
    internal interface IAddNewVehicleMaintenanceView {
        string PlateNumber { get; }
        string Description { get;}
        int TypeId { get; }

        int? IntervalKm { get;}
        int? IntervalMonths { get; }

        DateTime LastPerformedDate { get; }

        DateTime? NextDueDate { get; }
        int? NextDueOdometer { get; }

        void CloseModal();
        void ShowError(string message);
        void LoadMaintenanceTypes(List<VehicleMaintenanceTypeDto> tasks);
    }
}
