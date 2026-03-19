using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.View.Interfaces {
    internal interface IAddNewVehicleDocumentView {
        string DocumentType { get; }
        string DocumentTitle { get; }
        string VehiclePlateNum { get; }
        string DocumentIssuingAuthority { get; }

        string DocumentExpirationDate { get; }
        string DocumentIssueDate { get; }

        string DocumentPath { get; }

        void ShowError(string error);
    }
}
