namespace VehicleManagementSystem.UserControls {
    partial class ucBookingCard {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.sideStatusPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.shadowPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDateSubmitted = new System.Windows.Forms.Label();
            this.shadowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideStatusPanel
            // 
            this.sideStatusPanel.BorderRadius = 15;
            this.sideStatusPanel.CustomizableEdges.BottomRight = false;
            this.sideStatusPanel.CustomizableEdges.TopRight = false;
            this.sideStatusPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideStatusPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sideStatusPanel.Location = new System.Drawing.Point(0, 0);
            this.sideStatusPanel.Name = "sideStatusPanel";
            this.sideStatusPanel.Size = new System.Drawing.Size(6, 160);
            this.sideStatusPanel.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(20, 15);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(128, 21);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblBookingID
            // 
            this.lblBookingID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookingID.ForeColor = System.Drawing.Color.Silver;
            this.lblBookingID.Location = new System.Drawing.Point(180, 15);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(150, 20);
            this.lblBookingID.TabIndex = 5;
            this.lblBookingID.Text = "BK-0000";
            this.lblBookingID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicle.ForeColor = System.Drawing.Color.Gray;
            this.lblVehicle.Location = new System.Drawing.Point(21, 45);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(79, 15);
            this.lblVehicle.TabIndex = 4;
            this.lblVehicle.Text = "Vehicle Name";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDates.Location = new System.Drawing.Point(21, 80);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(128, 15);
            this.lblDates.TabIndex = 3;
            this.lblDates.Text = "Mar 25 - Mar 30, 2026";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPrice.Location = new System.Drawing.Point(180, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 30);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "$0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnView
            // 
            this.btnView.BorderColor = System.Drawing.Color.LightGray;
            this.btnView.BorderRadius = 4;
            this.btnView.BorderThickness = 1;
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnView.Location = new System.Drawing.Point(24, 115);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(80, 30);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblStatus.Location = new System.Drawing.Point(21, 62);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "PENDING";
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel.BorderRadius = 15;
            this.shadowPanel.Controls.Add(this.lblDateSubmitted);
            this.shadowPanel.Controls.Add(this.lblStatus);
            this.shadowPanel.Controls.Add(this.btnView);
            this.shadowPanel.Controls.Add(this.lblPrice);
            this.shadowPanel.Controls.Add(this.lblDates);
            this.shadowPanel.Controls.Add(this.lblVehicle);
            this.shadowPanel.Controls.Add(this.lblBookingID);
            this.shadowPanel.Controls.Add(this.lblCustomerName);
            this.shadowPanel.Controls.Add(this.sideStatusPanel);
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadowPanel.FillColor = System.Drawing.Color.White;
            this.shadowPanel.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(350, 160);
            this.shadowPanel.TabIndex = 0;
            // 
            // lblDateSubmitted
            // 
            this.lblDateSubmitted.AutoSize = true;
            this.lblDateSubmitted.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblDateSubmitted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDateSubmitted.Location = new System.Drawing.Point(273, 45);
            this.lblDateSubmitted.Name = "lblDateSubmitted";
            this.lblDateSubmitted.Size = new System.Drawing.Size(57, 15);
            this.lblDateSubmitted.TabIndex = 7;
            this.lblDateSubmitted.Text = "Yesterday";
            // 
            // ucBookingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.shadowPanel);
            this.Name = "ucBookingCard";
            this.Size = new System.Drawing.Size(350, 160);
            this.shadowPanel.ResumeLayout(false);
            this.shadowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel sideStatusPanel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button btnView;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Panel shadowPanel;
        private System.Windows.Forms.Label lblDateSubmitted;
    }
}