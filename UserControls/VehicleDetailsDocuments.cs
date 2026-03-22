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
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDetailsDocuments : UserControl, IVehicleDetailsDocumentView {
        private VehicleDto _vehicle;
        private vehicleDetailsDocumentPresenter _presenter;

        private Timer _searchTimer;

        public string SearchInput => searchBox.Text.ToLower();

        public string VehiclePlateNum => _vehicle.LicensePlate;

        public VehicleDetailsDocuments(VehicleDto vehicle) {
            _vehicle = vehicle;
            InitializeComponent();
            _presenter = new vehicleDetailsDocumentPresenter(this, new Services.Implementations.VehicleDocumentServices());
        }

        public void ShowError(string error) {
            MessageBox.Show(error, "Error");
        }

        public void ToggleNoDocumentDisplay(bool IsNotVisible) {
            tableMain.Visible = IsNotVisible;
            tableHeader.Visible = IsNotVisible;
            labelNoDocument.Visible = !IsNotVisible;
        }

        public void DisplayDocuments(List<VehicleDocumentDto> documents) {
            tableMain.SuspendLayout();
            const int DocumentCardHeight = 85;
            const int BottomPadding = 10;
            int TableMainHeight = DocumentCardHeight * documents.Count;

            tableMain.Controls.Clear();
            tableMain.RowStyles.Clear();
            tableMain.RowCount = 0;
            tableMain.Height = TableMainHeight;
            this.Height += (TableMainHeight + BottomPadding);

            int col = 0;
            int row = 0;

            foreach (var document in documents) {
                var card = new VehicleDocumentCardControl();
                card.Bind(document, _presenter.LoadAllDocuments);
                card.Dock = DockStyle.Fill;

                tableMain.Controls.Add(card, col, row);

                row++;
            }

            tableMain.ResumeLayout();
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            using (var addVehicleDocumentForm = new AddNewVehicleDocumentModal(_vehicle.LicensePlate)) {
                DialogResult result = addVehicleDocumentForm.ShowDialog();

                if (result != DialogResult.OK) return;

                _presenter.LoadAllDocuments();
                if(!tableMain.Visible) ToggleNoDocumentDisplay(true); 
            }
        }

        private void VehicleDetailsDocuments_Load(object sender, EventArgs e) {
            _presenter.LoadAllDocuments();
            _searchTimer = new Timer();
            _searchTimer.Interval = 350; // 0.35 seconds
            _searchTimer.Tick += SearchTimer_Tick;
        }

        private void SearchTimer_Tick(object sender, EventArgs e) {
            _searchTimer.Stop(); 
            _presenter.LoadSearchDocument();
        }

    }
}

