using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Interfaces {
    public interface IVehicleDetailsDocumentView {
        string VehiclePlateNum { get; }

        string SearchInput { get; }

        void ToggleNoDocumentDisplay(bool IsNotVisible);
        void DisplayDocuments(List<VehicleDocumentDto> documents);
        void ShowError(string error);
    }
}
