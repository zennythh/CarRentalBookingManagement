using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDetailsDocuments : UserControl {
        private VehicleDto _vehicle;
        public VehicleDetailsDocuments(VehicleDto vehicle) {
            _vehicle = vehicle;
            InitializeComponent();
        }

        public void DisplayVehicles(List<VehicleDocumentDto> documents) {
            tableMain.SuspendLayout();
            const int DocumentCardHeight = 84;

            tableMain.Controls.Clear();
            tableMain.RowStyles.Clear();
            tableMain.RowCount = 0;
            tableMain.Height = DocumentCardHeight * documents.Count;

            int col = 0;
            int row = 0;

            foreach (var document in documents) {
                var card = new VehicleDocumentCardControl();
                card.Bind(document);
                card.Dock = DockStyle.Fill;
                //card.Margin = new Padding(10);

                tableMain.Controls.Add(card, col, row);

                row++;
            }

            tableMain.ResumeLayout();
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {

        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            var addVehicleDocumentForm = new AddNewVehicleDocumentModal(_vehicle.LicensePlate);
            addVehicleDocumentForm.ShowDialog();
        }
    }
}
