namespace VehicleManagementSystem.View.Modals {
    partial class RenewVehicleDocumentModal {
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.panelPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.closeImageBtn = new FontAwesome.Sharp.IconButton();
            this.panelFile = new Guna.UI2.WinForms.Guna2Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.documentPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.addImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDocumentTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIssuingAuthority = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDocumentType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelExtension = new System.Windows.Forms.Label();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputExpirationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnYear = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.panelFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.panelTop.TabIndex = 105;
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
            this.guna2Panel2.Size = new System.Drawing.Size(533, 4);
            this.guna2Panel2.TabIndex = 104;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.labelHeader.Location = new System.Drawing.Point(24, 17);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(263, 24);
            this.labelHeader.TabIndex = 104;
            this.labelHeader.Text = "Renewing the document of";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
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
            this.closeBtn.Location = new System.Drawing.Point(518, 11);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(43, 30);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.BorderRadius = 15;
            this.panelPreview.Controls.Add(this.closeImageBtn);
            this.panelPreview.Controls.Add(this.addImageBtn);
            this.panelPreview.Controls.Add(this.panelFile);
            this.panelPreview.Controls.Add(this.documentPictureBox);
            this.panelPreview.Location = new System.Drawing.Point(28, 367);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(520, 236);
            this.panelPreview.TabIndex = 145;
            // 
            // closeImageBtn
            // 
            this.closeImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeImageBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closeImageBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeImageBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.closeImageBtn.FlatAppearance.BorderSize = 2;
            this.closeImageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.closeImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeImageBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeImageBtn.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.closeImageBtn.IconColor = System.Drawing.Color.RosyBrown;
            this.closeImageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeImageBtn.IconSize = 28;
            this.closeImageBtn.Location = new System.Drawing.Point(469, 13);
            this.closeImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeImageBtn.Name = "closeImageBtn";
            this.closeImageBtn.Size = new System.Drawing.Size(37, 30);
            this.closeImageBtn.TabIndex = 115;
            this.closeImageBtn.UseVisualStyleBackColor = false;
            this.closeImageBtn.Visible = false;
            this.closeImageBtn.Click += new System.EventHandler(this.closeImageBtn_Click);
            // 
            // panelFile
            // 
            this.panelFile.BackColor = System.Drawing.Color.Transparent;
            this.panelFile.Controls.Add(this.labelFileName);
            this.panelFile.Controls.Add(this.guna2PictureBox1);
            this.panelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFile.FillColor = System.Drawing.SystemColors.Control;
            this.panelFile.Location = new System.Drawing.Point(0, 0);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(520, 236);
            this.panelFile.TabIndex = 125;
            this.panelFile.Visible = false;
            // 
            // labelFileName
            // 
            this.labelFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelFileName.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.ForeColor = System.Drawing.Color.Gray;
            this.labelFileName.Location = new System.Drawing.Point(57, 134);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(397, 54);
            this.labelFileName.TabIndex = 106;
            this.labelFileName.Text = "Document Type";
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::VehicleManagementSystem.Properties.Resources.document;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(217, 58);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(81, 73);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // documentPictureBox
            // 
            this.documentPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.documentPictureBox.BorderRadius = 15;
            this.documentPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentPictureBox.ImageRotate = 0F;
            this.documentPictureBox.Location = new System.Drawing.Point(0, 0);
            this.documentPictureBox.Name = "documentPictureBox";
            this.documentPictureBox.Size = new System.Drawing.Size(520, 236);
            this.documentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.documentPictureBox.TabIndex = 0;
            this.documentPictureBox.TabStop = false;
            this.documentPictureBox.Visible = false;
            // 
            // addImageBtn
            // 
            this.addImageBtn.BorderColor = System.Drawing.Color.Red;
            this.addImageBtn.BorderRadius = 10;
            this.addImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addImageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addImageBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.addImageBtn.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBtn.ForeColor = System.Drawing.Color.Gray;
            this.addImageBtn.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.addImageBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.addImageBtn.Location = new System.Drawing.Point(0, 0);
            this.addImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(520, 236);
            this.addImageBtn.TabIndex = 124;
            this.addImageBtn.Text = "Click here to add documents file.";
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
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
            this.saveBtn.Location = new System.Drawing.Point(333, 617);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(212, 44);
            this.saveBtn.TabIndex = 144;
            this.saveBtn.Text = "Renew Document";
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
            this.cancelBtn.Location = new System.Drawing.Point(207, 617);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 44);
            this.cancelBtn.TabIndex = 143;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.07692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.92308F));
            this.tableLayoutPanel1.Controls.Add(this.labelDocumentTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelIssuingAuthority, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDocumentType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelExtension, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelIssueDate, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 188);
            this.tableLayoutPanel1.TabIndex = 146;
            // 
            // labelDocumentTitle
            // 
            this.labelDocumentTitle.AutoEllipsis = true;
            this.labelDocumentTitle.AutoSize = true;
            this.labelDocumentTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDocumentTitle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumentTitle.Location = new System.Drawing.Point(174, 37);
            this.labelDocumentTitle.Name = "labelDocumentTitle";
            this.labelDocumentTitle.Size = new System.Drawing.Size(343, 37);
            this.labelDocumentTitle.TabIndex = 133;
            this.labelDocumentTitle.Text = "label6";
            this.labelDocumentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(3, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 127;
            this.label5.Text = "Document TItle :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIssuingAuthority
            // 
            this.labelIssuingAuthority.AutoEllipsis = true;
            this.labelIssuingAuthority.AutoSize = true;
            this.labelIssuingAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIssuingAuthority.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuingAuthority.Location = new System.Drawing.Point(174, 111);
            this.labelIssuingAuthority.Name = "labelIssuingAuthority";
            this.labelIssuingAuthority.Size = new System.Drawing.Size(343, 37);
            this.labelIssuingAuthority.TabIndex = 134;
            this.labelIssuingAuthority.Text = "label7";
            this.labelIssuingAuthority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 129;
            this.label2.Text = "Issuing Authority :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 130;
            this.label10.Text = "Document Type :";
            // 
            // labelDocumentType
            // 
            this.labelDocumentType.AutoEllipsis = true;
            this.labelDocumentType.AutoSize = true;
            this.labelDocumentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDocumentType.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumentType.Location = new System.Drawing.Point(174, 0);
            this.labelDocumentType.Name = "labelDocumentType";
            this.labelDocumentType.Size = new System.Drawing.Size(343, 37);
            this.labelDocumentType.TabIndex = 132;
            this.labelDocumentType.Text = "label4";
            this.labelDocumentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 136;
            this.label4.Text = "Extension :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 131;
            this.label1.Text = "Issue Date :";
            // 
            // labelExtension
            // 
            this.labelExtension.AutoEllipsis = true;
            this.labelExtension.AutoSize = true;
            this.labelExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExtension.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtension.Location = new System.Drawing.Point(174, 74);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(343, 37);
            this.labelExtension.TabIndex = 137;
            this.labelExtension.Text = "label8";
            this.labelExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoEllipsis = true;
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIssueDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssueDate.Location = new System.Drawing.Point(174, 148);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(343, 40);
            this.labelIssueDate.TabIndex = 135;
            this.labelIssueDate.Text = "label8";
            this.labelIssueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(31, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 147;
            this.label3.Text = "New Expiration Date";
            // 
            // inputExpirationDate
            // 
            this.inputExpirationDate.BackColor = System.Drawing.Color.White;
            this.inputExpirationDate.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.inputExpirationDate.BorderRadius = 10;
            this.inputExpirationDate.BorderThickness = 6;
            this.inputExpirationDate.Checked = true;
            this.inputExpirationDate.FillColor = System.Drawing.Color.White;
            this.inputExpirationDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inputExpirationDate.Location = new System.Drawing.Point(35, 305);
            this.inputExpirationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputExpirationDate.MaxDate = new System.DateTime(2030, 6, 12, 0, 0, 0, 0);
            this.inputExpirationDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.inputExpirationDate.Name = "inputExpirationDate";
            this.inputExpirationDate.Size = new System.Drawing.Size(218, 44);
            this.inputExpirationDate.TabIndex = 148;
            this.inputExpirationDate.Value = new System.DateTime(2026, 1, 20, 18, 53, 53, 702);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(259, 305);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(81, 44);
            this.guna2Button1.TabIndex = 149;
            this.guna2Button1.Text = "+1 day";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonth.BorderColor = System.Drawing.Color.Silver;
            this.btnMonth.BorderRadius = 10;
            this.btnMonth.BorderThickness = 3;
            this.btnMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonth.FillColor = System.Drawing.Color.Transparent;
            this.btnMonth.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMonth.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMonth.Location = new System.Drawing.Point(346, 305);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(107, 44);
            this.btnMonth.TabIndex = 150;
            this.btnMonth.Text = "+1 month";
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnYear
            // 
            this.btnYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYear.BorderColor = System.Drawing.Color.Silver;
            this.btnYear.BorderRadius = 10;
            this.btnYear.BorderThickness = 3;
            this.btnYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYear.FillColor = System.Drawing.Color.Transparent;
            this.btnYear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.ForeColor = System.Drawing.Color.DarkGray;
            this.btnYear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnYear.Location = new System.Drawing.Point(459, 305);
            this.btnYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(89, 44);
            this.btnYear.TabIndex = 151;
            this.btnYear.Text = "+1 year";
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // RenewVehicleDocumentModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 679);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.inputExpirationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenewVehicleDocumentModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenewVehicleDocumentModal";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelPreview.ResumeLayout(false);
            this.panelFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private FontAwesome.Sharp.IconButton closeBtn;
        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelPreview;
        private FontAwesome.Sharp.IconButton closeImageBtn;
        private Guna.UI2.WinForms.Guna2Panel panelFile;
        private System.Windows.Forms.Label labelFileName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox documentPictureBox;
        private Guna.UI2.WinForms.Guna2Button addImageBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDocumentTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIssuingAuthority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelDocumentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker inputExpirationDate;
        private Guna.UI2.WinForms.Guna2Button btnYear;
        private Guna.UI2.WinForms.Guna2Button btnMonth;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}