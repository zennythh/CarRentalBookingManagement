using Guna.UI2.WinForms;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.View.Forms {
    partial class frmVehicleDetails {
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
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.hr = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNav = new Guna.UI2.WinForms.Guna2Panel();
            this.overviewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.maintenanceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.documentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelSubMain = new Guna.UI2.WinForms.Guna2Panel();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelSubHeader = new System.Windows.Forms.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.mySqlCommand2 = new MySqlConnector.MySqlCommand();
            this.panelBg.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.BorderRadius = 25;
            this.panelBg.Controls.Add(this.panelMain);
            this.panelBg.CustomizableEdges.BottomLeft = false;
            this.panelBg.CustomizableEdges.BottomRight = false;
            this.panelBg.CustomizableEdges.TopRight = false;
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelBg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1132, 546);
            this.panelBg.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.hr);
            this.panelMain.Controls.Add(this.panelNav);
            this.panelMain.Controls.Add(this.panelSubMain);
            this.panelMain.Controls.Add(this.backBtn);
            this.panelMain.Controls.Add(this.labelSubHeader);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(22, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1110, 548);
            this.panelMain.TabIndex = 1;
            // 
            // hr
            // 
            this.hr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hr.BackColor = System.Drawing.Color.Transparent;
            this.hr.Location = new System.Drawing.Point(14, 83);
            this.hr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(1069, 4);
            this.hr.TabIndex = 35;
            // 
            // panelNav
            // 
            this.panelNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNav.BackColor = System.Drawing.Color.Transparent;
            this.panelNav.Controls.Add(this.overviewBtn);
            this.panelNav.Controls.Add(this.maintenanceBtn);
            this.panelNav.Controls.Add(this.documentsBtn);
            this.panelNav.Location = new System.Drawing.Point(592, 22);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(492, 61);
            this.panelNav.TabIndex = 34;
            // 
            // overviewBtn
            // 
            this.overviewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.overviewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.overviewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.overviewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.overviewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.overviewBtn.FillColor = System.Drawing.Color.Transparent;
            this.overviewBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.overviewBtn.Location = new System.Drawing.Point(9, 0);
            this.overviewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(159, 61);
            this.overviewBtn.TabIndex = 3;
            this.overviewBtn.Text = "Overview";
            this.overviewBtn.Click += new System.EventHandler(this.overviewBtn_Click);
            // 
            // maintenanceBtn
            // 
            this.maintenanceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maintenanceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maintenanceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maintenanceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maintenanceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maintenanceBtn.FillColor = System.Drawing.Color.Transparent;
            this.maintenanceBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maintenanceBtn.Location = new System.Drawing.Point(168, 0);
            this.maintenanceBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maintenanceBtn.Name = "maintenanceBtn";
            this.maintenanceBtn.Size = new System.Drawing.Size(159, 61);
            this.maintenanceBtn.TabIndex = 4;
            this.maintenanceBtn.Text = "Maintenance";
            this.maintenanceBtn.Click += new System.EventHandler(this.maintenanceBtn_Click);
            // 
            // documentsBtn
            // 
            this.documentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.documentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.documentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.documentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.documentsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.documentsBtn.FillColor = System.Drawing.Color.Transparent;
            this.documentsBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.documentsBtn.Location = new System.Drawing.Point(327, 0);
            this.documentsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.documentsBtn.Name = "documentsBtn";
            this.documentsBtn.Size = new System.Drawing.Size(165, 61);
            this.documentsBtn.TabIndex = 4;
            this.documentsBtn.Text = "Documents";
            this.documentsBtn.Click += new System.EventHandler(this.documentsBtn_Click);
            // 
            // panelSubMain
            // 
            this.panelSubMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubMain.AutoSize = true;
            this.panelSubMain.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMain.Location = new System.Drawing.Point(12, 102);
            this.panelSubMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubMain.Name = "panelSubMain";
            this.panelSubMain.Size = new System.Drawing.Size(1072, 533);
            this.panelSubMain.TabIndex = 33;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.BorderThickness = 4;
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::VehicleManagementSystem.Properties.Resources.chevron_backward_icon;
            this.backBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.backBtn.Location = new System.Drawing.Point(12, 27);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backBtn.Size = new System.Drawing.Size(48, 43);
            this.backBtn.TabIndex = 18;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // labelSubHeader
            // 
            this.labelSubHeader.AutoSize = true;
            this.labelSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelSubHeader.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubHeader.Location = new System.Drawing.Point(76, 35);
            this.labelSubHeader.Name = "labelSubHeader";
            this.labelSubHeader.Size = new System.Drawing.Size(103, 32);
            this.labelSubHeader.TabIndex = 0;
            this.labelSubHeader.Text = "Toyota";
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel9.BorderRadius = 2;
            this.guna2Panel9.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel9.Location = new System.Drawing.Point(12, 82);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(1071, 4);
            this.guna2Panel9.TabIndex = 32;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CommandTimeout = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.Transaction = null;
            this.mySqlCommand2.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 546);
            this.Controls.Add(this.panelBg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVehicleDetails";
            this.Text = "frmVehicleDetails";
            this.panelBg.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel panelBg;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private MySqlConnector.MySqlCommand mySqlCommand2;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2Button maintenanceBtn;
        private Guna.UI2.WinForms.Guna2Button documentsBtn;
        private Guna.UI2.WinForms.Guna2Button overviewBtn;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Label labelSubHeader;
        private Guna.UI2.WinForms.Guna2Panel panelSubMain;
        private Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel panelNav;
        private Guna2Panel hr;
    }
}