using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    internal class addNewVehicleMaintenanceTypePresenter {
        IAddNewVehicleMaintenanceTypeView _view;
        VehicleMaintenanceServices _vehicleMaintenanceServices;

        public addNewVehicleMaintenanceTypePresenter(IAddNewVehicleMaintenanceTypeView view, VehicleMaintenanceServices service) {
            _vehicleMaintenanceServices = service;
            _view = view;
        }

        public void SaveMaintenanceType() {
            if (!IsAllInputsValid(_view)) return;

            if (_view.DefaultMileageInterval <= 0 && _view.DefaultMonthInterval <= 0) {
                MessageBox.Show("Please enter a valid mileage or month interval.", "Input Error");
                return;
            }

            try {
                var newTask = new Dto.VehicleMaintenanceTypeDto {
                    TaskName = _view.TaskName,
                    Description = _view.Description,
                    DefaultMileageInterval = _view.DefaultMileageInterval, // This is now int?
                    DefaultMonthInterval = _view.DefaultMonthInterval     // This is now int?
                };

                _vehicleMaintenanceServices.AddMaintenanceTaskDefinition(newTask);

                _view.ShowSuccess("Maintenance type successfully created!");

                _view.CloseModal();
            } catch (Exception ex) {
                _view.ShowError($"Failed to save document: {ex.Message}");
            }
        }

        private bool IsAllInputsValid(IAddNewVehicleMaintenanceTypeView inputs) {
            bool hadNoError = true;

            if (string.IsNullOrWhiteSpace(inputs.TaskName)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.Description)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            return hadNoError;
        }

    }
}
