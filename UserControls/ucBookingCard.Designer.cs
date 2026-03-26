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
            this.sideStatusPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sideStatusPanel.Name = "sideStatusPanel";
            this.sideStatusPanel.Size = new System.Drawing.Size(8, 197);
            this.sideStatusPanel.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(27, 18);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(160, 28);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblBookingID
            // 
            this.lblBookingID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookingID.ForeColor = System.Drawing.Color.Silver;
            this.lblBookingID.Location = new System.Drawing.Point(240, 18);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(200, 25);
            this.lblBookingID.TabIndex = 5;
            this.lblBookingID.Text = "BK-0000";
            this.lblBookingID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicle.ForeColor = System.Drawing.Color.Gray;
            this.lblVehicle.Location = new System.Drawing.Point(28, 55);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(84, 20);
            this.lblVehicle.TabIndex = 4;
            this.lblVehicle.Text = "Vehicle VIN";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDates.Location = new System.Drawing.Point(28, 98);
            this.lblDates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(159, 20);
            this.lblDates.TabIndex = 3;
            this.lblDates.Text = "Mar 25 - Mar 30, 2026";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPrice.Location = new System.Drawing.Point(240, 142);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(200, 37);
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
            this.btnView.Location = new System.Drawing.Point(32, 142);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 37);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblStatus.Location = new System.Drawing.Point(28, 76);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "PENDING";
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel.BorderRadius = 15;
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
            this.shadowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(467, 197);
            this.shadowPanel.TabIndex = 0;
            // 
            // ucBookingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.shadowPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBookingCard";
            this.Size = new System.Drawing.Size(467, 197);
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
    }
}