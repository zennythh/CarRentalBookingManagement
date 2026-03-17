
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
        private int _pageSize = 10;
        private int _totalPages = 1;
        private string currentSearch = "";

        private readonly userRepository _repository = new userRepository();


        public UserManagementForm()
        {
            InitializeComponent();
            InitializeSearchDebounce();
            flowUsers.Resize += flowUsers_Resize;

            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.BackColor = Color.FromArgb(120, Color.White);
            pnlOverlay.Visible = false;
            progressBar.Anchor = AnchorStyles.None;

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.None;
            progressBar.Size = new Size(150, 10);
            progressBar.Location = new Point((pnlOverlay.Width - progressBar.Width) / 2,
                                             (pnlOverlay.Height - progressBar.Height) / 2);
            pnlOverlay.Controls.Add(progressBar);
        }

        private async Task LoadPageAsync()
        {
            ToggleLoading(true);

            var (users, totalCount) = await _repository.GetPagedUsersAsync(
                currentSearch,
                _currentPage,
                _pageSize);

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

            lblPageInfo.Text = $"Page {_currentPage} of {_totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;

            ToggleLoading(false);
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

        private async void OpenEditForm(int userId)
        {
            using (frmEdit form = new frmEdit(userId))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    await LoadPageAsync();
                }
            }
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
            using (frmAddUser form = new frmAddUser())
            {
                form.UserAdded += async (sender, e) =>
                {
                    await LoadPageAsync();
                };

                form.FormBorderStyle = FormBorderStyle.None;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
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

        private void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
        }

        private void UserManagementForm_Resize(object sender, EventArgs e)
        {
        }

        private void rolesTablePanel_Resize(object sender, EventArgs e)
        {
        }

        private void pnlOverlay_Resize(object sender, EventArgs e)
        {
            
        }
    }
}