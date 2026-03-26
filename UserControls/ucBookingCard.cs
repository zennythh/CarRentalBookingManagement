using Org.BouncyCastle.Asn1.Cmp;
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

namespace VehicleManagementSystem.UserControls {
    public partial class ucBookingCard : UserControl {
        public string BookingID { get; private set; }

        public ucBookingCard() {
            InitializeComponent();
        }

        // Pass the DTO to populate the card
        public void BindData(BookingDto booking) {
            BookingID = booking.BookingID; // This is now your custom string ID

            lblBookingID.Text = $"ID: {booking.BookingID}";
            lblCustomerName.Text = $"{booking.FirstName} {booking.LastName}";
            //lblVehicleInfo.Text = $"Vehicle VIN: {booking.VehicleVIN}";
            lblPrice.Text = $"Total: {booking.TotalPrice:C2}";

            lblDates.Text = $"{booking.DateSchedOut:MMM dd} - {booking.DateDue:MMM dd, yyyy}";

            UpdateStatusUI(booking.Status);
        }

        private void UpdateStatusUI(string status) {
            lblStatus.Text = status.ToUpper();

            // Modern palette for white theme
            switch (status.ToLower()) {
                case "completed":
                    sideStatusPanel.FillColor = Color.FromArgb(46, 204, 113); // Emerald Green
                    lblStatus.ForeColor = Color.FromArgb(46, 204, 113);
                    break;
                case "pending":
                    sideStatusPanel.FillColor = Color.FromArgb(241, 196, 15); // Sun Flower Yellow
                    lblStatus.ForeColor = Color.FromArgb(180, 140, 0); // Darker text for readability
                    break;
                case "cancelled":
                    sideStatusPanel.FillColor = Color.FromArgb(231, 76, 60); // Alizarin Red
                    lblStatus.ForeColor = Color.FromArgb(231, 76, 60);
                    break;
                default:
                    sideStatusPanel.FillColor = Color.Gainsboro;
                    lblStatus.ForeColor = Color.Gray;
                    break;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e) {
            // Code to open the full edit/view form for this BookingID
        }
    }
}
