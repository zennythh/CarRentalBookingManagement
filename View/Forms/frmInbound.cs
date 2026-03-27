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
using VehicleManagementSystem.Services;
using VehicleManagementSystem.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleManagementSystem.View.Forms
{
    public partial class frmInbound : Form
    {
        private ucLoadingOverlay _loader;
        private BookingServices _db;
        public frmInbound()
        {
            InitializeComponent();
            InitializeFirstLoad();
        }

        private void InitializeFirstLoad()
        {
            _db = new BookingServices();
            _loader = new ucLoadingOverlay();
            DisplayApprovedBookings();
        }

        private async void DisplayApprovedBookings()
        {
            bookingListPanel.Controls.Clear();
            _loader.ShowLoading(panelLoading);
            panelLoading.BringToFront();
            try
            {
                var bookings = await _db.GetBookingsByStatus("Out");
                LoadBookingCards(bookings);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong.");
            }
            finally
            {
                bookingListPanel.BringToFront();
                _loader.HideLoading();
            }
        }

        private void LoadBookingCards(List<BookingDto> bookings)
        {
            bookingListPanel.Padding = new Padding(0);


            foreach (var booking in bookings)
            {
                var card = new ucBookingCard();
                card.BindData(booking);
                card.Margin = new Padding(4);
                card.ChangeBtnViewText("Finalize");
                bookingListPanel.Controls.Add(card);
            }

            LayoutFlowLayoutPanel();
        }

        private void LayoutFlowLayoutPanel()
        {
            const int BOTTOM_PADDING = 10;

            if (bookingListPanel.Controls.Count > 0)
            {
                var firstCard = bookingListPanel.Controls[0];

                int cardWidthWithMargin = firstCard.Width + firstCard.Margin.Left + firstCard.Margin.Right;
                int cardHeightWithMargin = firstCard.Height + firstCard.Margin.Top + firstCard.Margin.Bottom;

                int itemsPerRow = bookingListPanel.ClientSize.Width / cardWidthWithMargin;
                if (itemsPerRow <= 0) itemsPerRow = 1;
                
                int totalRows = (int)Math.Ceiling((double)bookingListPanel.Controls.Count / itemsPerRow);

                int flowLayoutHeight = totalRows * cardHeightWithMargin;

                bookingListPanel.Height = flowLayoutHeight + bookingListPanel.Padding.Top + BOTTOM_PADDING;
            }
        }
    }

}