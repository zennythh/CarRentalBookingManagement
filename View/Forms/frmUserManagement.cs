using VehicleManagementSystem.Classes;
using PL_VehicleRental.DAL.Repositories;
using VehicleManagementSystem.Data;
using PL_VehicleRental.Services.Security;
using PL_VehicleRental.UI.Layout;
using PL_VehicleRental.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Forms
{
    public partial class UserManagementForm : Form
    {
        private System.Windows.Forms.Timer _searchTimer;

        private int _currentPage = 1;
        private int _pageSize = 14;
        private int _totalPages = 1;
        private string currentSearch = "";

        private readonly userRepository _repository = new userRepository();
        private frmAddUser _addUserControl;
        private frmEdit _editUserControl;
        private Guna.UI2.WinForms.Guna2ComboBox cboPageSelect;
        public UserManagementForm()
        {
            InitializeComponent();
            InitializeSearchDebounce();
            InitializePageSelect();
            flowUsers.Resize += flowUsers_Resize;

            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.BackColor = Color.FromArgb(120, Color.White);
            pnlOverlay.Visible = false;
            progressBar.Anchor = AnchorStyles.None;

            //progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.None;
            //progressBar.Size = new Size(150, 10);
            progressBar.Location = new Point((pnlOverlay.Width - progressBar.Width) / 2,
                                             (pnlOverlay.Height - progressBar.Height) / 2);
            pnlOverlay.Controls.Add(progressBar);
        }

        private void InitializePageSelect()
        {
            cboPageSelect = new Guna.UI2.WinForms.Guna2ComboBox
            {
                Size = new Size(70, 30),
                BorderRadius = 2,
                Font = new Font("Segoe UI", 9F),
                Cursor = Cursors.Hand,
                DropDownHeight = 150,
                BorderColor = Color.FromArgb(213, 218, 223),
                ForeColor = Color.Black,
                TextAlign = HorizontalAlignment.Center
            };

            cboPageSelect.FocusedState.BorderColor = Color.FromArgb(42, 132, 191);
            cboPageSelect.SelectedIndexChanged += CboPageSelect_SelectedIndexChanged;
            pnlPagination.Controls.Add(cboPageSelect);
        }

        private async void CboPageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPageSelect.SelectedItem != null && int.TryParse(cboPageSelect.SelectedItem.ToString(), out int page))
            {
                if (page != _currentPage)
                {
                    _currentPage = page;
                    await LoadPageAsync();
                }
            }
        }

        private async Task LoadPageAsync()
        {
            ToggleLoading(true);

            var (users, totalCount) = await _repository.GetPagedUsersAsync(
                currentSearch,
                _currentPage,
                _pageSize,
                Session.User.Role.ToString());

            flowUsers.Controls.Clear();

            foreach (var user in users)
            {
                var item = new ucItemControl(user);

                flowUsers.Controls.Add(item);
                item.Width = flowUsers.ClientSize.Width;

                item.InfoClicked += (_, __) => OpenInfo(user.Id);
                item.EditClicked += (_, __) => OpenEditForm(user.Id);
                item.DeleteClicked += (_, __) => DeleteUser(user.Id, user.UserName);
            }

            _totalPages = (int)Math.Ceiling((double)totalCount / _pageSize);

            UpdatePageButtons();

            ToggleLoading(false);
        }

        private void UpdatePageButtons()
        {
            flowPageNumbers.Controls.Clear();

            int maxVisiblePages = 5;
            int startPage = Math.Max(1, _currentPage - maxVisiblePages / 2);
            int endPage = Math.Min(_totalPages, startPage + maxVisiblePages - 1);

            if (endPage - startPage + 1 < maxVisiblePages)
                startPage = Math.Max(1, endPage - maxVisiblePages + 1);

            for (int i = startPage; i <= endPage; i++)
            {
                var btn = new Guna.UI2.WinForms.Guna2Button
                {
                    Text = i.ToString(),
                    Size = new Size(30, 24),
                    BorderRadius = 2,
                    Font = new Font("Segoe UI", 9F),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(2),
                    Tag = i
                };

                if (i == _currentPage)
                {
                    btn.FillColor = Color.FromArgb(42, 132, 191);
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.FillColor = Color.FromArgb(230, 230, 230);
                    btn.ForeColor = Color.Black;
                }

                btn.Click += PageButton_Click;
                flowPageNumbers.Controls.Add(btn);
            }

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;

            cboPageSelect.SelectedIndexChanged -= CboPageSelect_SelectedIndexChanged;

            if (cboPageSelect.Items.Count != _totalPages)
            {
                cboPageSelect.Items.Clear();
                if (_totalPages > 0)
                {
                    for (int i = 1; i <= _totalPages; i++)
                    {
                        cboPageSelect.Items.Add(i.ToString());
                    }
                }
            }

            if (_currentPage > 0 && _currentPage <= cboPageSelect.Items.Count)
            {
                cboPageSelect.SelectedIndex = _currentPage - 1;
            }

            cboPageSelect.SelectedIndexChanged += CboPageSelect_SelectedIndexChanged;

            AlignPagination();
        }

        private void AlignPagination()
        {
            int spacing = 10;

            flowPageNumbers.PerformLayout();
            int totalWidth = btnPrev.Width + spacing + flowPageNumbers.Width + spacing + btnNext.Width + spacing + cboPageSelect.Width;

            pnlPagination.Width = totalWidth;

            int centerY = pnlPagination.Height / 2;
            int btnY = centerY - (btnPrev.Height / 2);
            int flowY = centerY - (flowPageNumbers.Height / 2);
            int comboY = centerY - (cboPageSelect.Height / 2);

            btnPrev.Location = new Point(0, btnY);
            flowPageNumbers.Location = new Point(btnPrev.Width + spacing, flowY);
            btnNext.Location = new Point(flowPageNumbers.Location.X + flowPageNumbers.Width + spacing, btnY);
            cboPageSelect.Location = new Point(btnNext.Location.X + btnNext.Width + spacing, comboY);
        }

        private async void PageButton_Click(object sender, EventArgs e)
        {
            var btn = (Guna.UI2.WinForms.Guna2Button)sender;
            int page = (int)btn.Tag;

            if (page != _currentPage)
            {
                _currentPage = page;
                await LoadPageAsync();
            }
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void UserManagementForm_Load(object sender, EventArgs e)
        {
            TableHeader();
            FixHeaderScrollbarAlignment();
            ApplyPermission();
            await LoadPageAsync();
        }

        private void UserManagementForm_Shown(object sender, EventArgs e)
        {

        }

        private void ToggleLoading(bool isLoading)
        {
            pnlOverlay.Visible = isLoading;
            if (isLoading)
            {
                pnlOverlay.BringToFront();
            } else
            {
                pnlOverlay.Visible = false;
            }
            
        }
        
        private void InitializeSearchDebounce()
        {
            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 400;
            _searchTimer.Tick += SearchTimer_Tick;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();

            currentSearch = txtSearch.Text.Trim();
            _currentPage = 1;

            await LoadPageAsync();
        }

        private void TableHeader()
        {
            TableHeaderPanel.SuspendLayout();
            TableHeaderPanel.Controls.Clear();

            TableHeaderPanel.Height = 45;
            TableHeaderPanel.Dock = DockStyle.Top;
            TableHeaderPanel.BackColor = Color.FromArgb(42, 132, 191);
            TableHeaderPanel.Padding = new Padding(0, 10, 0, 10);

            TableLayoutPanel headerLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 8,
                RowCount = 1,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Margin = Padding.Empty,
            };

            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.IdWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.UsernameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.FullnameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.EmailWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.RoleWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.StatusWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.ActionWidth));

            Label CreateHeader(string text)
            {
                return new Label
                {
                    Text = text,
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    Padding = new Padding(5, 0, 5, 0),
                    Margin = new Padding(0),
                    ForeColor = Color.White
                };
            }

            headerLayout.Controls.Add(CreateHeader("USER ID"), 0, 0);
            headerLayout.Controls.Add(CreateHeader("USERNAME"), 1, 0);
            headerLayout.Controls.Add(CreateHeader("FULLNAME"), 2, 0);
            headerLayout.Controls.Add(CreateHeader("EMAIL"), 3, 0);
            headerLayout.Controls.Add(CreateHeader("ADDRESS"), 4, 0);
            headerLayout.Controls.Add(CreateHeader("ROLE"), 5, 0);
            headerLayout.Controls.Add(CreateHeader("STATUS"), 6, 0);
            headerLayout.Controls.Add(CreateHeader("ACTION"), 7, 0);

            headerLayout.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, headerLayout.ClientRectangle,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid);
            };

            TableHeaderPanel.Controls.Add(headerLayout);
            TableHeaderPanel.ResumeLayout();
        }

        private void FixHeaderScrollbarAlignment()
        {
            int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
            TableHeaderPanel.Padding = new Padding(0, 0, scrollBarWidth, 0);
        }

        private void ApplyPermission()
        {
            var tip = new ToolTip();

            if (!AuthorizationService.HasPermission(Permission.AddUser))
            {
                tip.SetToolTip(btnUserForm, "You don't have permission to add user.");
                btnUserForm.Enabled = false;
            }
        }

        public void OpenInfo(int userId)
        {
            using (frmInfo frm = new frmInfo(userId))
            {
                frm.ShowDialog(this);
            }
        }

        private void OpenEditForm(int userId)
        {
            HideAddUserForm();

            if (_editUserControl != null )
            {
                UserManagementPanel.Controls.Remove(_editUserControl);
                _editUserControl.Dispose();
            }

            _editUserControl = new frmEdit(userId);
            _editUserControl.UserUpdated += async (sender, e) =>
            {
                HideEditUserForm();
                await LoadPageAsync();
            };

            _editUserControl.FormClosed += (sender, e) =>
            {
                HideEditUserForm();
            };
            RecenterOverlayControl(_editUserControl);
            UserManagementPanel.Controls.Add(_editUserControl);
            _editUserControl.BringToFront();

            SetUserListVisibility(false);
        }

        private async void DeleteUser(int userId, string userName)
        {
            var confirm = MessageBox.Show($"Are you sure you want to delete user '{userName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                ToggleLoading(true);

                if (!AuthorizationService.HasPermission(Permission.DeleteUser))
            {
                MessageBox.Show("Access Denied.");
                return;
            }

                bool success = await _repository.DeleteUserAsync(userId);

                if (success)
                {
                    MessageBox.Show("User deleted successfully.", 
                        "Success", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    await LoadPageAsync();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error deleting users\n" + ex.Message, 
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            } finally
            {
                ToggleLoading(false);
            }
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            OpenAddUserForm();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void OpenAddUserForm()
        {

            if (_addUserControl != null)
            {
                UserManagementPanel.Controls.Remove( _addUserControl);
                _addUserControl.Dispose();
            }

            _addUserControl = new frmAddUser();
            //_addUserControl.Dock = DockStyle.Fill;
            _addUserControl.UserAdded += async (sender, e) =>
            {
                HideAddUserForm();
                await LoadPageAsync();
            };

            _addUserControl.FormClosed += (sender, e) =>
            {
                HideAddUserForm();
            };

            RecenterOverlayControl(_addUserControl);

            UserManagementPanel.Controls.Add(_addUserControl);
            _addUserControl.BringToFront();

            SetUserListVisibility(false);
        }

        private void HideAddUserForm()
        {
            if (_addUserControl != null)
            {
                UserManagementPanel.Controls.Remove(_addUserControl);
                _addUserControl.Dispose();
                _addUserControl = null;
            }

            SetUserListVisibility(true);
        }

        private void HideEditUserForm()
        {
            if (_editUserControl != null)
            {
                UserManagementPanel.Controls.Remove(_editUserControl);
                _editUserControl.Dispose();
                _editUserControl = null;
            }

            SetUserListVisibility(true);
        }

        private void SetUserListVisibility(bool isVisible)
        {
            headerPanel.Visible = isVisible;
            TableHeaderPanel.Visible = isVisible;
            flowUsers.Visible = isVisible;
            rolesTablePanel.Visible = isVisible;
        }

        // Double buffer
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x115 || m.Msg == 0x114)
            {
                if ((m.WParam.ToInt32() & 0xFFFF) == 5)
                {
                    m.WParam = (IntPtr)((m.WParam.ToInt32() & ~0xFFFF) | 4);
                }
            }
            base.WndProc(ref m);
        }

        private void flowUsers_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowUsers.Controls)
            {
                if (c is ucItemControl itemControl)
                {
                    itemControl.Width = flowUsers.ClientSize.Width;
                    itemControl.UpdateWidth(flowUsers.ClientSize.Width);
                }
                else
                {
                    c.Width = flowUsers.ClientSize.Width;
                }
            }
        }

        private void progressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnPrev_Click(object sender, EventArgs e)
        { 
            if (_currentPage > 1)
            {
                _currentPage--;
                await LoadPageAsync();
            }
            
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                await LoadPageAsync();
            }
        }

        private void UserManagementForm_Resize(object sender, EventArgs e)
        {
            RecenterAddUserForm();
        }

        private void UserManagementPanel_Resize(object sender, EventArgs e)
        {
            RecenterAddUserForm();
        }

        private void RecenterAddUserForm()
        {
            RecenterOverlayControl(_addUserControl);
            RecenterOverlayControl(_editUserControl);
        }

        private void RecenterOverlayControl(Control overlayControl)
        {
            if (overlayControl != null && overlayControl.Visible)
            {
                int newX = (UserManagementPanel.Width - overlayControl.Width) / 2;
                int newY = (UserManagementPanel.Height - overlayControl.Height) / 2;


                newX = Math.Max(0, newX);
                newY = Math.Max(0, newY);

                overlayControl.Location = new Point(newX, newY);
            }
        }

        private void UserManagementForm_ResizeEnd(object sender, EventArgs e)
        {
            RecenterAddUserForm();
        }

        private void UserManagementForm_ResizeBegin(object sender, EventArgs e)
        {
            RecenterAddUserForm();
        }
    }
}