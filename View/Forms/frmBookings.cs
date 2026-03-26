using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using VehicleManagementSystem.classes;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.UserControls;

namespace VehicleManagementSystem.View.Forms {
    public partial class frmBookings : Form {
        private Guna2Button ActiveButton;
        private UserControl ActiveUserControl;
        private ucLoadingOverlay _loader;
        private Guna2Panel LowerPanel;
        private BookingHandler _db;

        public frmBookings() {
            InitializeComponent();
            InitializeFirstLoad();
        }

        private async void InitializeFirstLoad() {
            hr.FillColor = AppConfig.Theme.Primary;
            this.Resize += (s, e) => LayoutFlowLayoutPanel();
            _db = new BookingHandler();
            _loader = new ucLoadingOverlay();

            ActiveButton = pendingBtn;
            HandleStatusButtonClick(pendingBtn, "Pending");
        }

        private void LoadBookingCards(List<BookingDto> bookings) {
            flowLayoutPanel1.Padding = new Padding(0);


            foreach (var booking in bookings) {
                var card = new ucBookingCard();
                card.BindData(booking);
                card.Margin = new Padding(4);
                flowLayoutPanel1.Controls.Add(card);
            }

            LayoutFlowLayoutPanel();
        }

        private void LayoutFlowLayoutPanel() {
            const int BOTTOM_PADDING = 10;

            if (flowLayoutPanel1.Controls.Count > 0) {
                var firstCard = flowLayoutPanel1.Controls[0];

                int cardWidthWithMargin = firstCard.Width + firstCard.Margin.Left + firstCard.Margin.Right;
                int cardHeightWithMargin = firstCard.Height + firstCard.Margin.Top + firstCard.Margin.Bottom;

                int itemsPerRow = flowLayoutPanel1.ClientSize.Width / cardWidthWithMargin;
                if (itemsPerRow <= 0) itemsPerRow = 1;

               
                int totalRows = (int)Math.Ceiling((double)flowLayoutPanel1.Controls.Count / itemsPerRow);

                int flowLayoutHeight = totalRows * cardHeightWithMargin;

                flowLayoutPanel1.Height = flowLayoutHeight + flowLayoutPanel1.Padding.Top + BOTTOM_PADDING;
            }
        }

        private void ClearFlowLayout() {
            flowLayoutPanel1.Controls.Clear();
        }

        private void RenderActiveButton() {
            if (LowerPanel != null) {
                panelNav.Controls.Remove(LowerPanel);
            }

            LowerPanel = new Guna2Panel() {
                BackColor = Color.Transparent,
                Width = ActiveButton.Width,
                Height = 10,
                FillColor = AppConfig.Theme.Primary,
                Location = new Point(ActiveButton.Location.X, ActiveButton.Location.Y + ActiveButton.Height - 10),
                BorderRadius = 10,
                Margin = new Padding(0)
            };

            LowerPanel.CustomizableEdges.BottomRight = false;
            LowerPanel.CustomizableEdges.BottomLeft = false;
            panelNav.Controls.Add(LowerPanel);
            LowerPanel.Visible = true;
            LowerPanel.BringToFront();

            ActiveButton.ForeColor = AppConfig.Theme.Primary;
        }

        private void RemoveActiveButtonStyle() {
            ActiveButton.ForeColor = Color.FromArgb(64, 64, 64);
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

        private async void HandleStatusButtonClick(Guna2Button button ,string status) {
            RemoveActiveButtonStyle();
            ClearFlowLayout();
            ActiveButton = button;
            RenderActiveButton();
            _loader.ShowLoading(panelLoading);
            panelLoading.BringToFront();

            try {
                var bookings = await _db.GetBookingsByStatus(status);
                LoadBookingCards(bookings);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Something went wrong.");
            } finally {
                flowLayoutPanel1.BringToFront();
                _loader.HideLoading();
            }
        }

        private void pendingBtn_Click(object sender, EventArgs e) {
            HandleStatusButtonClick(pendingBtn, "Pending");
        }

        private void approvedBtn_Click(object sender, EventArgs e) {
            HandleStatusButtonClick(approvedBtn, "Approved");
        }

        private void rejectedBtn_Click(object sender, EventArgs e) {
            HandleStatusButtonClick(rejectedBtn, "Rejected");
        }

        private void completedBtn_Click(object sender, EventArgs e) {
            HandleStatusButtonClick(completedBtn, "Completed");
        }

        private async void allBtn_Click(object sender, EventArgs e) {
            ClearFlowLayout();
            RemoveActiveButtonStyle();
            ActiveButton = allBtn;
            RenderActiveButton();

            var bookings = await _db.GetAllBookings();
            LoadBookingCards(bookings);
        }
    }
}
