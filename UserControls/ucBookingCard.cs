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
            this.Cursor = Cursors.Hand;
        }

        public void BindData(BookingDto booking) {
            BookingID = booking.BookingID; 

            lblBookingID.Text = $"ID: {booking.BookingID}";
            lblCustomerName.Text = $"{booking.FirstName} {booking.LastName}";
            lblVehicle.Text = booking.VehicleName;

            if (booking.Status != "Completed"){
                lblPrice.Text = $"Total: {booking.ProjectedPrice:C2}";
            } else if (booking.Status == "Completed"){
                lblPrice.Text = $"Total: {booking.ProjectedPrice:C2}";
            } else { 
                lblPrice.Text = "Something went wrong";
            }

            lblDates.Text = $"{booking.DateSchedOut:MMM dd hh:mm tt} - {booking.DateDue:MMM dd, yyyy hh:mm tt}";

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
                    lblStatus.ForeColor = Color.FromArgb(180, 140, 0); 
                    break;
                case "rejected":
                    sideStatusPanel.FillColor = Color.FromArgb(231, 76, 60); // Alizarin Red
                    lblStatus.ForeColor = Color.FromArgb(231, 76, 60);
                    break;
                case "approved":
                    sideStatusPanel.FillColor = Color.FromArgb(52, 152, 219); // Peter River Blue
                    lblStatus.ForeColor = Color.FromArgb(52, 152, 219);
                    break;
                case "out":
                    sideStatusPanel.FillColor = Color.FromArgb(155, 89, 182); // Amethyst Purple
                    lblStatus.ForeColor = Color.FromArgb(155, 89, 182);
                    break;
                default:
                    sideStatusPanel.FillColor = Color.Gainsboro;
                    lblStatus.ForeColor = Color.Gray;
                    break;
            }
        }

        public void ChangeBtnViewText(string newText)
        {
            btnView.Text = newText;
        }

        private void btnViewDetails_Click(object sender, EventArgs e) {
            // Code to open the full edit/view form for this BookingID
        }
    }
}
