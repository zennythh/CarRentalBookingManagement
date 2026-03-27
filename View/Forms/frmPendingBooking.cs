using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using System.IO;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Helpers;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.UserControls;

namespace VehicleManagementSystem.View.Forms
{
    public partial class frmPendingBooking : Form
    {
        private BookingDto originalBooking;
        private PendingInfosDto currentPendingInfo;
        private bool isSyncing = false;
        private BookingServices db = new BookingServices();

        public frmPendingBooking(BookingDto origBooking)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            DisplayBookingDetails(origBooking);
        }

        public void DisplayBookingDetails(BookingDto b)
        {
            if (b == null) return;

            originalBooking = b;
            currentPendingInfo = BookingHelpers.MapToPendingInfo(b);

            // Populate UI
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

            if (!string.IsNullOrEmpty(currentPendingInfo.FullImagePath) && File.Exists(currentPendingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentPendingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.default_car_model;

            RefreshConflictSection();
        }

        #region Validation & Logic extraction

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (currentPendingInfo == null || originalBooking == null) return;

            // 1. FINAL DATE VALIDATION
            if (!IsDatePeriodValid(out string error))
            {
                MessageBox.Show($"🛑 Invalid Dates: {error}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. SYNC UI TO PENDING OBJECT (Capturing manual edits from textboxes)
            currentPendingInfo.FirstName = firstNameTextBox.Text;
            currentPendingInfo.LastName = lastNameTextBox.Text;
            currentPendingInfo.LicenseNumber = customerLicenseTextBox.Text;
            currentPendingInfo.Email = customerEmailTextBox.Text;
            currentPendingInfo.PhoneNumber = customerContactNumTextBox.Text;
            currentPendingInfo.DateSchedOut = rentalDateStartDTP.Value;
            currentPendingInfo.DateDue = rentalDateEndDTP.Value;

            // 3. TRACK CHANGES (To show user what they edited)
            List<string> changes = GetChangeLogs();

            // 4. FETCH AND CLASSIFY CONFLICTS
            var conflicts = BookingServices.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            var (hardDirect, bufferOverlaps, pendingConflicts) = ClassifyConflicts(currentPendingInfo, conflicts);

            // --- EXECUTE HARD BLOCK ---
            if (hardDirect.Any())
            {
                MessageBox.Show("🛑 CANNOT APPROVE: This vehicle is already 'Reserved' or 'Out' during this exact timeframe. Resolve the existing active booking first.",
                                "Hard Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 5. BUILD THE ALERT MESSAGE
            string alertMessage = "Are you sure you want to approve this booking?";
            if (changes.Count > 0)
                alertMessage = "CONFIRM UPDATES:\n" + string.Join("\n", changes) + "\n\n" + alertMessage;

            // Add Buffer/Pending warnings
            string warnings = "";
            if (pendingConflicts.Count > 0)
                warnings += $"⚠️ WARNING: This will automatically REJECT {pendingConflicts.Count} other PENDING request(s).\n";
            if (bufferOverlaps.Any())
                warnings += "⏳ BUFFER NOTICE: This cuts into the 3-hour cleanup window of an existing reservation.\n";

            if (!string.IsNullOrEmpty(warnings))
                alertMessage = warnings + "\n" + alertMessage;

            // 6. FINAL DATABASE EXECUTION
            if (MessageBox.Show(alertMessage, "Final Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var dbResult = db.ProcessApproval(currentPendingInfo);
                if (dbResult.success)
                {
                    MessageBox.Show(dbResult.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    backBtn_Click(null, null); // Go back to list
                }
                else
                {
                    MessageBox.Show(dbResult.message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            if (currentPendingInfo == null) return;

            string msg = $"Are you sure you want to REJECT the booking for {currentPendingInfo.FirstName} {currentPendingInfo.LastName}?\n\nThis action cannot be undone.";
            if (MessageBox.Show(msg, "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var dbResult = db.ProcessRejection(currentPendingInfo.BookingID);
                if (dbResult.success)
                {
                    MessageBox.Show(dbResult.message, "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    backBtn_Click(null, null);
                }
                else
                {
                    MessageBox.Show(dbResult.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<string> GetChangeLogs()
        {
            List<string> changes = new List<string>();
            if (currentPendingInfo.FirstName != originalBooking.FirstName)
                changes.Add($"• Name: {originalBooking.FirstName} → {currentPendingInfo.FirstName}");

            if (currentPendingInfo.LastName != originalBooking.LastName)
                changes.Add($"• Last Name: {originalBooking.LastName} → {currentPendingInfo.LastName}");

            if (currentPendingInfo.LicenseNumber != originalBooking.LicenseNumber)
                changes.Add($"• License: {originalBooking.LicenseNumber} → {currentPendingInfo.LicenseNumber}");

            if (currentPendingInfo.Email != originalBooking.Email)
                changes.Add($"• Email: {originalBooking.Email} → {currentPendingInfo.Email}");

            if (currentPendingInfo.PhoneNumber != originalBooking.PhoneNumber)
                changes.Add($"• Contact: {originalBooking.PhoneNumber} → {currentPendingInfo.PhoneNumber}");

            if (currentPendingInfo.DateSchedOut != originalBooking.DateSchedOut)
                changes.Add($"• Start: {originalBooking.DateSchedOut:MMM dd, hh:mm tt} → {currentPendingInfo.DateSchedOut:MMM dd, hh:mm tt}");

            if (currentPendingInfo.DateDue != originalBooking.DateDue)
                changes.Add($"• Return: {originalBooking.DateDue:MMM dd, hh:mm tt} → {currentPendingInfo.DateDue:MMM dd, hh:mm tt}");
            return changes;
        }

        private (List<BookingDto> HardDirect, List<BookingDto> BufferOverlaps, List<BookingDto> Pending) ClassifyConflicts(PendingInfosDto pending, List<BookingDto> conflicts)
        {
            // Statuses that are already "locked in" the calendar
            var activeStatuses = new[] { "Reserved", "Out", "Approved" };

            var hardDirect = conflicts.Where(c => activeStatuses.Contains(c.Status) && pending.DateSchedOut < c.DateDue).ToList();

            // 3-hour buffer check (if pickup is within 3 hours after another booking's return)
            var bufferOverlaps = conflicts.Where(c => pending.DateSchedOut >= c.DateDue && pending.DateSchedOut <= c.DateDue.AddHours(3)).ToList();

            var pendingList = conflicts.Where(c => c.Status == "Pending").ToList();

            return (hardDirect, bufferOverlaps, pendingList);
        }

        #endregion

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
            finally { isSyncing = false; }
        }

        private void RefreshConflictSection()
        {
            if (currentPendingInfo == null) return;

            // 1. Validation Check
            if (!IsDatePeriodValid(out _))
            {
                lblRentalTimeValue.Text = "Invalid Data";
                lblRentalTimeValue.ForeColor = Color.Red;
                lblPriceValue.Text = "₱0.00";
                conflictFlowPanel.Controls.Clear();
                lblBookingConflicts.Visible = false;
                return;
            }

            // 2. Update UI Labels
            lblRentalTimeValue.ForeColor = Color.Black;
            decimal newPrice = CalculateProjectedPrice(rentalDateStartDTP.Value, rentalDateEndDTP.Value, currentPendingInfo.DailyRate);
            lblPriceValue.Text = "₱" + newPrice.ToString("N2");
            currentPendingInfo.ProjectedPrice = newPrice;
            lblRentalTimeValue.Text = BookingHelpers.GetRentalDuration(rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            // 3. Clear existing controls to start fresh
            conflictFlowPanel.Controls.Clear();

            // 4. Fetch Conflicts
            var conflicts = BookingServices.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            if (conflicts != null && conflicts.Count > 0)
            {
                // CONFLICTS EXIST
                lblBookingConflicts.Visible = true;
                lblNoBookingConflicts.Visible = false; // Explicitly hide the "No Conflict" label

                foreach (var conflict in conflicts)
                {
                    ucBookingCard miniCard = new ucBookingCard();
                    miniCard.BindData(conflict);
                    // Ensure the card itself doesn't have huge margins that push things out of view
                    conflictFlowPanel.Controls.Add(miniCard);
                }
            }
            else
            {
                // NO CONFLICTS
                lblBookingConflicts.Visible = false;

                // Add the label back to the cleared panel and show it
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