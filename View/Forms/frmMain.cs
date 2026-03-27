using ActivityLogs;
using PL_VehicleRental.Forms;
using PL_VehicleRental.Services;
using PL_VehicleRental.Services.Security;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Forms;
using VehicleManagementSystem.Services.Security;
using VehicleManagementSystem.View.Forms;

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
            NavigationHelper.OpenForm(new frmDashboard());
            MenuHandler.ActivateButton(dashboardBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

            //labelComponent.Visible = true;
            //labelComponent.BringToFront();
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
            NavigationHelper.OpenForm(new frmDashboard());
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

        private void bookingsBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.Bookings;
            NavigationHelper.OpenForm(new frmBookings());
        }

        private void outboundBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.OutBound;
            NavigationHelper.OpenForm(new frmOutbound());
        }

        private void inboundBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.InBound;
            NavigationHelper.OpenForm(new frmInbound());
        }

        private void maintenanceBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.MaintenanceManagement;
            NavigationHelper.OpenForm(new frmMaintenanceManagement());
        }

        private void ShowUserMenu(Control control) {
            userMenuStrip.AutoSize = false;
            userMenuStrip.Width = control.Width;
            userMenuStrip.Height = 85;

            foreach (ToolStripItem item in userMenuStrip.Items)
            {
                item.AutoSize = false;
                item.Width = userMenuStrip.Width - 10;
                item.Height = 35;
                item.Margin = new Padding(2);
                item.Padding = new Padding(5, 10, 5, 10);
            }

            userMenuStrip.Show(control, new Point(0, control.Height));
        }

        private void menuBtn_Click(object sender, EventArgs e) {
            ShowUserMenu(panelUserDetails);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profileForm = new frmProfile();
            profileForm.FormClosed += ProfileForm_FormClosed;
            profileForm.ShowDialog();
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e) {
            RefreshUserDisplay();
        }

        private async void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                        "Are you sure you want to logout?",
                        "Logout",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {

                await AuditService.LogAsync(new AuditLog
                {
                    UserId = Session.User.Id,
                    ActionType = "LOGOUT",
                    Description = "User logged out",
                    TableAffected = "users",
                    RecordId = Session.User.Id
                });

                Session.User = null;
                this.Close();
            }
        }

        private void LoadUserImage()
        {
            try
            {
                if (Session.User == null) return;

                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    AppDomain.CurrentDomain.BaseDirectory, "UserImages");

                string fullPath = Path.Combine(folder, Session.User.UserImagePath ?? "");

                if (pictureUser.Image != null && pictureUser.Image != Properties.Resources.avatar_default)
                {
                    try
                    {
                        pictureUser.Image.Dispose();
                    }
                    catch { }
                }

                if (!string.IsNullOrWhiteSpace(Session.User.UserImagePath) && File.Exists(fullPath))
                {
                    using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        pictureUser.Image = Image.FromStream(fs);
                    }
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

        public void RefreshUserDisplay()
        {
            if (Session.User != null)
            {
                labelUserName.Text = $"{Session.User.FullName}";
                labelRole.Text = $"{Session.User.Role}";
                LoadUserImage();
            }
        }

        public void ApplyRoleBasedUI()
        {
            userManagementBtn.Visible = PermissionService.HasPermission(Permission.ManageUsers);
            //vehManagementBtn.Visible = PermissionService.HasPermission(Permission.ManageVehicles);
            activityLogsBtn.Visible = PermissionService.HasPermission(Permission.ViewReports);
        }

        //protected override CreateParams CreateParams {
        //    get {
        //        CreateParams cp = base.CreateParams;
        //        // WS_MAXIMIZEBOX (0x10000) | WS_CAPTION (0xC00000)
        //        // This tricks Windows into thinking the form has a caption bar
        //        // which triggers the "zoom" animation when maximizing.
        //        cp.Style |= 0x00010000 | 0x00C00000;
        //        return cp;
        //    }
        //}

        //Make the scroll more responsive
        //Boiler plate from stacks overflow
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
            ApplyRoleBasedUI();
        }

        
    }
}
