namespace VehicleManagementSystem.View.Forms {
    partial class frmBookings {
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
            this.panelNav = new Guna.UI2.WinForms.Guna2Panel();
            this.allBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pendingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.approvedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.rejectedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.completedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.hr = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNav.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNav.BackColor = System.Drawing.Color.Transparent;
            this.panelNav.Controls.Add(this.pendingBtn);
            this.panelNav.Controls.Add(this.approvedBtn);
            this.panelNav.Controls.Add(this.rejectedBtn);
            this.panelNav.Controls.Add(this.completedBtn);
            this.panelNav.Controls.Add(this.allBtn);
            this.panelNav.Location = new System.Drawing.Point(287, 22);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(810, 61);
            this.panelNav.TabIndex = 35;
            // 
            // allBtn
            // 
            this.allBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.allBtn.FillColor = System.Drawing.Color.Transparent;
            this.allBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.allBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allBtn.Location = new System.Drawing.Point(651, 0);
            this.allBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(159, 61);
            this.allBtn.TabIndex = 6;
            this.allBtn.Text = "All";
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // pendingBtn
            // 
            this.pendingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pendingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pendingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pendingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pendingBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pendingBtn.FillColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pendingBtn.Location = new System.Drawing.Point(9, 0);
            this.pendingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pendingBtn.Name = "pendingBtn";
            this.pendingBtn.Size = new System.Drawing.Size(159, 61);
            this.pendingBtn.TabIndex = 5;
            this.pendingBtn.Text = "Pendings";
            this.pendingBtn.Click += new System.EventHandler(this.pendingBtn_Click);
            // 
            // approvedBtn
            // 
            this.approvedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.approvedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.approvedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.approvedBtn.FillColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.approvedBtn.Location = new System.Drawing.Point(168, 0);
            this.approvedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approvedBtn.Name = "approvedBtn";
            this.approvedBtn.Size = new System.Drawing.Size(159, 61);
            this.approvedBtn.TabIndex = 3;
            this.approvedBtn.Text = "Approved";
            this.approvedBtn.Click += new System.EventHandler(this.approvedBtn_Click);
            // 
            // rejectedBtn
            // 
            this.rejectedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rejectedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rejectedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rejectedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rejectedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rejectedBtn.FillColor = System.Drawing.Color.Transparent;
            this.rejectedBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rejectedBtn.Location = new System.Drawing.Point(327, 0);
            this.rejectedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rejectedBtn.Name = "rejectedBtn";
            this.rejectedBtn.Size = new System.Drawing.Size(159, 61);
            this.rejectedBtn.TabIndex = 4;
            this.rejectedBtn.Text = "Rejected";
            this.rejectedBtn.Click += new System.EventHandler(this.rejectedBtn_Click);
            // 
            // completedBtn
            // 
            this.completedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.completedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.completedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.completedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.completedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.completedBtn.FillColor = System.Drawing.Color.Transparent;
            this.completedBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.completedBtn.Location = new System.Drawing.Point(486, 0);
            this.completedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.completedBtn.Name = "completedBtn";
            this.completedBtn.Size = new System.Drawing.Size(165, 61);
            this.completedBtn.TabIndex = 4;
            this.completedBtn.Text = "Completed";
            this.completedBtn.Click += new System.EventHandler(this.completedBtn_Click);
            // 
            // hr
            // 
            this.hr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hr.BackColor = System.Drawing.Color.Transparent;
            this.hr.Location = new System.Drawing.Point(29, 81);
            this.hr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(1068, 4);
            this.hr.TabIndex = 36;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1065, 446);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Easily manage all bookings\r\n.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 35);
            this.label3.TabIndex = 39;
            this.label3.Text = "Bookings List";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.hr);
            this.panelMain.Controls.Add(this.panelNav);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Controls.Add(this.panelLoading);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.Location = new System.Drawing.Point(2, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1130, 546);
            this.panelMain.TabIndex = 41;
            // 
            // panelLoading
            // 
            this.panelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoading.Location = new System.Drawing.Point(10, 104);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(1120, 388);
            this.panelLoading.TabIndex = 41;
            // 
            // frmBookings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 546);
            this.Controls.Add(this.panelMain);
            this.Name = "frmBookings";
            this.Text = "frmBookings";
            this.panelNav.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelNav;
        private Guna.UI2.WinForms.Guna2Button pendingBtn;
        private Guna.UI2.WinForms.Guna2Button approvedBtn;
        private Guna.UI2.WinForms.Guna2Button rejectedBtn;
        private Guna.UI2.WinForms.Guna2Button completedBtn;
        private Guna.UI2.WinForms.Guna2Panel hr;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button allBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelLoading;
    }
}