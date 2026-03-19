using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Data.Enums;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    internal class addNewVehicleDocumentPresenter {
        IAddNewVehicleDocumentView _view;
        VehicleDocumentServices _vehicleDocumentServices;

        public addNewVehicleDocumentPresenter(IAddNewVehicleDocumentView view, VehicleDocumentServices vehicleDocumentServices) {
            _view = view;
            _vehicleDocumentServices = vehicleDocumentServices;
        }

        public void SaveDocument() {
            if (!IsAllInputsValid(_view))
                return;

            try {
                VehicleDocumentDto newDocument = new VehicleDocumentDto {
                    Title = VehicleManagementSystem.Classes.Helpers.ConvertToCapitalized(_view.DocumentTitle),
                    Category = _view.DocumentType,
                    IssuingAuthority = VehicleManagementSystem.Classes.Helpers.ConvertToCapitalized(_view.DocumentIssuingAuthority),

                    IssueDate = DateTime.Parse(_view.DocumentIssueDate),
                    VehiclePlateNum = _view.VehiclePlateNum,

                    ExpirationDate = string.IsNullOrEmpty(_view.DocumentExpirationDate)
                                     ? (DateTime?)null
                                     : DateTime.Parse(_view.DocumentExpirationDate),

                    FilePath = GetFinalVehicDocumentPath(_view.DocumentPath, _view.VehiclePlateNum),
                    Extension = Path.GetExtension(_view.DocumentPath).ToLower()
                };

                _vehicleDocumentServices.AddVehicleDocument(newDocument);

                _view.ShowSuccess($"Document '{newDocument.Title}' for Plate {_view.VehiclePlateNum} has been added.");
                _view.CloseModal();
            } catch (Exception ex) {
                _view.ShowError($"Failed to save document: {ex.Message}");
            }
        }

        private string GetFinalVehicDocumentPath(string docPath, string plateNum) {
            string subFolderImagePath = Path.Combine(AppConfig.AppData.VehicleImagePath, plateNum);
            string fileName = _view.DocumentType+"-"+_view.DocumentTitle+Path.GetExtension(docPath);
            return VehicleManagementSystem.Classes.Helpers.SaveDocumentToAppData(docPath, subFolderImagePath, fileName);
        }

        private bool IsAllInputsValid(IAddNewVehicleDocumentView inputs) {
            bool hadNoError = true;

            if (string.IsNullOrWhiteSpace(inputs.DocumentTitle)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.DocumentPath)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.DocumentIssuingAuthority)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrEmpty(inputs.DocumentType)) {
                hadNoError = false;
            }

            return hadNoError;
        }
    }
}
