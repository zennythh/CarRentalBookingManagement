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
            // Validate schedule type is selected
            if (string.IsNullOrWhiteSpace(_view.ScheduleType)) {
                _view.ShowError("Please select a schedule type (Recurring or One-Time).");
                return;
            }

            try {
                VehicleMaintenanceScheduleDto newMaintenanceSchedule;

                if (_view.ScheduleType == "Recurring") {
                    // Validate recurring schedule fields
                    if (!ValidateRecurringSchedule()) {
                        return;
                    }

                    // Create DTO with only recurring fields
                    newMaintenanceSchedule = new VehicleMaintenanceScheduleDto {
                        VehiclePlateNum = _view.VehiclePlateNum,
                        MaintenanceTypeID = _view.MaintenanceTypeID,
                        ScheduleType = "Recurring",
                        Status = "Scheduled",

                        // Recurring-specific fields
                        MileageInterval = _view.MileageInterval,
                        MonthInterval = _view.MonthInterval,
                        LastServiceDate = _view.LastServiceDate,
                        LastServiceMileage = _view.VehicleCurrentOdometer,

                        // Explicitly set one-time fields to null
                        DueDate = null,
                        DueMileage = null,
                    };
                } else if (_view.ScheduleType == "OneTime") {
                    // Validate one-time schedule fields
                    if (!ValidateOneTimeSchedule()) {
                        return;
                    }

                    // Create DTO with only one-time fields
                    newMaintenanceSchedule = new VehicleMaintenanceScheduleDto {
                        VehiclePlateNum = _view.VehiclePlateNum,
                        MaintenanceTypeID = _view.MaintenanceTypeID,
                        ScheduleType = "OneTime",
                        Status = "Scheduled",
                        // One-time specific fields
                        DueDate = _view.DueDate,
                        DueMileage = _view.DueMileage,

                        // Explicitly set recurring fields to null
                        MileageInterval = null,
                        MonthInterval = null,
                        LastServiceDate = null,
                        LastServiceMileage = null,
                    };
                } else {
                    _view.ShowError($"Invalid schedule type: {_view.ScheduleType}");
                    return;
                }

                // Save to database
                _service.AddMaintenanceSchedule(newMaintenanceSchedule);

                _view.ShowSuccess("Maintenance schedule created successfully!");
                _view.CloseModal();
            } catch (Exception ex) {
                _view.ShowError($"Error saving maintenance schedule: {ex.Message}");
            }
        }

        private bool ValidateRecurringSchedule() {
            // Must have at least one interval set
            if (!_view.MileageInterval.HasValue && !_view.MonthInterval.HasValue) {
                _view.ShowError("For recurring maintenance, you must specify either a mileage interval or month interval (or both).");
                return false;
            }

            // Validate intervals are positive
            if (_view.MileageInterval.HasValue && _view.MileageInterval.Value <= 0) {
                _view.ShowError("Mileage interval must be greater than zero.");
                return false;
            }

            if (_view.MonthInterval.HasValue && _view.MonthInterval.Value <= 0) {
                _view.ShowError("Month interval must be greater than zero.");
                return false;
            }

            return true;
        }

        private bool ValidateOneTimeSchedule() {
            // Must have at least one due condition
            if (!_view.DueDate.HasValue && !_view.DueMileage.HasValue) {
                _view.ShowError("For one-time maintenance, you must specify either a due date or due mileage (or both).");
                return false;
            }

            // Validate due date is in the future
            if (_view.DueDate.HasValue && _view.DueDate.Value < DateTime.Today) {
                _view.ShowError("Due date cannot be in the past.");
                return false;
            }

            // Validate due mileage is reasonable
            if (_view.DueMileage.HasValue && _view.DueMileage.Value <= 0) {
                _view.ShowError("Due mileage must be greater than zero.");
                return false;
            }

            return true;
        }

    }
}
