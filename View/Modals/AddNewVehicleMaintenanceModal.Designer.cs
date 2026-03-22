namespace VehicleManagementSystem.View.Modals {
    partial class AddNewVehicleMaintenanceModal {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.inputType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMilleageInterval = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputMonthlyInterval = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLastServiceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panelPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.maintenanceCardControl = new VehicleManagementSystem.UserControls.MaintenanceCardControl();
            this.label6 = new System.Windows.Forms.Label();
            this.inputScheduleType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelIntervalSettings = new Guna.UI2.WinForms.Guna2Panel();
            this.panelDueSettings = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inputDueMileige = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.panelIntervalSettings.SuspendLayout();
            this.panelDueSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.guna2Panel2);
            this.panelTop.Controls.Add(this.closeBtn);
            this.panelTop.Controls.Add(this.labelHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(577, 71);
            this.panelTop.TabIndex = 103;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.guna2Panel2.Location = new System.Drawing.Point(28, 52);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(468, 4);
            this.guna2Panel2.TabIndex = 104;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 28;
            this.closeBtn.Location = new System.Drawing.Point(517, 11);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 40);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.labelHeader.Location = new System.Drawing.Point(24, 17);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(248, 24);
            this.labelHeader.TabIndex = 104;
            this.labelHeader.Text = "Adding New Maintenance";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // inputType
            // 
            this.inputType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputType.BackColor = System.Drawing.Color.Transparent;
            this.inputType.BorderRadius = 10;
            this.inputType.BorderThickness = 2;
            this.inputType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.inputType.IntegralHeight = false;
            this.inputType.ItemHeight = 44;
            this.inputType.Location = new System.Drawing.Point(297, 101);
            this.inputType.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(241, 50);
            this.inputType.TabIndex = 104;
            this.inputType.SelectedIndexChanged += new System.EventHandler(this.cmbMaintenanceTask_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label10.Location = new System.Drawing.Point(293, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 23);
            this.label10.TabIndex = 105;
            this.label10.Text = "Maintenance Type*";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::VehicleManagementSystem.Properties.Resources.save_icon;
            this.saveBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.saveBtn.Location = new System.Drawing.Point(337, 683);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(204, 44);
            this.saveBtn.TabIndex = 117;
            this.saveBtn.Text = "Save Schedule";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BorderColor = System.Drawing.Color.Silver;
            this.cancelBtn.BorderRadius = 10;
            this.cancelBtn.BorderThickness = 3;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancelBtn.Location = new System.Drawing.Point(226, 683);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 44);
            this.cancelBtn.TabIndex = 116;
            this.cancelBtn.Text = "Cancel";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(293, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 144;
            this.label3.Text = "Monthly Interval";
            // 
            // inputMilleageInterval
            // 
            this.inputMilleageInterval.BorderRadius = 10;
            this.inputMilleageInterval.BorderThickness = 2;
            this.inputMilleageInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputMilleageInterval.DefaultText = "";
            this.inputMilleageInterval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputMilleageInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputMilleageInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputMilleageInterval.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputMilleageInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputMilleageInterval.Font = new System.Drawing.Font("Arial", 16F);
            this.inputMilleageInterval.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputMilleageInterval.Location = new System.Drawing.Point(31, 66);
            this.inputMilleageInterval.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inputMilleageInterval.Name = "inputMilleageInterval";
            this.inputMilleageInterval.PlaceholderText = "";
            this.inputMilleageInterval.SelectedText = "";
            this.inputMilleageInterval.Size = new System.Drawing.Size(241, 44);
            this.inputMilleageInterval.TabIndex = 143;
            this.inputMilleageInterval.TextChanged += new System.EventHandler(this.PreviewCard_Load);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 142;
            this.label1.Text = "Milleage Interval (Km)";
            // 
            // inputMonthlyInterval
            // 
            this.inputMonthlyInterval.BorderRadius = 10;
            this.inputMonthlyInterval.BorderThickness = 2;
            this.inputMonthlyInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputMonthlyInterval.DefaultText = "";
            this.inputMonthlyInterval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputMonthlyInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputMonthlyInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputMonthlyInterval.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputMonthlyInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputMonthlyInterval.Font = new System.Drawing.Font("Arial", 16F);
            this.inputMonthlyInterval.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputMonthlyInterval.Location = new System.Drawing.Point(297, 66);
            this.inputMonthlyInterval.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inputMonthlyInterval.Name = "inputMonthlyInterval";
            this.inputMonthlyInterval.PlaceholderText = "";
            this.inputMonthlyInterval.SelectedText = "";
            this.inputMonthlyInterval.Size = new System.Drawing.Size(241, 44);
            this.inputMonthlyInterval.TabIndex = 146;
            this.inputMonthlyInterval.TextChanged += new System.EventHandler(this.PreviewCard_Load);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(24, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 147;
            this.label2.Text = "Interval Settings";
            // 
            // inputLastServiceDate
            // 
            this.inputLastServiceDate.BackColor = System.Drawing.Color.White;
            this.inputLastServiceDate.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.inputLastServiceDate.BorderRadius = 10;
            this.inputLastServiceDate.BorderThickness = 6;
            this.inputLastServiceDate.Checked = true;
            this.inputLastServiceDate.FillColor = System.Drawing.Color.White;
            this.inputLastServiceDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLastServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inputLastServiceDate.Location = new System.Drawing.Point(31, 159);
            this.inputLastServiceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputLastServiceDate.MaxDate = new System.DateTime(2219, 7, 15, 0, 0, 0, 0);
            this.inputLastServiceDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.inputLastServiceDate.Name = "inputLastServiceDate";
            this.inputLastServiceDate.Size = new System.Drawing.Size(244, 44);
            this.inputLastServiceDate.TabIndex = 150;
            this.inputLastServiceDate.Value = new System.DateTime(2026, 1, 20, 18, 53, 53, 702);
            this.inputLastServiceDate.TextChanged += new System.EventHandler(this.PreviewCard_Load);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(27, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 151;
            this.label5.Text = "Last Service Date*";
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.Transparent;
            this.panelPreview.BorderRadius = 15;
            this.panelPreview.Controls.Add(this.maintenanceCardControl);
            this.panelPreview.FillColor = System.Drawing.SystemColors.Control;
            this.panelPreview.Location = new System.Drawing.Point(34, 431);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(507, 236);
            this.panelPreview.TabIndex = 152;
            // 
            // maintenanceCardControl
            // 
            this.maintenanceCardControl.BackColor = System.Drawing.Color.Transparent;
            this.maintenanceCardControl.Location = new System.Drawing.Point(20, 12);
            this.maintenanceCardControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maintenanceCardControl.Name = "maintenanceCardControl";
            this.maintenanceCardControl.Size = new System.Drawing.Size(466, 208);
            this.maintenanceCardControl.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(30, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 153;
            this.label6.Text = "Live Preview";
            // 
            // inputScheduleType
            // 
            this.inputScheduleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputScheduleType.BackColor = System.Drawing.Color.Transparent;
            this.inputScheduleType.BorderRadius = 10;
            this.inputScheduleType.BorderThickness = 2;
            this.inputScheduleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inputScheduleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputScheduleType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputScheduleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputScheduleType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputScheduleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.inputScheduleType.IntegralHeight = false;
            this.inputScheduleType.ItemHeight = 44;
            this.inputScheduleType.Location = new System.Drawing.Point(28, 101);
            this.inputScheduleType.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.inputScheduleType.Name = "inputScheduleType";
            this.inputScheduleType.Size = new System.Drawing.Size(241, 50);
            this.inputScheduleType.TabIndex = 154;
            this.inputScheduleType.SelectedIndexChanged += new System.EventHandler(this.inputScheduleType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(24, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 155;
            this.label7.Text = "Schedule Type*";
            // 
            // panelIntervalSettings
            // 
            this.panelIntervalSettings.Controls.Add(this.label2);
            this.panelIntervalSettings.Controls.Add(this.label1);
            this.panelIntervalSettings.Controls.Add(this.inputMilleageInterval);
            this.panelIntervalSettings.Controls.Add(this.label3);
            this.panelIntervalSettings.Controls.Add(this.inputLastServiceDate);
            this.panelIntervalSettings.Controls.Add(this.inputMonthlyInterval);
            this.panelIntervalSettings.Controls.Add(this.label5);
            this.panelIntervalSettings.Location = new System.Drawing.Point(3, 172);
            this.panelIntervalSettings.Name = "panelIntervalSettings";
            this.panelIntervalSettings.Size = new System.Drawing.Size(577, 230);
            this.panelIntervalSettings.TabIndex = 156;
            // 
            // panelDueSettings
            // 
            this.panelDueSettings.Controls.Add(this.label8);
            this.panelDueSettings.Controls.Add(this.label9);
            this.panelDueSettings.Controls.Add(this.inputDueMileige);
            this.panelDueSettings.Controls.Add(this.inputDueDate);
            this.panelDueSettings.Controls.Add(this.label12);
            this.panelDueSettings.Location = new System.Drawing.Point(0, 172);
            this.panelDueSettings.Name = "panelDueSettings";
            this.panelDueSettings.Size = new System.Drawing.Size(577, 134);
            this.panelDueSettings.TabIndex = 157;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.label8.Location = new System.Drawing.Point(24, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 147;
            this.label8.Text = "Due Settings";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(24, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 142;
            this.label9.Text = "Due after (Km)";
            // 
            // inputDueMileige
            // 
            this.inputDueMileige.BorderRadius = 10;
            this.inputDueMileige.BorderThickness = 2;
            this.inputDueMileige.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputDueMileige.DefaultText = "";
            this.inputDueMileige.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputDueMileige.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputDueMileige.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDueMileige.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDueMileige.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDueMileige.Font = new System.Drawing.Font("Arial", 16F);
            this.inputDueMileige.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDueMileige.Location = new System.Drawing.Point(31, 66);
            this.inputDueMileige.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inputDueMileige.Name = "inputDueMileige";
            this.inputDueMileige.PlaceholderText = "";
            this.inputDueMileige.SelectedText = "";
            this.inputDueMileige.Size = new System.Drawing.Size(241, 44);
            this.inputDueMileige.TabIndex = 143;
            // 
            // inputDueDate
            // 
            this.inputDueDate.BackColor = System.Drawing.Color.White;
            this.inputDueDate.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.inputDueDate.BorderRadius = 10;
            this.inputDueDate.BorderThickness = 6;
            this.inputDueDate.Checked = true;
            this.inputDueDate.FillColor = System.Drawing.Color.White;
            this.inputDueDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inputDueDate.Location = new System.Drawing.Point(297, 61);
            this.inputDueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDueDate.MaxDate = new System.DateTime(2219, 7, 15, 0, 0, 0, 0);
            this.inputDueDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.inputDueDate.Name = "inputDueDate";
            this.inputDueDate.Size = new System.Drawing.Size(244, 44);
            this.inputDueDate.TabIndex = 150;
            this.inputDueDate.Value = new System.DateTime(2026, 1, 20, 18, 53, 53, 702);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label12.Location = new System.Drawing.Point(293, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 23);
            this.label12.TabIndex = 151;
            this.label12.Text = "Due Date*";
            // 
            // AddNewVehicleMaintenanceModal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 751);
            this.ControlBox = false;
            this.Controls.Add(this.panelIntervalSettings);
            this.Controls.Add(this.panelDueSettings);
            this.Controls.Add(this.inputScheduleType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewVehicleMaintenanceModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewVehicleDocumentModal";
            this.Load += new System.EventHandler(this.AddNewVehicleMaintenanceModal_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelPreview.ResumeLayout(false);
            this.panelIntervalSettings.ResumeLayout(false);
            this.panelIntervalSettings.PerformLayout();
            this.panelDueSettings.ResumeLayout(false);
            this.panelDueSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton closeBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox inputType;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox inputMilleageInterval;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox inputMonthlyInterval;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker inputLastServiceDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel panelPreview;
        private System.Windows.Forms.Label label6;
        private UserControls.MaintenanceCardControl maintenanceCardControl;
        private Guna.UI2.WinForms.Guna2ComboBox inputScheduleType;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel panelIntervalSettings;
        private Guna.UI2.WinForms.Guna2Panel panelDueSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox inputDueMileige;
        private Guna.UI2.WinForms.Guna2DateTimePicker inputDueDate;
        private System.Windows.Forms.Label label12;
    }
}