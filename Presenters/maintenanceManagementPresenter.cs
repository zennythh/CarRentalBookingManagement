using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    internal class maintenanceManagementPresenter {
        IMaintenanceManagementView _view;
        VehicleMaintenanceServices _vehicleMaintenanceServices;

        public maintenanceManagementPresenter(IMaintenanceManagementView view, VehicleMaintenanceServices vehicleMaintenanceServices) {
            _view = view;
            _vehicleMaintenanceServices = vehicleMaintenanceServices;
        }

        public void AddNewMaintenanceType() { 
        
        }



    }
}
