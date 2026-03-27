using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Helpers;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.UserControls;

namespace VehicleManagementSystem.View.Forms
{
    public partial class frmPendingBooking : Form
    {
        public frmPendingBooking(BookingDto origBooking)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            DisplayBookingDetails(origBooking);
        }

        private BookingDto originalBooking;
        private PendingInfosDto currentPendingInfo;
        private bool isSyncing = false;

        public void DisplayBookingDetails(BookingDto b)
        {
            if (b == null) return;

            originalBooking = b;
            currentPendingInfo = BookingHelpers.MapToPendingInfo(b);

            lblBookingIDValue.Text = currentPendingInfo.BookingID.ToString();
            firstNameTextBox.Text = currentPendingInfo.FirstName;
            lastNameTextBox.Text = currentPendingInfo.LastName;
            customerLicenseTextBox.Text = currentPendingInfo.LicenseNumber;
            customerEmailTextBox.Text = currentPendingInfo.Email;
            customerContactNumTextBox.Text = currentPendingInfo.PhoneNumber;
            lblDateofRequestValue.Text = BookingHelpers.GetFormattedDate(currentPendingInfo.DateSubmitted);
            vehicleLicenseTextBox.Text = currentPendingInfo.LicensePlate;
            vehicleNameTextBox.Text = currentPendingInfo.VehicleName;

            isSyncing = true;
            rentalDateStartDTP.Value = currentPendingInfo.DateSchedOut;
            rentalDateEndDTP.Value = currentPendingInfo.DateDue;
            lblPriceValue.Text = "₱" + currentPendingInfo.ProjectedPrice.ToString("N2");
            isSyncing = false;

            lblRentalTimeValue.Text = BookingHelpers.GetRentalDuration(currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            if (!string.IsNullOrEmpty(currentPendingInfo.FullImagePath) && System.IO.File.Exists(currentPendingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentPendingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.default_car_model;
        }

        public void rentalDate_ValueChanged(object sender, EventArgs e)
        {
            if (currentPendingInfo == null || isSyncing) return;

            try
            {
                isSyncing = true;
                currentPendingInfo.DateSchedOut = rentalDateStartDTP.Value;
                currentPendingInfo.DateDue = rentalDateEndDTP.Value;

                RefreshConflictSection();
            }
            finally
            {
                isSyncing = false; // This ALWAYS runs, even if RefreshConflictSection crashes
            }
        }

        private void RefreshConflictSection()
        {
            if (currentPendingInfo == null) return;

            if (!IsDatePeriodValid(out _))
            {
                lblRentalTimeValue.Text = "Invalid Data";
                lblRentalTimeValue.ForeColor = Color.Red;
                lblPriceValue.Text = "₱0.00";
                conflictFlowPanel.Controls.Clear();
                lblBookingConflicts.Visible = false;
                return;
            }

            lblRentalTimeValue.ForeColor = Color.Black;
            decimal newPrice = CalculateProjectedPrice(rentalDateStartDTP.Value, rentalDateEndDTP.Value, currentPendingInfo.DailyRate);
            lblPriceValue.Text = "₱" + newPrice.ToString("N2");
            currentPendingInfo.ProjectedPrice = newPrice;
            lblRentalTimeValue.Text = BookingHelpers.GetRentalDuration(rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            conflictFlowPanel.Controls.Clear();
            var conflicts = BookingServices.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            if (conflicts.Count > 0)
            {
                lblBookingConflicts.Visible = true;
                foreach (var conflict in conflicts)
                {
                    ucBookingCard miniCard = new ucBookingCard();
                    miniCard.BindData(conflict);
                    conflictFlowPanel.Controls.Add(miniCard);
                }
            }
            else
            {
                lblBookingConflicts.Visible = false;
                if (!conflictFlowPanel.Controls.Contains(lblNoBookingConflicts))
                    conflictFlowPanel.Controls.Add(lblNoBookingConflicts);
                lblNoBookingConflicts.Visible = true;
            }
        }

        private bool IsDatePeriodValid(out string errorMessage)
        {
            errorMessage = string.Empty;
            if (rentalDateEndDTP.Value <= rentalDateStartDTP.Value)
            {
                errorMessage = "Return date must be after the pickup date.";
                return false;
            }
            return true;
        }

        private decimal CalculateProjectedPrice(DateTime start, DateTime end, decimal dailyRate)
        {
            TimeSpan duration = end - start;
            if (duration.TotalSeconds <= 0) return 0;
            int totalDays = (int)Math.Ceiling(duration.TotalHours / 24.0);
            return totalDays * dailyRate;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(new frmBookings());
        }
    }
}
