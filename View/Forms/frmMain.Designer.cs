using FontAwesome.Sharp;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.activityLogsBtn = new FontAwesome.Sharp.IconButton();
            this.userManagementBtn = new FontAwesome.Sharp.IconButton();
            this.maintenanceBtn = new FontAwesome.Sharp.IconButton();
            this.vehManagementBtn = new FontAwesome.Sharp.IconButton();
            this.inboundBtn = new FontAwesome.Sharp.IconButton();
            this.outboundBtn = new FontAwesome.Sharp.IconButton();
            this.bookingsBtn = new FontAwesome.Sharp.IconButton();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenuLine = new Guna.UI2.WinForms.Guna2Panel();
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.menuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.maximizeBtn = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.userMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.userMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.activityLogsBtn);
            this.panelMenu.Controls.Add(this.userManagementBtn);
            this.panelMenu.Controls.Add(this.maintenanceBtn);
            this.panelMenu.Controls.Add(this.vehManagementBtn);
            this.panelMenu.Controls.Add(this.inboundBtn);
            this.panelMenu.Controls.Add(this.outboundBtn);
            this.panelMenu.Controls.Add(this.bookingsBtn);
            this.panelMenu.Controls.Add(this.dashboardBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.guna2Transition1.SetDecoration(this.panelMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(317, 825);
            this.panelMenu.TabIndex = 0;
            // 
            // activityLogsBtn
            // 
            this.activityLogsBtn.BackColor = System.Drawing.Color.Transparent;
            this.activityLogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.activityLogsBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activityLogsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.activityLogsBtn.FlatAppearance.BorderSize = 0;
            this.activityLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.activityLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityLogsBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLogsBtn.ForeColor = System.Drawing.Color.Gray;
            this.activityLogsBtn.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            this.activityLogsBtn.IconColor = System.Drawing.Color.DarkGray;
            this.activityLogsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.activityLogsBtn.IconSize = 50;
            this.activityLogsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activityLogsBtn.Location = new System.Drawing.Point(0, 756);
            this.activityLogsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityLogsBtn.Name = "activityLogsBtn";
            this.activityLogsBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.activityLogsBtn.Size = new System.Drawing.Size(317, 80);
            this.activityLogsBtn.TabIndex = 7;
            this.activityLogsBtn.Text = "Activity Logs";
            this.activityLogsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activityLogsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.activityLogsBtn.UseVisualStyleBackColor = false;
            this.activityLogsBtn.Click += new System.EventHandler(this.activityLogsBtn_Click);
            // 
            // userManagementBtn
            // 
            this.userManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.userManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.userManagementBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userManagementBtn.FlatAppearance.BorderSize = 0;
            this.userManagementBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.userManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userManagementBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementBtn.ForeColor = System.Drawing.Color.Gray;
            this.userManagementBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userManagementBtn.IconColor = System.Drawing.Color.DarkGray;
            this.userManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userManagementBtn.IconSize = 50;
            this.userManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userManagementBtn.Location = new System.Drawing.Point(0, 676);
            this.userManagementBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userManagementBtn.Name = "userManagementBtn";
            this.userManagementBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.userManagementBtn.Size = new System.Drawing.Size(317, 80);
            this.userManagementBtn.TabIndex = 6;
            this.userManagementBtn.Text = "User Management";
            this.userManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userManagementBtn.UseVisualStyleBackColor = false;
            this.userManagementBtn.Click += new System.EventHandler(this.userManagementBtn_Click);
            // 
            // maintenanceBtn
            // 
            this.maintenanceBtn.BackColor = System.Drawing.Color.Transparent;
            this.maintenanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.maintenanceBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.maintenanceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.maintenanceBtn.FlatAppearance.BorderSize = 0;
            this.maintenanceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.maintenanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maintenanceBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceBtn.ForeColor = System.Drawing.Color.Gray;
            this.maintenanceBtn.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.maintenanceBtn.IconColor = System.Drawing.Color.DarkGray;
            this.maintenanceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maintenanceBtn.IconSize = 50;
            this.maintenanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maintenanceBtn.Location = new System.Drawing.Point(0, 594);
            this.maintenanceBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maintenanceBtn.Name = "maintenanceBtn";
            this.maintenanceBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.maintenanceBtn.Size = new System.Drawing.Size(317, 82);
            this.maintenanceBtn.TabIndex = 11;
            this.maintenanceBtn.Text = "Maintenace Management";
            this.maintenanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maintenanceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.maintenanceBtn.UseVisualStyleBackColor = false;
            this.maintenanceBtn.Click += new System.EventHandler(this.maintenanceBtn_Click);
            // 
            // vehManagementBtn
            // 
            this.vehManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.vehManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.vehManagementBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.vehManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehManagementBtn.FlatAppearance.BorderSize = 0;
            this.vehManagementBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.vehManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehManagementBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehManagementBtn.ForeColor = System.Drawing.Color.Gray;
            this.vehManagementBtn.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.vehManagementBtn.IconColor = System.Drawing.Color.DarkGray;
            this.vehManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehManagementBtn.IconSize = 50;
            this.vehManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehManagementBtn.Location = new System.Drawing.Point(0, 512);
            this.vehManagementBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehManagementBtn.Name = "vehManagementBtn";
            this.vehManagementBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.vehManagementBtn.Size = new System.Drawing.Size(317, 82);
            this.vehManagementBtn.TabIndex = 1;
            this.vehManagementBtn.Text = "Vehicle Management";
            this.vehManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehManagementBtn.UseVisualStyleBackColor = false;
            this.vehManagementBtn.Click += new System.EventHandler(this.vehManagementBtn_Click);
            // 
            // inboundBtn
            // 
            this.inboundBtn.BackColor = System.Drawing.Color.Transparent;
            this.inboundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.inboundBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.inboundBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inboundBtn.FlatAppearance.BorderSize = 0;
            this.inboundBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.inboundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inboundBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboundBtn.ForeColor = System.Drawing.Color.Gray;
            this.inboundBtn.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.inboundBtn.IconColor = System.Drawing.Color.DarkGray;
            this.inboundBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inboundBtn.IconSize = 50;
            this.inboundBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inboundBtn.Location = new System.Drawing.Point(0, 430);
            this.inboundBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inboundBtn.Name = "inboundBtn";
            this.inboundBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.inboundBtn.Size = new System.Drawing.Size(317, 82);
            this.inboundBtn.TabIndex = 8;
            this.inboundBtn.Text = "Inbound";
            this.inboundBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inboundBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inboundBtn.UseVisualStyleBackColor = false;
            this.inboundBtn.Click += new System.EventHandler(this.inboundBtn_Click);
            // 
            // outboundBtn
            // 
            this.outboundBtn.BackColor = System.Drawing.Color.Transparent;
            this.outboundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.outboundBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.outboundBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.outboundBtn.FlatAppearance.BorderSize = 0;
            this.outboundBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.outboundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outboundBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboundBtn.ForeColor = System.Drawing.Color.Gray;
            this.outboundBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.outboundBtn.IconColor = System.Drawing.Color.DarkGray;
            this.outboundBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.outboundBtn.IconSize = 50;
            this.outboundBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outboundBtn.Location = new System.Drawing.Point(0, 348);
            this.outboundBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outboundBtn.Name = "outboundBtn";
            this.outboundBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.outboundBtn.Size = new System.Drawing.Size(317, 82);
            this.outboundBtn.TabIndex = 9;
            this.outboundBtn.Text = "Outbound";
            this.outboundBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outboundBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.outboundBtn.UseVisualStyleBackColor = false;
            this.outboundBtn.Click += new System.EventHandler(this.outboundBtn_Click);
            // 
            // bookingsBtn
            // 
            this.bookingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.bookingsBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bookingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingsBtn.FlatAppearance.BorderSize = 0;
            this.bookingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.bookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsBtn.ForeColor = System.Drawing.Color.Gray;
            this.bookingsBtn.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.bookingsBtn.IconColor = System.Drawing.Color.DarkGray;
            this.bookingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingsBtn.IconSize = 50;
            this.bookingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.Location = new System.Drawing.Point(0, 266);
            this.bookingsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookingsBtn.Name = "bookingsBtn";
            this.bookingsBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.bookingsBtn.Size = new System.Drawing.Size(317, 82);
            this.bookingsBtn.TabIndex = 10;
            this.bookingsBtn.Text = "Bookings Management";
            this.bookingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingsBtn.UseVisualStyleBackColor = false;
            this.bookingsBtn.Click += new System.EventHandler(this.bookingsBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.dashboardBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.Gray;
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast;
            this.dashboardBtn.IconColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.IconSize = 50;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 186);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(317, 80);
            this.dashboardBtn.TabIndex = 7;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panelMenuLine);
            this.panelLogo.Controls.Add(this.panelUserDetails);
            this.guna2Transition1.SetDecoration(this.panelLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(317, 186);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenuLine
            // 
            this.panelMenuLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelMenuLine.AutoSize = true;
            this.panelMenuLine.BorderRadius = 4;
            this.guna2Transition1.SetDecoration(this.panelMenuLine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelMenuLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.panelMenuLine.Location = new System.Drawing.Point(12, 159);
            this.panelMenuLine.MaximumSize = new System.Drawing.Size(326, 5);
            this.panelMenuLine.Name = "panelMenuLine";
            this.panelMenuLine.Size = new System.Drawing.Size(287, 5);
            this.panelMenuLine.TabIndex = 0;
            // 
            // panelUserDetails
            // 
            this.panelUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelUserDetails.Controls.Add(this.menuBtn);
            this.panelUserDetails.Controls.Add(this.labelRole);
            this.panelUserDetails.Controls.Add(this.pictureUser);
            this.panelUserDetails.Controls.Add(this.labelUserName);
            this.guna2Transition1.SetDecoration(this.panelUserDetails, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelUserDetails.Location = new System.Drawing.Point(6, 78);
            this.panelUserDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(308, 76);
            this.panelUserDetails.TabIndex = 13;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.menuBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.menuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuBtn.FillColor = System.Drawing.Color.Transparent;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Image = global::VehicleManagementSystem.Properties.Resources.arrow_dropdown;
            this.menuBtn.Location = new System.Drawing.Point(233, 25);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(30, 30);
            this.menuBtn.TabIndex = 14;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.labelRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelRole.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.DimGray;
            this.labelRole.Location = new System.Drawing.Point(79, 46);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(39, 16);
            this.labelRole.TabIndex = 13;
            this.labelRole.Text = "Role";
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2Transition1.SetDecoration(this.pictureUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureUser.FillColor = System.Drawing.Color.IndianRed;
            this.pictureUser.Image = global::VehicleManagementSystem.Properties.Resources.account_circle;
            this.pictureUser.ImageRotate = 0F;
            this.pictureUser.Location = new System.Drawing.Point(6, 12);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureUser.Size = new System.Drawing.Size(67, 58);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 11;
            this.pictureUser.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.labelUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.DimGray;
            this.labelUserName.Location = new System.Drawing.Point(79, 30);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(168, 19);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "Firstname Lastname";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.labelPage);
            this.panelHeader.Controls.Add(this.maximizeBtn);
            this.panelHeader.Controls.Add(this.minimizeBtn);
            this.panelHeader.Controls.Add(this.closeBtn);
            this.guna2Transition1.SetDecoration(this.panelHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(317, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1095, 73);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.labelPage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelPage.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelPage.Location = new System.Drawing.Point(29, 20);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(206, 23);
            this.labelPage.TabIndex = 5;
            this.labelPage.Text = "Vehicle Management";
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.maximizeBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.maximizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maximizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ForeColor = System.Drawing.Color.White;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeBtn.IconSize = 25;
            this.maximizeBtn.Location = new System.Drawing.Point(973, 12);
            this.maximizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(49, 40);
            this.maximizeBtn.TabIndex = 10;
            this.maximizeBtn.UseVisualStyleBackColor = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.minimizeBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 28;
            this.minimizeBtn.Location = new System.Drawing.Point(921, 12);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(49, 40);
            this.minimizeBtn.TabIndex = 9;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.closeBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 28;
            this.closeBtn.Location = new System.Drawing.Point(1025, 12);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(49, 40);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktop.BorderRadius = 20;
            this.panelDesktop.CustomizableEdges.BottomLeft = false;
            this.panelDesktop.CustomizableEdges.BottomRight = false;
            this.panelDesktop.CustomizableEdges.TopRight = false;
            this.guna2Transition1.SetDecoration(this.panelDesktop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.FillColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(317, 73);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1095, 752);
            this.panelDesktop.TabIndex = 2;
            // 
            // userMenuStrip
            // 
            this.userMenuStrip.AutoSize = false;
            this.guna2Transition1.SetDecoration(this.userMenuStrip, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userMenuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userMenuStrip.Name = "userMenuStrip";
            this.userMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.userMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.userMenuStrip.RenderStyle.ColorTable = null;
            this.userMenuStrip.RenderStyle.RoundedEdges = true;
            this.userMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.userMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.userMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.userMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.userMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.userMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1412, 825);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.userMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton vehManagementBtn;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel panelDesktop;
        private System.Windows.Forms.Label labelPage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureUser;
        private System.Windows.Forms.Label labelUserName;
        private IconButton activityLogsBtn;
        private IconButton userManagementBtn;
        private IconButton dashboardBtn;
        private System.Windows.Forms.Panel panelUserDetails;
        private Guna.UI2.WinForms.Guna2Panel panelMenuLine;
        private System.Windows.Forms.Label labelRole;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip userMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button menuBtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private IconButton outboundBtn;
        private IconButton inboundBtn;
        private IconButton bookingsBtn;
        private IconButton maintenanceBtn;
    }
}