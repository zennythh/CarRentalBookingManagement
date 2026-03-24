using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    internal class vehicleDetailsMaintenancePresenter {
        VehicleMaintenanceServices _services;
        IVehicleDetialsMaintenanceView _view;

        public vehicleDetailsMaintenancePresenter(IVehicleDetialsMaintenanceView view, VehicleMaintenanceServices services) { 
            _view = view;
            _services = services;
        }

        public async void LoadMaintenance() {
            try {
                var schedules = await _services.GetMaintenanceSchedulesByVehicle(_view.VehiclePlateNum);
                _view.DisplayDashboard(schedules);
                _view.DisplayMaintenanceSchedule(schedules);
            } catch (Exception ex) { 
                _view.ShowError(ex.Message);
            }
        }

        public async void LoadDashboard() {
            try {
                var schedules = await _services.GetMaintenanceSchedulesByVehicle(_view.VehiclePlateNum);
                _view.DisplayDashboard(schedules);
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
        }

    }   
}
