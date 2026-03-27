namespace PL_VehicleRental.Forms
{
    partial class frmChangePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.pnlMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chkShowCnfrmPassword = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.chkShowNewPassword = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.confirmPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderColor = System.Drawing.Color.DimGray;
            this.pnlMain.BorderRadius = 5;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.chkShowCnfrmPassword);
            this.pnlMain.Controls.Add(this.chkShowNewPassword);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cancelBtn);
            this.pnlMain.Controls.Add(this.saveBtn);
            this.pnlMain.Controls.Add(this.confirmPassTxt);
            this.pnlMain.Controls.Add(this.newPassTxt);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.pnlMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(167)))), ((int)(((byte)(161)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(476, 548);
            this.pnlMain.TabIndex = 0;
            // 
            // chkShowCnfrmPassword
            // 
            this.chkShowCnfrmPassword.BackColor = System.Drawing.Color.White;
            this.chkShowCnfrmPassword.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.chkShowCnfrmPassword.Image = global::VehicleManagementSystem.Properties.Resources.showPassIcon;
            this.chkShowCnfrmPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkShowCnfrmPassword.ImageRotate = 0F;
            this.chkShowCnfrmPassword.Location = new System.Drawing.Point(348, 277);
            this.chkShowCnfrmPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkShowCnfrmPassword.Name = "chkShowCnfrmPassword";
            this.chkShowCnfrmPassword.Size = new System.Drawing.Size(33, 40);
            this.chkShowCnfrmPassword.TabIndex = 13;
            this.chkShowCnfrmPassword.CheckedChanged += new System.EventHandler(this.chkShowCnfrmPassword_CheckedChanged);
            // 
            // chkShowNewPassword
            // 
            this.chkShowNewPassword.BackColor = System.Drawing.Color.White;
            this.chkShowNewPassword.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.chkShowNewPassword.Image = global::VehicleManagementSystem.Properties.Resources.showPassIcon;
            this.chkShowNewPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkShowNewPassword.ImageRotate = 0F;
            this.chkShowNewPassword.Location = new System.Drawing.Point(350, 195);
            this.chkShowNewPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkShowNewPassword.Name = "chkShowNewPassword";
            this.chkShowNewPassword.Size = new System.Drawing.Size(33, 40);
            this.chkShowNewPassword.TabIndex = 12;
            this.chkShowNewPassword.CheckedChanged += new System.EventHandler(this.chkShowNewPassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(66, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "You need to change password first to login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(108, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change password";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = global::VehicleManagementSystem.Properties.Resources.close_icon;
            this.cancelBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.cancelBtn.Location = new System.Drawing.Point(428, 5);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(44, 40);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 5;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(88, 351);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(300, 54);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassTxt.DefaultText = "";
            this.confirmPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPassTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmPassTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPassTxt.Location = new System.Drawing.Point(88, 268);
            this.confirmPassTxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PlaceholderText = "Confirm password";
            this.confirmPassTxt.SelectedText = "";
            this.confirmPassTxt.Size = new System.Drawing.Size(300, 55);
            this.confirmPassTxt.TabIndex = 7;
            // 
            // newPassTxt
            // 
            this.newPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassTxt.DefaultText = "";
            this.newPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPassTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPassTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPassTxt.Location = new System.Drawing.Point(88, 188);
            this.newPassTxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.PlaceholderText = "New password";
            this.newPassTxt.SelectedText = "";
            this.newPassTxt.Size = new System.Drawing.Size(300, 55);
            this.newPassTxt.TabIndex = 6;
            this.newPassTxt.TextChanged += new System.EventHandler(this.newPassTxt_TextChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(476, 548);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChangePassword_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2TextBox confirmPassTxt;
        private Guna.UI2.WinForms.Guna2TextBox newPassTxt;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkShowCnfrmPassword;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkShowNewPassword;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}