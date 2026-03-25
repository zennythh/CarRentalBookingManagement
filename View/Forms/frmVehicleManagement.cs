using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Forms {
    public partial class frmVehicleManagement : Form, IVehicleManagementView {

        private vehicleManagementPresenter _presenter;
        private Timer _searchTimer;
        private ucLoadingOverlay _loader = new ucLoadingOverlay();

        public string SearchQuery => searchBox.Text;

        private void InitializeColoredStatus() {
            Color labelAvailableColor = VehicleManagementSystem.Classes.Helpers.GetStatusColor("Available");
            Color labelInMaintenanceColor = VehicleManagementSystem.Classes.Helpers.GetStatusColor("InMaintenance");
            Color labelOutOfServiceColor = VehicleManagementSystem.Classes.Helpers.GetStatusColor("OutOfService");
            Color labelRentedColor = VehicleManagementSystem.Classes.Helpers.GetStatusColor("Rented");

            //labelAvailableIcon.FillColor = labelAvailableColor;
            //labelAvailableText.ForeColor = labelAvailableColor;

            //labelRentedIcon.FillColor = labelRentedColor;
            //labelRentedText.ForeColor = labelRentedColor;

            //labelOutOfServiceIcon.FillColor = labelOutOfServiceColor;
            //labelOutOfServiceText.ForeColor = labelOutOfServiceColor;

            //labelInMaintenanceIcon.FillColor = labelInMaintenanceColor;
            //labelInMaintenanceText.ForeColor = labelInMaintenanceColor;
        }

        public frmVehicleManagement() {
            InitializeComponent();
            //InitializeColoredStatus();
            _presenter = new vehicleManagementPresenter(this, new VehicleServices());
        }

        public void SetLoadingState(bool isLoading) {
            if (isLoading) {
                _loader.ShowLoading(panelMain);
            } else {
                _loader.HideLoading();
            }
        }

        public void DisplayVehicles(List<VehicleDto> vehicles) {
            tableLayoutVehicles.SuspendLayout();

            tableLayoutVehicles.Controls.Clear();
            tableLayoutVehicles.RowStyles.Clear();
            tableLayoutVehicles.RowCount = 0;

            int col = 0;
            int row = 0;
            int maxCols = 3;

            foreach (var vehicle in vehicles) {
                if (col == 0) {
                    tableLayoutVehicles.RowCount++;
                    tableLayoutVehicles.RowStyles.Add(
                        new RowStyle(SizeType.AutoSize)
                    );
                }

                var card = new VehicleCardControl();
                card.Bind(vehicle);
                card.Dock = DockStyle.Fill;
                card.Margin = new Padding(10);

                tableLayoutVehicles.Controls.Add(card, col, row);

                col++;
                if (col >= maxCols) {
                    col = 0;
                    row++;
                }
            }

            tableLayoutVehicles.ResumeLayout();
        }

        public void ShowError(string message) {
            MessageBox.Show(message, "Error");
        }

        private void frmVehicleManagement_Load(object sender, EventArgs e) {
            _presenter.LoadAllVehicles();
            _searchTimer = new Timer();
            _searchTimer.Interval = 350; // 0.35 seconds
            _searchTimer.Tick += SearchTimer_Tick;
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {
            _searchTimer.Stop();   
            _searchTimer.Start(); 
        }

        private void SearchTimer_Tick(object sender, EventArgs e) {
            _searchTimer.Stop(); // IMPORTANT: run only once
            _presenter.LoadSearchedVehicle();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            NavigationHelper.OpenForm(new frmAddNewVehicle());
            frmMain.Instance.AddHeaderLabel(AppConfig.SubTitles.AddNewVehicle);
        }

        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
