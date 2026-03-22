using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters { 
    public class vehicleDetailsDocumentPresenter {
        IVehicleDetailsDocumentView _view;
        VehicleDocumentServices _services;
        private VehicleDetailsDocuments vehicleDetailsDocuments;
        private VehicleDocumentServices vehicleDocumentServices;

        public vehicleDetailsDocumentPresenter(IVehicleDetailsDocumentView view, VehicleDocumentServices services) {
            _view = view;
            _services = services;
        }

        public void LoadAllDocuments() {
            try {
                var documents = _services.GetDocumentsByPlateNumber(_view.VehiclePlateNum);
                if (documents.Count > 0) {
                    _view.ToggleNoDocumentDisplay(true);
                    _view.DisplayDocuments(documents);
                } else {
                    _view.ToggleNoDocumentDisplay(false);
                }
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
        }


        public void LoadSearchDocument() {
            if (string.IsNullOrWhiteSpace(_view.SearchInput)) {
                _view.ToggleNoDocumentDisplay(true);
                LoadAllDocuments();
                return;
            }

            try {
                var documents = _services.GetSearchedVehicleDocument(_view.SearchInput, _view.VehiclePlateNum);
                if (documents.Count > 0) {
                    _view.ToggleNoDocumentDisplay(true);
                    _view.DisplayDocuments(documents);
                } else {
                    _view.ToggleNoDocumentDisplay(false);
                }
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
        }

    }
}
