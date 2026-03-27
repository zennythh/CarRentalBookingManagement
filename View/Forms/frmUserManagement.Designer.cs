using System.Drawing;
using System.Windows.Forms;

namespace PL_VehicleRental.Forms
{
    partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.UserManagementPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.flowUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.TableHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUserForm = new Guna.UI2.WinForms.Guna2Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pnlOverlay = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.rolesTablePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPagination = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPagination = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.flowPageNumbers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.BackgroundPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.pnlOverlay.SuspendLayout();
            this.rolesTablePanel.SuspendLayout();
            this.tableLayoutPagination.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.BorderColor = System.Drawing.Color.Gray;
            this.BackgroundPanel.BorderRadius = 5;
            this.BackgroundPanel.BorderThickness = 1;
            this.BackgroundPanel.Controls.Add(this.UserManagementPanel);
            this.BackgroundPanel.Location = new System.Drawing.Point(9, 10);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(992, 626);
            this.BackgroundPanel.TabIndex = 0;
            this.BackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // UserManagementPanel
            // 
            this.UserManagementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserManagementPanel.AutoScroll = true;
            this.UserManagementPanel.BorderColor = System.Drawing.Color.Transparent;
            this.UserManagementPanel.Controls.Add(this.flowUsers);
            this.UserManagementPanel.Controls.Add(this.lblNoResults);
            this.UserManagementPanel.Controls.Add(this.TableHeaderPanel);
            this.UserManagementPanel.Controls.Add(this.headerPanel);
            this.UserManagementPanel.Controls.Add(this.pnlOverlay);
            this.UserManagementPanel.Controls.Add(this.rolesTablePanel);
            this.UserManagementPanel.Location = new System.Drawing.Point(10, 12);
            this.UserManagementPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UserManagementPanel.Name = "UserManagementPanel";
            this.UserManagementPanel.Padding = new System.Windows.Forms.Padding(8);
            this.UserManagementPanel.Size = new System.Drawing.Size(970, 601);
            this.UserManagementPanel.TabIndex = 0;
            this.UserManagementPanel.Resize += new System.EventHandler(this.UserManagementPanel_Resize);
            // 
            // flowUsers
            // 
            this.flowUsers.AutoScroll = true;
            this.flowUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUsers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowUsers.Location = new System.Drawing.Point(8, 170);
            this.flowUsers.Margin = new System.Windows.Forms.Padding(2);
            this.flowUsers.Name = "flowUsers";
            this.flowUsers.Size = new System.Drawing.Size(954, 371);
            this.flowUsers.TabIndex = 1;
            this.flowUsers.WrapContents = false;
            this.flowUsers.Resize += new System.EventHandler(this.flowUsers_Resize);
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoResults.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.ForeColor = System.Drawing.Color.Gray;
            this.lblNoResults.Location = new System.Drawing.Point(8, 170);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(0, 25);
            this.lblNoResults.TabIndex = 0;
            this.lblNoResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableHeaderPanel
            // 
            this.TableHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableHeaderPanel.Location = new System.Drawing.Point(8, 89);
            this.TableHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TableHeaderPanel.Name = "TableHeaderPanel";
            this.TableHeaderPanel.Size = new System.Drawing.Size(954, 81);
            this.TableHeaderPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.BorderColor = System.Drawing.Color.Silver;
            this.headerPanel.BorderRadius = 10;
            this.headerPanel.BorderThickness = 2;
            this.headerPanel.Controls.Add(this.cmbFilter);
            this.headerPanel.Controls.Add(this.txtSearch);
            this.headerPanel.Controls.Add(this.btnUserForm);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.CustomizableEdges.BottomLeft = false;
            this.headerPanel.CustomizableEdges.BottomRight = false;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.headerPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.headerPanel.Location = new System.Drawing.Point(8, 8);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(954, 81);
            this.headerPanel.TabIndex = 1;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Location = new System.Drawing.Point(636, 24);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(140, 36);
            this.cmbFilter.TabIndex = 5;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.txtSearch.IconLeft = global::VehicleManagementSystem.Properties.Resources.searchIcon;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.Location = new System.Drawing.Point(430, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search user...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 36);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUserForm
            // 
            this.btnUserForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnUserForm.BorderRadius = 5;
            this.btnUserForm.BorderThickness = 2;
            this.btnUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.btnUserForm.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserForm.ForeColor = System.Drawing.Color.White;
            this.btnUserForm.Image = ((System.Drawing.Image)(resources.GetObject("btnUserForm.Image")));
            this.btnUserForm.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUserForm.Location = new System.Drawing.Point(781, 23);
            this.btnUserForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(152, 37);
            this.btnUserForm.TabIndex = 2;
            this.btnUserForm.Text = "Add User";
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(22, 23);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(250, 32);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "User Management";
            // 
            // pnlOverlay
            // 
            this.pnlOverlay.Controls.Add(this.progressBar);
            this.pnlOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverlay.Location = new System.Drawing.Point(8, 8);
            this.pnlOverlay.Name = "pnlOverlay";
            this.pnlOverlay.Size = new System.Drawing.Size(954, 533);
            this.pnlOverlay.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Animated = true;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressBar.FillThickness = 8;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.progressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressBar.ProgressThickness = 8;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.Size = new System.Drawing.Size(49, 49);
            this.progressBar.TabIndex = 0;
            this.progressBar.Text = "guna2CircleProgressBar1";
            this.progressBar.Value = 75;
            // 
            // rolesTablePanel
            // 
            this.rolesTablePanel.Controls.Add(this.tableLayoutPagination);
            this.rolesTablePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rolesTablePanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesTablePanel.Location = new System.Drawing.Point(8, 541);
            this.rolesTablePanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.rolesTablePanel.Name = "rolesTablePanel";
            this.rolesTablePanel.Padding = new System.Windows.Forms.Padding(8);
            this.rolesTablePanel.Size = new System.Drawing.Size(954, 52);
            this.rolesTablePanel.TabIndex = 1;
            // 
            // tableLayoutPagination
            // 
            this.tableLayoutPagination.ColumnCount = 3;
            this.tableLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPagination.Controls.Add(this.pnlPagination, 1, 0);
            this.tableLayoutPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPagination.Location = new System.Drawing.Point(8, -8);
            this.tableLayoutPagination.Name = "tableLayoutPagination";
            this.tableLayoutPagination.RowCount = 1;
            this.tableLayoutPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPagination.Size = new System.Drawing.Size(938, 52);
            this.tableLayoutPagination.TabIndex = 4;
            // 
            // pnlPagination
            // 
            this.pnlPagination.Controls.Add(this.btnPrev);
            this.pnlPagination.Controls.Add(this.flowPageNumbers);
            this.pnlPagination.Controls.Add(this.btnNext);
            this.pnlPagination.Location = new System.Drawing.Point(344, 3);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(250, 46);
            this.pnlPagination.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.BorderRadius = 2;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(17, 11);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(34, 24);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // flowPageNumbers
            // 
            this.flowPageNumbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPageNumbers.AutoSize = true;
            this.flowPageNumbers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPageNumbers.Location = new System.Drawing.Point(56, 11);
            this.flowPageNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.flowPageNumbers.Name = "flowPageNumbers";
            this.flowPageNumbers.Size = new System.Drawing.Size(0, 0);
            this.flowPageNumbers.TabIndex = 1;
            this.flowPageNumbers.WrapContents = false;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 2;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::VehicleManagementSystem.Properties.Resources.chevron_right;
            this.btnNext.Location = new System.Drawing.Point(195, 11);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 24);
            this.btnNext.TabIndex = 2;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 652);
            this.Controls.Add(this.BackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.Shown += new System.EventHandler(this.UserManagementForm_Shown);
            this.Resize += new System.EventHandler(this.UserManagementForm_Resize);
            this.BackgroundPanel.ResumeLayout(false);
            this.UserManagementPanel.ResumeLayout(false);
            this.UserManagementPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.pnlOverlay.ResumeLayout(false);
            this.rolesTablePanel.ResumeLayout(false);
            this.tableLayoutPagination.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel UserManagementPanel;
        private Guna.UI2.WinForms.Guna2Panel rolesTablePanel;
        private Guna.UI2.WinForms.Guna2GradientPanel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private Guna.UI2.WinForms.Guna2Button btnUserForm;
        private System.Windows.Forms.FlowLayoutPanel flowUsers;
        private Guna.UI2.WinForms.Guna2Panel TableHeaderPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlOverlay;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        //private Label lblPageInfo;
        private TableLayoutPanel tableLayoutPagination;
        private FlowLayoutPanel flowPageNumbers;
        private Guna.UI2.WinForms.Guna2Panel pnlPagination;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private Label lblNoResults;
    }
}