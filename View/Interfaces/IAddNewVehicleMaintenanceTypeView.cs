using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.View.Interfaces {
    public interface IAddNewVehicleMaintenanceTypeView {  
        string MaintenanceName { get; }
        string Description { get; }

        string Priority { get; }

        int? SuggestedMileageInterval { get; } 
        int? SuggestedMonthInterval { get; }

        void ShowSuccess(string message);
        void ShowError(string message);
        void CloseModal();
    }
}
