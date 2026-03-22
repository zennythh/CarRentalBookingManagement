using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    internal class AddNewVehicleMaintenancePresenter {
        IAddNewVehicleMaintenanceView _view;
        VehicleMaintenanceServices _service;

        public AddNewVehicleMaintenancePresenter(IAddNewVehicleMaintenanceView view, VehicleMaintenanceServices service) {
            _view = view;
            _service = service;
        }

        public void LoadMaintenanceTypes() {
            try {
                var maintenanceTypes = _service.GetAllTaskDefinitions();
                _view.LoadMaintenanceTypes(maintenanceTypes);
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
        }

        public void SaveMaintenanceSchedule() {
            var newMaintenanceSchedule = new VehicleMaintenanceScheduleDto {
                MaintenanceTypeID = _view.MaintenanceTypeID,

                MileageInterval = _view.MonthInterval,
                MonthInterval = _view.MonthInterval,

                LastServiceDate = _view.LastServiceDate,

                VehiclePlateNum = _view.VehiclePlateNum
            };

            try {
                _service.AddMaintenanceSchedule(newMaintenanceSchedule);
                _view.CloseModal();
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
        }



    }
}
