namespace PL_VehicleRental.Forms
{
    partial class frmAddUser
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.userImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.roleCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.emaiTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.statusCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roleLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlUserImage = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlUserImage.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderThickness = 2;
            this.pnlMain.Controls.Add(this.guna2Panel3);
            this.pnlMain.Controls.Add(this.pnlUserImage);
            this.pnlMain.Controls.Add(this.guna2Panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(509, 766);
            this.pnlMain.TabIndex = 0;
            // 
            // userImage
            // 
            this.userImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userImage.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(151, 6);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(180, 154);
            this.userImage.TabIndex = 8;
            this.userImage.TabStop = false;
            this.userImage.Click += new System.EventHandler(this.userImage_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone no.";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTxt.BackColor = System.Drawing.Color.Transparent;
            this.phoneTxt.BorderRadius = 5;
            this.phoneTxt.BorderThickness = 2;
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxt.DefaultText = "";
            this.phoneTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTxt.ForeColor = System.Drawing.Color.Black;
            this.phoneTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.Location = new System.Drawing.Point(245, 111);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PlaceholderText = "";
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.Size = new System.Drawing.Size(218, 53);
            this.phoneTxt.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(34, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // exitBtn
            // 
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(441, 2);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(45, 34);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(242, 335);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(10, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(201, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Personal Information";
            // 
            // roleCmb
            // 
            this.roleCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleCmb.BackColor = System.Drawing.Color.Transparent;
            this.roleCmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roleCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roleCmb.ForeColor = System.Drawing.Color.Black;
            this.roleCmb.ItemHeight = 30;
            this.roleCmb.Items.AddRange(new object[] {
            "Superadmin",
            "Admin",
            "Staff",
            "Mechanic"});
            this.roleCmb.Location = new System.Drawing.Point(37, 354);
            this.roleCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(171, 36);
            this.roleCmb.StartIndex = 0;
            this.roleCmb.TabIndex = 6;
            this.roleCmb.SelectedIndexChanged += new System.EventHandler(this.roleCmb_SelectedIndexChanged);
            // 
            // emaiTextBox
            // 
            this.emaiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emaiTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emaiTextBox.BorderRadius = 5;
            this.emaiTextBox.BorderThickness = 2;
            this.emaiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emaiTextBox.DefaultText = "";
            this.emaiTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emaiTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emaiTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emaiTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emaiTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emaiTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emaiTextBox.ForeColor = System.Drawing.Color.Black;
            this.emaiTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emaiTextBox.Location = new System.Drawing.Point(20, 111);
            this.emaiTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emaiTextBox.Name = "emaiTextBox";
            this.emaiTextBox.PlaceholderText = "";
            this.emaiTextBox.SelectedText = "";
            this.emaiTextBox.Size = new System.Drawing.Size(218, 53);
            this.emaiTextBox.TabIndex = 3;
            this.emaiTextBox.TextChanged += new System.EventHandler(this.emaiTxt_TextChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(1, 316);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(494, 10);
            this.guna2Separator1.TabIndex = 0;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Details";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.addressLabel.Location = new System.Drawing.Point(34, 185);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(57, 17);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.Location = new System.Drawing.Point(15, 55);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(427, 10);
            this.guna2Separator2.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.AutoRoundedCorners = true;
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderRadius = 22;
            this.clearBtn.BorderThickness = 1;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(234, 436);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(97, 46);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // statusCmb
            // 
            this.statusCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusCmb.BackColor = System.Drawing.Color.Transparent;
            this.statusCmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusCmb.ForeColor = System.Drawing.Color.Black;
            this.statusCmb.ItemHeight = 30;
            this.statusCmb.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Suspended"});
            this.statusCmb.Location = new System.Drawing.Point(245, 354);
            this.statusCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(150, 36);
            this.statusCmb.StartIndex = 0;
            this.statusCmb.TabIndex = 7;
            this.statusCmb.SelectedIndexChanged += new System.EventHandler(this.statusCmb_SelectedIndexChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.fullNameLabel.Location = new System.Drawing.Point(261, 13);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(69, 17);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.BorderRadius = 5;
            this.addressTextBox.BorderThickness = 2;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.Location = new System.Drawing.Point(21, 194);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PlaceholderText = "";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(442, 74);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.fullNameTxt.BorderRadius = 5;
            this.fullNameTxt.BorderThickness = 2;
            this.fullNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameTxt.DefaultText = "";
            this.fullNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameTxt.ForeColor = System.Drawing.Color.Black;
            this.fullNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTxt.Location = new System.Drawing.Point(245, 23);
            this.fullNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.PlaceholderText = "";
            this.fullNameTxt.SelectedText = "";
            this.fullNameTxt.Size = new System.Drawing.Size(218, 53);
            this.fullNameTxt.TabIndex = 2;
            this.fullNameTxt.TextChanged += new System.EventHandler(this.fullNameTxt_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.AutoRoundedCorners = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderRadius = 22;
            this.addBtn.BorderThickness = 1;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(337, 436);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(140, 46);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add User";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.roleLabel.Location = new System.Drawing.Point(37, 335);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(37, 17);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Role:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.userNameTextBox.BorderRadius = 5;
            this.userNameTextBox.BorderThickness = 2;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.DefaultText = "";
            this.userNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.Location = new System.Drawing.Point(20, 23);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PlaceholderText = "";
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.Size = new System.Drawing.Size(219, 53);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlUserImage
            // 
            this.pnlUserImage.Controls.Add(this.userImage);
            this.pnlUserImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserImage.Location = new System.Drawing.Point(10, 77);
            this.pnlUserImage.Name = "pnlUserImage";
            this.pnlUserImage.Size = new System.Drawing.Size(489, 165);
            this.pnlUserImage.TabIndex = 9;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.exitBtn);
            this.guna2Panel2.Controls.Add(this.headerLabel);
            this.guna2Panel2.Controls.Add(this.guna2Separator2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(10, 10);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Size = new System.Drawing.Size(489, 67);
            this.guna2Panel2.TabIndex = 10;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.roleCmb);
            this.guna2Panel3.Controls.Add(this.statusLabel);
            this.guna2Panel3.Controls.Add(this.addBtn);
            this.guna2Panel3.Controls.Add(this.clearBtn);
            this.guna2Panel3.Controls.Add(this.roleLabel);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.statusCmb);
            this.guna2Panel3.Controls.Add(this.phoneTxt);
            this.guna2Panel3.Controls.Add(this.guna2Separator1);
            this.guna2Panel3.Controls.Add(this.lblEmail);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.fullNameLabel);
            this.guna2Panel3.Controls.Add(this.addressLabel);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.userNameTextBox);
            this.guna2Panel3.Controls.Add(this.emaiTextBox);
            this.guna2Panel3.Controls.Add(this.addressTextBox);
            this.guna2Panel3.Controls.Add(this.fullNameTxt);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(10, 242);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(489, 495);
            this.guna2Panel3.TabIndex = 11;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 766);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlUserImage.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label headerLabel;
        private Guna.UI2.WinForms.Guna2ComboBox roleCmb;
        private Guna.UI2.WinForms.Guna2TextBox emaiTextBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addressLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2ComboBox statusCmb;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox fullNameTxt;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.Label roleLabel;
        private Guna.UI2.WinForms.Guna2TextBox userNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox phoneTxt;
        private Guna.UI2.WinForms.Guna2PictureBox userImage;
        private Guna.UI2.WinForms.Guna2Panel pnlUserImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}