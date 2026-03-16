using System;
using System.Drawing;
using System.Windows.Forms;
using VehicleManagementSystem.Forms;
using VehicleManagementSystem.Classes;
using PL_VehicleRental.Forms;
using Dshboard;
using ActivityLogs;
using PL_VehicleRental.Services.Security;
using VehicleManagementSystem.Dto;
using System.IO;

namespace VehicleManagementSystem {

    public partial class frmMain : Form {

        // Fields
        public static frmMain Instance { get; private set; }
        public static Panel ChildFormContainer { get; private set; }

        private WindowControls WindowActions;
        private UIRenderer MenuHandler;

        private Label labelComponent;

        private void LoadDefaultView() {
            //WindowActions.ToggleMaximize(maximizeBtn);
            NavigationHelper.OpenForm(new frmVehicleManagement());
            MenuHandler.ActivateButton(vehManagementBtn);
        }

        public frmMain() {
            Instance = this;
           
            InitializeComponent();

            // Initialize Helpers Classes
            WindowActions = new WindowControls(this);
            MenuHandler = new UIRenderer(panelMenu);

            ChildFormContainer = panelDesktop;
            LoadDefaultView();
           
        }

        public void AddHeaderLabel(string label) {
            labelComponent = new Label();

            labelComponent.Tag = label;
            labelComponent.AutoSize = true;
            labelComponent.ForeColor = AppConfig.Theme.Primary;
            labelComponent.BackColor = System.Drawing.Color.Transparent;
            labelComponent.Font = new Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelComponent.Location = new Point(labelPage.Right, labelPage.Location.Y);
            labelComponent.Text = "> " + label;
            labelComponent.TabIndex = 2;

            panelHeader.Controls.Add(labelComponent);

            labelComponent.Visible = true;
            labelComponent.BringToFront();
        }

        public void RemoveHeaderLabel() {
            if (labelComponent != null) {
                panelHeader.Controls.Remove(labelComponent);
            }
        }

        // Windows Actions
        private void CloseButton_Click(object sender, EventArgs e) => Application.Exit();
        private async void maximizeBtn_Click(object sender, EventArgs e) => await WindowActions.ToggleMaximize(maximizeBtn);
        private void minimizeBtn_Click(object sender, EventArgs e) => WindowActions.Minimize();
        private void panelHeader_MouseDown(object sender, MouseEventArgs e) => WindowActions.Drag(e);

        // Navigation Functions
        private void vehManagementBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.VehManagement;
            NavigationHelper.OpenForm(new frmVehicleManagement());
        }

        private void dashboardBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.Dashboard;
            NavigationHelper.OpenForm(new DashBoardForm());
        }

        private void userManagementBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.UserManagement;
            NavigationHelper.OpenForm(new UserManagementForm());
        }

        private void activityLogsBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.ActivityLogs;
            NavigationHelper.OpenForm(new LogsForm());
        }

        private void maintenanceMangementBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.MaintenanceManagement;
            NavigationHelper.OpenForm(new frmMaintenanceManagement());
        }

        private void LoadUserImage()
        {
            try
            {
                if (Session.User == null) return;

                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    AppDomain.CurrentDomain.BaseDirectory, "UserImages");

                string fullPath = Path.Combine(folder, Session.User.UserImagePath ?? "");

                if (!string.IsNullOrWhiteSpace(Session.User.UserImagePath) && File.Exists(fullPath))
                {
                    pictureUser.Image = Image.FromFile(fullPath);
                } 
                else
                {
                    pictureUser.Image = Properties.Resources.avatar_default;
                }
            }
            catch
            {
                pictureUser.Image = Properties.Resources.avatar_default;
            }
        }

        private void LoadCurrentUser()
        {
            if (Session.User != null)
            {
                labelUserName.Text = $"{Session.User.FullName}";
                labelRole.Text = $"{Session.User.Role}";

                LoadUserImage();
            }
        }

        // Make the scroll more responsive
        // Boiler plate from stacks overflow
        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x115 || m.Msg == 0x114) {
                if ((m.WParam.ToInt32() & 0xFFFF) == 5) {
                    m.WParam = (IntPtr)((m.WParam.ToInt32() & ~0xFFFF) | 4);
                }
            }
            base.WndProc(ref m);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();
        }
    }
}
