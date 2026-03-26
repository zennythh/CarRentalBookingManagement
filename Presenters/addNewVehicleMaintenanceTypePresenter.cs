using System;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;
using System.Windows.Forms;

namespace VehicleManagementSystem.Presenters {
    internal class addNewVehicleMaintenanceTypePresenter {
        IAddNewVehicleMaintenanceTypeView _view;
        VehicleMaintenanceServices _vehicleMaintenanceServices;

        public addNewVehicleMaintenanceTypePresenter(IAddNewVehicleMaintenanceTypeView view, VehicleMaintenanceServices service) {
            _vehicleMaintenanceServices = service;
            _view = view;
        }

        public async void SaveMaintenanceType() {
            if (!IsAllInputsValid(_view)) return;

            if (_view.SuggestedMileageInterval <= 0 && _view.SuggestedMonthInterval <= 0) {
                _view.ShowError("Please enter a valid mileage or month interval.");
                return;
            }

            try {
                var newTask = new Dto.VehicleMaintenanceTypeDto {
                    MaintenanceName = _view.MaintenanceName,
                    Priority = _view.Priority,
                    Description = _view.Description,
                    SuggestedMileageInterval = _view.SuggestedMileageInterval,
                    SuggestedMonthInterval = _view.SuggestedMonthInterval
                };

                await _vehicleMaintenanceServices.AddNewMaintenanceType(newTask);

                _view.ShowSuccess("Maintenance type successfully created!");

                _view.CloseModal();
            } catch (Exception ex) {
                _view.ShowError($"Failed to save document: {ex.Message}");
            }
        }

        private bool IsAllInputsValid(IAddNewVehicleMaintenanceTypeView inputs) {
            bool hadNoError = true;

            if (string.IsNullOrWhiteSpace(inputs.MaintenanceName)) {
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
