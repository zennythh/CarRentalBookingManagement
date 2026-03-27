namespace VehicleManagementSystem.View.Forms
{
    partial class frmPendingBooking
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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.bookingDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.rejectBtn = new FontAwesome.Sharp.IconButton();
            this.approveBtn = new FontAwesome.Sharp.IconButton();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rentalDateEndDTP = new System.Windows.Forms.DateTimePicker();
            this.rentalDateStartDTP = new System.Windows.Forms.DateTimePicker();
            this.lblRentalTimeValue = new System.Windows.Forms.Label();
            this.lblRentalTime = new System.Windows.Forms.Label();
            this.lblRentalPeriod = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.lblDateofRequestValue = new System.Windows.Forms.Label();
            this.lblDateOfRequest = new System.Windows.Forms.Label();
            this.customerContactNumTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerContactNum = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.customerLicenseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerLicense = new System.Windows.Forms.Label();
            this.vehicleLicenseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.vehicleNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblBookingIDValue = new System.Windows.Forms.Label();
            this.bookingsConflictsMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoBookingConflicts = new System.Windows.Forms.Label();
            this.lblBookingConflicts = new System.Windows.Forms.Label();
            this.conflictFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMain.SuspendLayout();
            this.bookingDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
            this.bookingsConflictsMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.bookingDetailsPanel);
            this.panelMain.Controls.Add(this.backBtn);
            this.panelMain.Controls.Add(this.lblBookingIDValue);
            this.panelMain.Controls.Add(this.bookingsConflictsMainPanel);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.panelLoading);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1132, 546);
            this.panelMain.TabIndex = 42;
            // 
            // bookingDetailsPanel
            // 
            this.bookingDetailsPanel.Controls.Add(this.rejectBtn);
            this.bookingDetailsPanel.Controls.Add(this.approveBtn);
            this.bookingDetailsPanel.Controls.Add(this.lblPriceValue);
            this.bookingDetailsPanel.Controls.Add(this.lblPrice);
            this.bookingDetailsPanel.Controls.Add(this.rentalDateEndDTP);
            this.bookingDetailsPanel.Controls.Add(this.rentalDateStartDTP);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalTimeValue);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalTime);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalPeriod);
            this.bookingDetailsPanel.Controls.Add(this.lblto);
            this.bookingDetailsPanel.Controls.Add(this.lblDateofRequestValue);
            this.bookingDetailsPanel.Controls.Add(this.lblDateOfRequest);
            this.bookingDetailsPanel.Controls.Add(this.customerContactNumTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerContactNum);
            this.bookingDetailsPanel.Controls.Add(this.customerEmailTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerEmail);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerInfo);
            this.bookingDetailsPanel.Controls.Add(this.lastNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblLastName);
            this.bookingDetailsPanel.Controls.Add(this.customerLicenseTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerLicense);
            this.bookingDetailsPanel.Controls.Add(this.vehicleLicenseTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblLicenseNum);
            this.bookingDetailsPanel.Controls.Add(this.vehiclePictureBox);
            this.bookingDetailsPanel.Controls.Add(this.vehicleNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblVehicleName);
            this.bookingDetailsPanel.Controls.Add(this.firstNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblFirstName);
            this.bookingDetailsPanel.Location = new System.Drawing.Point(42, 89);
            this.bookingDetailsPanel.Name = "bookingDetailsPanel";
            this.bookingDetailsPanel.Size = new System.Drawing.Size(834, 457);
            this.bookingDetailsPanel.TabIndex = 42;
            // 
            // rejectBtn
            // 
            this.rejectBtn.BackColor = System.Drawing.Color.Tomato;
            this.rejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectBtn.ForeColor = System.Drawing.Color.Black;
            this.rejectBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.rejectBtn.IconColor = System.Drawing.Color.Black;
            this.rejectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rejectBtn.IconSize = 40;
            this.rejectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rejectBtn.Location = new System.Drawing.Point(629, 365);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(177, 56);
            this.rejectBtn.TabIndex = 59;
            this.rejectBtn.Text = " Reject";
            this.rejectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rejectBtn.UseVisualStyleBackColor = false;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // approveBtn
            // 
            this.approveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveBtn.ForeColor = System.Drawing.Color.Black;
            this.approveBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.approveBtn.IconColor = System.Drawing.Color.Black;
            this.approveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.approveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.approveBtn.Location = new System.Drawing.Point(427, 365);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(177, 56);
            this.approveBtn.TabIndex = 58;
            this.approveBtn.Text = "Approve";
            this.approveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.approveBtn.UseVisualStyleBackColor = false;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(244, 396);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(53, 20);
            this.lblPriceValue.TabIndex = 57;
            this.lblPriceValue.Text = "P20002";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(185, 397);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 19);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.Text = "Price:";
            // 
            // rentalDateEndDTP
            // 
            this.rentalDateEndDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateEndDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.rentalDateEndDTP.CustomFormat = "MMMMdd, yyyy hh:mm tt";
            this.rentalDateEndDTP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateEndDTP.Location = new System.Drawing.Point(203, 315);
            this.rentalDateEndDTP.Name = "rentalDateEndDTP";
            this.rentalDateEndDTP.Size = new System.Drawing.Size(231, 26);
            this.rentalDateEndDTP.TabIndex = 55;
            // 
            // rentalDateStartDTP
            // 
            this.rentalDateStartDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateStartDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.rentalDateStartDTP.CustomFormat = "MMMMdd, yyyy hh:mm tt";
            this.rentalDateStartDTP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateStartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateStartDTP.Location = new System.Drawing.Point(203, 263);
            this.rentalDateStartDTP.Name = "rentalDateStartDTP";
            this.rentalDateStartDTP.Size = new System.Drawing.Size(231, 26);
            this.rentalDateStartDTP.TabIndex = 54;
            // 
            // lblRentalTimeValue
            // 
            this.lblRentalTimeValue.AutoSize = true;
            this.lblRentalTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalTimeValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTimeValue.Location = new System.Drawing.Point(263, 365);
            this.lblRentalTimeValue.Name = "lblRentalTimeValue";
            this.lblRentalTimeValue.Size = new System.Drawing.Size(90, 20);
            this.lblRentalTimeValue.TabIndex = 53;
            this.lblRentalTimeValue.Text = "0 day 2 hours";
            // 
            // lblRentalTime
            // 
            this.lblRentalTime.AutoSize = true;
            this.lblRentalTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTime.Location = new System.Drawing.Point(185, 365);
            this.lblRentalTime.Name = "lblRentalTime";
            this.lblRentalTime.Size = new System.Drawing.Size(81, 19);
            this.lblRentalTime.TabIndex = 52;
            this.lblRentalTime.Text = "Duration:";
            // 
            // lblRentalPeriod
            // 
            this.lblRentalPeriod.AutoSize = true;
            this.lblRentalPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalPeriod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPeriod.Location = new System.Drawing.Point(63, 293);
            this.lblRentalPeriod.Name = "lblRentalPeriod";
            this.lblRentalPeriod.Size = new System.Drawing.Size(112, 19);
            this.lblRentalPeriod.TabIndex = 51;
            this.lblRentalPeriod.Text = "Rental Period";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.Transparent;
            this.lblto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(307, 292);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(20, 20);
            this.lblto.TabIndex = 50;
            this.lblto.Text = "to";
            // 
            // lblDateofRequestValue
            // 
            this.lblDateofRequestValue.AutoSize = true;
            this.lblDateofRequestValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDateofRequestValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofRequestValue.Location = new System.Drawing.Point(210, 221);
            this.lblDateofRequestValue.Name = "lblDateofRequestValue";
            this.lblDateofRequestValue.Size = new System.Drawing.Size(165, 20);
            this.lblDateofRequestValue.TabIndex = 49;
            this.lblDateofRequestValue.Text = "March  27, 2026 02:02 AM";
            // 
            // lblDateOfRequest
            // 
            this.lblDateOfRequest.AutoSize = true;
            this.lblDateOfRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfRequest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfRequest.Location = new System.Drawing.Point(63, 221);
            this.lblDateOfRequest.Name = "lblDateOfRequest";
            this.lblDateOfRequest.Size = new System.Drawing.Size(141, 19);
            this.lblDateOfRequest.TabIndex = 48;
            this.lblDateOfRequest.Text = "Date of Request: ";
            // 
            // customerContactNumTextBox
            // 
            this.customerContactNumTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerContactNumTextBox.DefaultText = "";
            this.customerContactNumTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerContactNumTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerContactNumTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerContactNumTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerContactNumTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerContactNumTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerContactNumTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerContactNumTextBox.Location = new System.Drawing.Point(333, 156);
            this.customerContactNumTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.customerContactNumTextBox.Multiline = true;
            this.customerContactNumTextBox.Name = "customerContactNumTextBox";
            this.customerContactNumTextBox.PlaceholderText = "";
            this.customerContactNumTextBox.SelectedText = "";
            this.customerContactNumTextBox.Size = new System.Drawing.Size(117, 29);
            this.customerContactNumTextBox.TabIndex = 47;
            // 
            // lblCustomerContactNum
            // 
            this.lblCustomerContactNum.AutoSize = true;
            this.lblCustomerContactNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerContactNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerContactNum.Location = new System.Drawing.Point(308, 123);
            this.lblCustomerContactNum.Name = "lblCustomerContactNum";
            this.lblCustomerContactNum.Size = new System.Drawing.Size(134, 19);
            this.lblCustomerContactNum.TabIndex = 46;
            this.lblCustomerContactNum.Text = "Contact Number";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerEmailTextBox.DefaultText = "";
            this.customerEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerEmailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerEmailTextBox.Location = new System.Drawing.Point(41, 156);
            this.customerEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.customerEmailTextBox.Multiline = true;
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.PlaceholderText = "";
            this.customerEmailTextBox.SelectedText = "";
            this.customerEmailTextBox.Size = new System.Drawing.Size(225, 29);
            this.customerEmailTextBox.TabIndex = 45;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(16, 123);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(118, 19);
            this.lblCustomerEmail.TabIndex = 44;
            this.lblCustomerEmail.Text = "Email Address";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(24, 9);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(141, 22);
            this.lblCustomerInfo.TabIndex = 43;
            this.lblCustomerInfo.Text = "Customer Info";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "fs";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(180, 73);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(117, 29);
            this.lastNameTextBox.TabIndex = 42;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(176, 44);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 19);
            this.lblLastName.TabIndex = 41;
            this.lblLastName.Text = "Last Name";
            // 
            // customerLicenseTextBox
            // 
            this.customerLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerLicenseTextBox.DefaultText = "";
            this.customerLicenseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerLicenseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerLicenseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerLicenseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerLicenseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerLicenseTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLicenseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerLicenseTextBox.Location = new System.Drawing.Point(333, 73);
            this.customerLicenseTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.customerLicenseTextBox.Multiline = true;
            this.customerLicenseTextBox.Name = "customerLicenseTextBox";
            this.customerLicenseTextBox.PlaceholderText = "";
            this.customerLicenseTextBox.SelectedText = "";
            this.customerLicenseTextBox.Size = new System.Drawing.Size(117, 29);
            this.customerLicenseTextBox.TabIndex = 40;
            // 
            // lblCustomerLicense
            // 
            this.lblCustomerLicense.AutoSize = true;
            this.lblCustomerLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerLicense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLicense.Location = new System.Drawing.Point(329, 44);
            this.lblCustomerLicense.Name = "lblCustomerLicense";
            this.lblCustomerLicense.Size = new System.Drawing.Size(134, 19);
            this.lblCustomerLicense.TabIndex = 39;
            this.lblCustomerLicense.Text = "License Number";
            // 
            // vehicleLicenseTextBox
            // 
            this.vehicleLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleLicenseTextBox.DefaultText = "";
            this.vehicleLicenseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleLicenseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleLicenseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleLicenseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleLicenseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleLicenseTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLicenseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleLicenseTextBox.Location = new System.Drawing.Point(656, 287);
            this.vehicleLicenseTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.vehicleLicenseTextBox.Multiline = true;
            this.vehicleLicenseTextBox.Name = "vehicleLicenseTextBox";
            this.vehicleLicenseTextBox.PlaceholderText = "";
            this.vehicleLicenseTextBox.ReadOnly = true;
            this.vehicleLicenseTextBox.SelectedText = "";
            this.vehicleLicenseTextBox.Size = new System.Drawing.Size(150, 29);
            this.vehicleLicenseTextBox.TabIndex = 38;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseNum.Location = new System.Drawing.Point(652, 258);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(111, 19);
            this.lblLicenseNum.TabIndex = 37;
            this.lblLicenseNum.Text = "License Plate";
            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.vehiclePictureBox.Location = new System.Drawing.Point(490, 0);
            this.vehiclePictureBox.Name = "vehiclePictureBox";
            this.vehiclePictureBox.Size = new System.Drawing.Size(316, 215);
            this.vehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vehiclePictureBox.TabIndex = 36;
            this.vehiclePictureBox.TabStop = false;
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleNameTextBox.DefaultText = "";
            this.vehicleNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNameTextBox.Location = new System.Drawing.Point(490, 287);
            this.vehicleNameTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.vehicleNameTextBox.Multiline = true;
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.PlaceholderText = "";
            this.vehicleNameTextBox.ReadOnly = true;
            this.vehicleNameTextBox.SelectedText = "";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(150, 29);
            this.vehicleNameTextBox.TabIndex = 35;
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleName.Location = new System.Drawing.Point(486, 258);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(64, 19);
            this.lblVehicleName.TabIndex = 34;
            this.lblVehicleName.Text = "Vehicle";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(38, 73);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(117, 29);
            this.firstNameTextBox.TabIndex = 33;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(34, 44);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 19);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First Name";
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
            this.backBtn.Location = new System.Drawing.Point(16, 21);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backBtn.Size = new System.Drawing.Size(38, 34);
            this.backBtn.TabIndex = 44;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblBookingIDValue
            // 
            this.lblBookingIDValue.AutoSize = true;
            this.lblBookingIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingIDValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBookingIDValue.Location = new System.Drawing.Point(212, 21);
            this.lblBookingIDValue.Name = "lblBookingIDValue";
            this.lblBookingIDValue.Size = new System.Drawing.Size(117, 29);
            this.lblBookingIDValue.TabIndex = 43;
            this.lblBookingIDValue.Text = "67676767";
            // 
            // bookingsConflictsMainPanel
            // 
            this.bookingsConflictsMainPanel.Controls.Add(this.lblNoBookingConflicts);
            this.bookingsConflictsMainPanel.Controls.Add(this.lblBookingConflicts);
            this.bookingsConflictsMainPanel.Controls.Add(this.conflictFlowPanel);
            this.bookingsConflictsMainPanel.Location = new System.Drawing.Point(874, 89);
            this.bookingsConflictsMainPanel.Name = "bookingsConflictsMainPanel";
            this.bookingsConflictsMainPanel.Size = new System.Drawing.Size(230, 457);
            this.bookingsConflictsMainPanel.TabIndex = 42;
            // 
            // lblNoBookingConflicts
            // 
            this.lblNoBookingConflicts.AutoSize = true;
            this.lblNoBookingConflicts.BackColor = System.Drawing.Color.Transparent;
            this.lblNoBookingConflicts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBookingConflicts.ForeColor = System.Drawing.Color.Green;
            this.lblNoBookingConflicts.Location = new System.Drawing.Point(3, 9);
            this.lblNoBookingConflicts.Name = "lblNoBookingConflicts";
            this.lblNoBookingConflicts.Size = new System.Drawing.Size(210, 22);
            this.lblNoBookingConflicts.TabIndex = 45;
            this.lblNoBookingConflicts.Text = "No Booking Conflicts.";
            // 
            // lblBookingConflicts
            // 
            this.lblBookingConflicts.AutoSize = true;
            this.lblBookingConflicts.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingConflicts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingConflicts.Location = new System.Drawing.Point(26, 7);
            this.lblBookingConflicts.Name = "lblBookingConflicts";
            this.lblBookingConflicts.Size = new System.Drawing.Size(175, 22);
            this.lblBookingConflicts.TabIndex = 44;
            this.lblBookingConflicts.Text = "Booking Conflicts";
            // 
            // conflictFlowPanel
            // 
            this.conflictFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conflictFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.conflictFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.conflictFlowPanel.Location = new System.Drawing.Point(0, 42);
            this.conflictFlowPanel.Name = "conflictFlowPanel";
            this.conflictFlowPanel.Size = new System.Drawing.Size(230, 415);
            this.conflictFlowPanel.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(73, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Review pending bookings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(69, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Booking ID:";
            // 
            // panelLoading
            // 
            this.panelLoading.Location = new System.Drawing.Point(0, 89);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(1130, 394);
            this.panelLoading.TabIndex = 41;
            // 
            // frmPendingBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 546);
            this.Controls.Add(this.panelMain);
            this.Name = "frmPendingBooking";
            this.Text = "frmPendingBooking";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.bookingDetailsPanel.ResumeLayout(false);
            this.bookingDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
            this.bookingsConflictsMainPanel.ResumeLayout(false);
            this.bookingsConflictsMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel conflictFlowPanel;
        private Guna.UI2.WinForms.Guna2Panel panelLoading;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel bookingDetailsPanel;
        private System.Windows.Forms.Label lblDateofRequestValue;
        private System.Windows.Forms.Label lblDateOfRequest;
        private Guna.UI2.WinForms.Guna2TextBox customerContactNumTextBox;
        private System.Windows.Forms.Label lblCustomerContactNum;
        private Guna.UI2.WinForms.Guna2TextBox customerEmailTextBox;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerInfo;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox customerLicenseTextBox;
        private System.Windows.Forms.Label lblCustomerLicense;
        private Guna.UI2.WinForms.Guna2TextBox vehicleLicenseTextBox;
        private System.Windows.Forms.Label lblLicenseNum;
        private System.Windows.Forms.PictureBox vehiclePictureBox;
        private Guna.UI2.WinForms.Guna2TextBox vehicleNameTextBox;
        private System.Windows.Forms.Label lblVehicleName;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DateTimePicker rentalDateEndDTP;
        private System.Windows.Forms.DateTimePicker rentalDateStartDTP;
        private System.Windows.Forms.Label lblRentalTimeValue;
        private System.Windows.Forms.Label lblRentalTime;
        private System.Windows.Forms.Label lblRentalPeriod;
        private System.Windows.Forms.Label lblto;
        private Guna.UI2.WinForms.Guna2Panel bookingsConflictsMainPanel;
        private System.Windows.Forms.Label lblBookingConflicts;
        private System.Windows.Forms.Label lblBookingIDValue;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Label lblNoBookingConflicts;
        private FontAwesome.Sharp.IconButton rejectBtn;
        private FontAwesome.Sharp.IconButton approveBtn;
    }
}