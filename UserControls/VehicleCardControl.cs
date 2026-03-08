using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.View.Forms;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleCardControl : UserControl {
        VehicleDto _vehicle;

        public VehicleCardControl() {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        public void Bind(VehicleDto vehicle) {
            _vehicle = vehicle;

            pictureVehicle.Image = VehicleManagementSystem.Classes.Helpers.GetVehicleImage(vehicle.ImagePath);
            labelMainHeader.Text = vehicle.LicensePlate;
            labelSubHader.Text = GetCardSubHeader(vehicle);
            labelDailyRate.Text = GetFormattedDialyRate(vehicle.DailyRate);
            labelCurrentOdometer.Text = vehicle.CurrentOdometerReading + " Km";
            pictureBoxTransmission.Image = GetTransmissionIcon(vehicle.Transmission);

            labelStatus.Text = vehicle.CurrentStatus;
            labelStatus.ForeColor = VehicleManagementSystem.Classes.Helpers.GetStatusColor(vehicle.CurrentStatus);

        }

        private Image GetTransmissionIcon(string transmissionType) {
            if(transmissionType.ToLower() == "automatic")
                return global::VehicleManagementSystem.Properties.Resources.auto_transmission_icon;

            return global::VehicleManagementSystem.Properties.Resources.manual_transmission_icon;
        }

        private string GetCardSubHeader(VehicleDto vehicle) {
            return $"{vehicle.Manufacturer} - {vehicle.Model} {vehicle.YearModel}";
        }

        private string GetFormattedDialyRate(decimal dailyRate) {
            return $"₱{dailyRate}/day";
        }

        private void Card_Click(object sender, EventArgs e) {
            string headerLabe = "Details > " + _vehicle.LicensePlate;

            NavigationHelper.OpenForm(new frmVehicleDetails(_vehicle));
            frmMain.Instance.AddHeaderLabel(headerLabe);
        }
    }
}
