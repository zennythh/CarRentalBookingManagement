namespace PL_VehicleRental.Forms
{
    partial class frmInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pnlProgress = new Guna.UI2.WinForms.Guna2Panel();
            this.userImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderThickness = 2;
            this.pnlMain.Controls.Add(this.guna2Separator2);
            this.pnlMain.Controls.Add(this.guna2Separator1);
            this.pnlMain.Controls.Add(this.exitBtn);
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.guna2Panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlMain.Size = new System.Drawing.Size(468, 505);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // exitBtn
            // 
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(421, 2);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(45, 34);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFullName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38796F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72241F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 267);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(90, 173);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(345, 42);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "label2";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(90, 131);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(345, 42);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "label6";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(90, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(345, 42);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "label6";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 42);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, 173);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 42);
            this.label.TabIndex = 4;
            this.label.Text = "Role:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(90, 47);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(345, 42);
            this.lblFullName.TabIndex = 14;
            this.lblFullName.Text = "label6";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(90, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(345, 42);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "label6";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "Full Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(8, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 42);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(90, 215);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(345, 47);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "label2";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Information";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.userImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(11, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(446, 188);
            this.guna2Panel1.TabIndex = 18;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar.Size = new System.Drawing.Size(468, 12);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 13;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgress.Controls.Add(this.progressBar);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgress.FillColor = System.Drawing.Color.Transparent;
            this.pnlProgress.Location = new System.Drawing.Point(0, 0);
            this.pnlProgress.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(468, 12);
            this.pnlProgress.TabIndex = 14;
            // 
            // userImage
            // 
            this.userImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(160, 63);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(132, 122);
            this.userImage.TabIndex = 7;
            this.userImage.TabStop = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(11, 201);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(446, 10);
            this.guna2Separator1.TabIndex = 20;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(11, 209);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(446, 10);
            this.guna2Separator2.TabIndex = 21;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 505);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInfo";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.Shown += new System.EventHandler(this.frmInfo_Shown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel pnlProgress;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox userImage;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}