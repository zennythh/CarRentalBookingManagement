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
            this.pnlMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.confirmPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderColor = System.Drawing.Color.DimGray;
            this.pnlMain.BorderRadius = 5;
            this.pnlMain.BorderThickness = 1;
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
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(423, 367);
            this.pnlMain.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "You need to change password first to login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change password";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(79, 278);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(129, 43);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(216, 278);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 43);
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
            this.confirmPassTxt.Location = new System.Drawing.Point(79, 206);
            this.confirmPassTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PlaceholderText = "Confirm password";
            this.confirmPassTxt.SelectedText = "";
            this.confirmPassTxt.Size = new System.Drawing.Size(267, 44);
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
            this.newPassTxt.Location = new System.Drawing.Point(79, 142);
            this.newPassTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.PlaceholderText = "New password";
            this.newPassTxt.SelectedText = "";
            this.newPassTxt.Size = new System.Drawing.Size(267, 44);
            this.newPassTxt.TabIndex = 6;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(423, 367);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}