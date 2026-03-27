namespace VehicleManagementSystem.UserControls {
    partial class ucMaintenanceDashboard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelOver = new System.Windows.Forms.Label();
            this.labelDue = new System.Windows.Forms.Label();
            this.labelMaintenanceType = new System.Windows.Forms.Label();
            this.labelPlateNum = new System.Windows.Forms.Label();
            this.viewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.labelScheduleType = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1016, 68);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.labelScheduleType, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMaintenanceType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPlateNum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelOver, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDue, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelOver
            // 
            this.labelOver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOver.Location = new System.Drawing.Point(812, 0);
            this.labelOver.Margin = new System.Windows.Forms.Padding(14, 0, 3, 0);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(98, 68);
            this.labelOver.TabIndex = 4;
            this.labelOver.Text = "label1";
            this.labelOver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDue
            // 
            this.labelDue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDue.Location = new System.Drawing.Point(690, 0);
            this.labelDue.Margin = new System.Windows.Forms.Padding(14, 0, 3, 0);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(100, 68);
            this.labelDue.TabIndex = 3;
            this.labelDue.Text = "label1";
            this.labelDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaintenanceType
            // 
            this.labelMaintenanceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaintenanceType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaintenanceType.Location = new System.Drawing.Point(131, 0);
            this.labelMaintenanceType.Margin = new System.Windows.Forms.Padding(14, 0, 3, 0);
            this.labelMaintenanceType.Name = "labelMaintenanceType";
            this.labelMaintenanceType.Size = new System.Drawing.Size(398, 68);
            this.labelMaintenanceType.TabIndex = 2;
            this.labelMaintenanceType.Text = "label1";
            this.labelMaintenanceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlateNum
            // 
            this.labelPlateNum.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlateNum.Location = new System.Drawing.Point(14, 0);
            this.labelPlateNum.Margin = new System.Windows.Forms.Padding(14, 0, 3, 0);
            this.labelPlateNum.Name = "labelPlateNum";
            this.labelPlateNum.Size = new System.Drawing.Size(100, 68);
            this.labelPlateNum.TabIndex = 0;
            this.labelPlateNum.Text = "label1";
            this.labelPlateNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewBtn.BorderRadius = 10;
            this.viewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(923, 11);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(10);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(83, 45);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "View";
            // 
            // labelScheduleType
            // 
            this.labelScheduleType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduleType.Location = new System.Drawing.Point(546, 0);
            this.labelScheduleType.Margin = new System.Windows.Forms.Padding(14, 0, 3, 0);
            this.labelScheduleType.Name = "labelScheduleType";
            this.labelScheduleType.Size = new System.Drawing.Size(100, 68);
            this.labelScheduleType.TabIndex = 5;
            this.labelScheduleType.Text = "label1";
            this.labelScheduleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucMaintenanceDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucMaintenanceDashboard";
            this.Size = new System.Drawing.Size(1016, 68);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPlateNum;
        private Guna.UI2.WinForms.Guna2Button viewBtn;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.Label labelDue;
        private System.Windows.Forms.Label labelMaintenanceType;
        private System.Windows.Forms.Label labelScheduleType;
    }
}
