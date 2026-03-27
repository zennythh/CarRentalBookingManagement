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
            this.bookingsConflictsMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.conflictFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.bookingDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
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
            this.panelMain.SuspendLayout();
            this.bookingsConflictsMainPanel.SuspendLayout();
            this.panelLoading.SuspendLayout();
            this.bookingDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.panelMain.Controls.Add(this.bookingsConflictsMainPanel);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.panelLoading);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.Location = new System.Drawing.Point(1, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1130, 546);
            this.panelMain.TabIndex = 42;
            // 
            // bookingsConflictsMainPanel
            // 
            this.bookingsConflictsMainPanel.Controls.Add(this.label1);
            this.bookingsConflictsMainPanel.Controls.Add(this.conflictFlowPanel);
            this.bookingsConflictsMainPanel.Location = new System.Drawing.Point(867, 89);
            this.bookingsConflictsMainPanel.Name = "bookingsConflictsMainPanel";
            this.bookingsConflictsMainPanel.Size = new System.Drawing.Size(230, 457);
            this.bookingsConflictsMainPanel.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Booking Conflicts";
            // 
            // conflictFlowPanel
            // 
            this.conflictFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conflictFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conflictFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.conflictFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.conflictFlowPanel.Location = new System.Drawing.Point(0, 42);
            this.conflictFlowPanel.Name = "conflictFlowPanel";
            this.conflictFlowPanel.Size = new System.Drawing.Size(230, 417);
            this.conflictFlowPanel.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(29, 55);
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
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Booking Information";
            // 
            // panelLoading
            // 
            this.panelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoading.Controls.Add(this.bookingDetailsPanel);
            this.panelLoading.Location = new System.Drawing.Point(0, 89);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(1130, 417);
            this.panelLoading.TabIndex = 41;
            // 
            // bookingDetailsPanel
            // 
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
            this.bookingDetailsPanel.Location = new System.Drawing.Point(30, 0);
            this.bookingDetailsPanel.Name = "bookingDetailsPanel";
            this.bookingDetailsPanel.Size = new System.Drawing.Size(838, 457);
            this.bookingDetailsPanel.TabIndex = 42;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(223, 397);
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
            this.lblPrice.Location = new System.Drawing.Point(164, 398);
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
            this.rentalDateEndDTP.Location = new System.Drawing.Point(182, 311);
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
            this.rentalDateStartDTP.Location = new System.Drawing.Point(182, 259);
            this.rentalDateStartDTP.Name = "rentalDateStartDTP";
            this.rentalDateStartDTP.Size = new System.Drawing.Size(231, 26);
            this.rentalDateStartDTP.TabIndex = 54;
            // 
            // lblRentalTimeValue
            // 
            this.lblRentalTimeValue.AutoSize = true;
            this.lblRentalTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalTimeValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTimeValue.Location = new System.Drawing.Point(242, 361);
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
            this.lblRentalTime.Location = new System.Drawing.Point(164, 361);
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
            this.lblRentalPeriod.Location = new System.Drawing.Point(42, 289);
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
            this.lblto.Location = new System.Drawing.Point(286, 288);
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
            this.lblDateofRequestValue.Location = new System.Drawing.Point(189, 217);
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
            this.lblDateOfRequest.Location = new System.Drawing.Point(42, 217);
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
            this.customerContactNumTextBox.Location = new System.Drawing.Point(312, 152);
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
            this.customerEmailTextBox.Location = new System.Drawing.Point(20, 152);
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
            this.lblCustomerInfo.Location = new System.Drawing.Point(3, 5);
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
            this.lastNameTextBox.Location = new System.Drawing.Point(159, 69);
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
            this.lblLastName.Location = new System.Drawing.Point(155, 40);
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
            this.customerLicenseTextBox.Location = new System.Drawing.Point(312, 69);
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
            this.lblCustomerLicense.Location = new System.Drawing.Point(308, 40);
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
            this.vehicleLicenseTextBox.Location = new System.Drawing.Point(635, 283);
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
            this.lblLicenseNum.Location = new System.Drawing.Point(631, 254);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(111, 19);
            this.lblLicenseNum.TabIndex = 37;
            this.lblLicenseNum.Text = "License Plate";
            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.vehiclePictureBox.Location = new System.Drawing.Point(469, 0);
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
            this.vehicleNameTextBox.Location = new System.Drawing.Point(469, 283);
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
            this.lblVehicleName.Location = new System.Drawing.Point(465, 254);
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
            this.firstNameTextBox.Location = new System.Drawing.Point(17, 69);
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
            this.lblFirstName.Location = new System.Drawing.Point(13, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 19);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First Name";
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
            this.bookingsConflictsMainPanel.ResumeLayout(false);
            this.bookingsConflictsMainPanel.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            this.bookingDetailsPanel.ResumeLayout(false);
            this.bookingDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
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
        private System.Windows.Forms.Label label1;
    }
}