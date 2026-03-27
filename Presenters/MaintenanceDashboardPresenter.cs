using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.Services.Implementations;
using System.Windows.Navigation;

namespace VehicleManagementSystem.Presenters {
    internal class MaintenanceDashboardPresenter {
        IMaintenanceDashboardView _view;
        VehicleMaintenanceServices _services;

        public MaintenanceDashboardPresenter(IMaintenanceDashboardView view, VehicleMaintenanceServices services) {
            _view = view;
            _services = services;   
        }

        public async void LoadDashbord() {
            try {
                var maintenances = await _services.GetAllMaintenanceSchedules();
                _view.DisplayDashboard(maintenances);
            } catch (Exception ex) {

            } 
        }

        public async void LoadUrgents() {
            try {
                var maintenances = await _services.GetAllMaintenanceSchedules();

                var mostUrgent = maintenances
                    .Where(s => s.Status == "Scheduled" && s.IsOverdue)
                    .OrderByDescending(s => s.DaysUntilDue ?? int.MaxValue)
                    .ThenBy(s => s.MilesUntilDue ?? decimal.MaxValue) 
                    .Take(8) 
                    .ToList();
                _view.DisplayUrgents(mostUrgent);
            } catch (Exception ex) {

            }
        }

        public async void LoadUpcoming() {
            try {
                var maintenances = await _services.GetAllMaintenanceSchedules();

                var mostUrgent = maintenances
                    .Where(s => s.Status == "Scheduled" && s.IsDueSoon && s.DaysUntilDue <= 7)
                    .OrderByDescending(s => s.DaysUntilDue ?? int.MaxValue)
                    .ThenBy(s => s.MilesUntilDue ?? decimal.MaxValue)
                    .Take(8)
                    .ToList();
                _view.DisplayUpcoming(mostUrgent);
            } catch (Exception ex) {

            }
        }


    }
}
