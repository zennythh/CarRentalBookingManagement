namespace VehicleManagementSystem.UserControls {
    partial class VehicleDocumentCardControl {
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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelExtension = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.viewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableMain.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.BackColor = System.Drawing.Color.Transparent;
            this.tableMain.ColumnCount = 6;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableMain.Controls.Add(this.labelExtension, 2, 0);
            this.tableMain.Controls.Add(this.labelTitle, 1, 0);
            this.tableMain.Controls.Add(this.labelType, 0, 0);
            this.tableMain.Controls.Add(this.guna2Panel2, 5, 0);
            this.tableMain.Controls.Add(this.panelStatus, 4, 0);
            this.tableMain.Controls.Add(this.labelExpirationDate, 3, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1152, 80);
            this.tableMain.TabIndex = 0;
            // 
            // labelExtension
            // 
            this.labelExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExtension.AutoEllipsis = true;
            this.labelExtension.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtension.ForeColor = System.Drawing.Color.Gray;
            this.labelExtension.Location = new System.Drawing.Point(533, 19);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(91, 41);
            this.labelExtension.TabIndex = 5;
            this.labelExtension.Text = ".PDF";
            this.labelExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoEllipsis = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gray;
            this.labelTitle.Location = new System.Drawing.Point(169, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(358, 41);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Certificate of Registration";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelType.AutoEllipsis = true;
            this.labelType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.Gray;
            this.labelType.Location = new System.Drawing.Point(11, 19);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(152, 41);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Requierd Renewal";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnEdit);
            this.guna2Panel2.Controls.Add(this.btnRenew);
            this.guna2Panel2.Controls.Add(this.viewBtn);
            this.guna2Panel2.Location = new System.Drawing.Point(921, 11);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(228, 58);
            this.guna2Panel2.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.BackgroundImage = global::VehicleManagementSystem.Properties.Resources.deleteIcon;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 3;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.btnDelete.Location = new System.Drawing.Point(172, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.BackgroundImage = global::VehicleManagementSystem.Properties.Resources.editIcon;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.BorderColor = System.Drawing.Color.Silver;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderThickness = 3;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.btnEdit.Location = new System.Drawing.Point(64, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRenew.BackgroundImage = global::VehicleManagementSystem.Properties.Resources.resend__1_;
            this.btnRenew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRenew.BorderColor = System.Drawing.Color.Silver;
            this.btnRenew.BorderRadius = 10;
            this.btnRenew.BorderThickness = 3;
            this.btnRenew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRenew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRenew.FillColor = System.Drawing.Color.Transparent;
            this.btnRenew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRenew.Location = new System.Drawing.Point(118, 9);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Padding = new System.Windows.Forms.Padding(10);
            this.btnRenew.Size = new System.Drawing.Size(48, 42);
            this.btnRenew.TabIndex = 1;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewBtn.BackgroundImage = global::VehicleManagementSystem.Properties.Resources.showPassIcon;
            this.viewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewBtn.BorderColor = System.Drawing.Color.Silver;
            this.viewBtn.BorderRadius = 10;
            this.viewBtn.BorderThickness = 3;
            this.viewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewBtn.FillColor = System.Drawing.Color.Transparent;
            this.viewBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.viewBtn.Location = new System.Drawing.Point(11, 8);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(47, 42);
            this.viewBtn.TabIndex = 0;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStatus.BorderRadius = 10;
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.FillColor = System.Drawing.Color.DarkOrange;
            this.panelStatus.ForeColor = System.Drawing.Color.White;
            this.panelStatus.Location = new System.Drawing.Point(784, 17);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(131, 45);
            this.panelStatus.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(-6, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(146, 45);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Expires Soon";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelExpirationDate.AutoEllipsis = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDate.ForeColor = System.Drawing.Color.Gray;
            this.labelExpirationDate.Location = new System.Drawing.Point(647, 19);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(113, 41);
            this.labelExpirationDate.TabIndex = 3;
            this.labelExpirationDate.Text = "2/28/2026";
            this.labelExpirationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.Controls.Add(this.tableMain);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1152, 80);
            this.guna2Panel3.TabIndex = 1;
            // 
            // VehicleDocumentCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VehicleDocumentCardControl";
            this.Size = new System.Drawing.Size(1152, 80);
            this.tableMain.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private Guna.UI2.WinForms.Guna2Panel panelStatus;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelStatus;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label labelExpirationDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button viewBtn;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRenew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label labelExtension;
    }
}
