using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Interfaces {
    public interface IVehicleManagementView {
        string SearchQuery { get; }
        void SetLoadingState(bool isLoading);
        void DisplayVehicles(List<VehicleDto> vehicles);
        void ShowError(string message);
    }
}
