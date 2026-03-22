using PL_VehicleRental.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;

namespace ActivityLogs
{
    public partial class LogsForm : Form
    {
        // Pagination & filtering fields
        private List<AuditLog> allLogs = new List<AuditLog>();
        private List<AuditLog> filteredLogs = new List<AuditLog>();
        private int currentPage = 1;
        private int pageSize = 15;
        private int totalPages = 1;

        public LogsForm()
        {
            InitializeComponent();
        }

        #region DataGrid Styling
        private void DataGridStyle()
        {
            dgvLogs.Dock = DockStyle.Fill;
            dgvLogs.Margin = new Padding(0);
            dgvLogs.Padding = new Padding(0);

            dgvLogs.AutoGenerateColumns = true;
            dgvLogs.ReadOnly = true;
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.MultiSelect = false;

            dgvLogs.ScrollBars = ScrollBars.Both;

            // FIX: None para lumabas ang horizontal scrollbar
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvLogs.RowTemplate.Height = 30;

            dgvLogs.EnableHeadersVisualStyles = false;
            dgvLogs.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            dgvLogs.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvLogs.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            dgvLogs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            dgvLogs.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            dgvLogs.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvLogs.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvLogs.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(100, 181, 246);
            dgvLogs.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvLogs.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            dgvLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLogs.GridColor = System.Drawing.Color.LightGray;
            dgvLogs.RowHeadersVisible = false;

            // Tooltip — ipakita ang buong text kapag nag-hover
            dgvLogs.ShowCellToolTips = true;
        }
        #endregion

        #region Load Logs
        private async Task LoadLogs()
        {
            var service = new AuditService();
            allLogs = await service.GetAuditLogsAsync();

            filteredLogs = new List<AuditLog>(allLogs);
            totalPages = (int)Math.Ceiling((double)filteredLogs.Count / pageSize);
            currentPage = 1;

            LoadPage();
        }

        private void LoadPage()
        {
            if (filteredLogs.Count == 0)
            {
                dgvLogs.DataSource = null;
                lblPageInfo.Text = "No records found";
                btnPrev.Enabled = btnNext.Enabled = false;
                return;
            }

            var pagedData = filteredLogs
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvLogs.DataSource = pagedData;

            // FIX: Fixed width sa bawat column para lumabas ang horizontal scrollbar
            if (dgvLogs.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dgvLogs.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Width = 150;
                }
            }

            UpdatePaginationLabel();
        }

        private void UpdatePaginationLabel()
        {
            lblPageInfo.Text = $"Page {currentPage} of {totalPages}";
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }
        #endregion

        #region Form Events
        private async void LogsForm_Load(object sender, EventArgs e)
        {
            await LoadLogs();
        }

        private void LogsForm_Shown(object sender, EventArgs e)
        {
            DataGridStyle();
            CenterPagination();
        }

        // FIX: I-center ang pagination kapag nag-resize ang form
        private void LogsForm_Resize(object sender, EventArgs e)
        {
            CenterPagination();
        }

        private void CenterPagination()
        {
            pnlPagination.Left = (guna2Panel2.Width - pnlPagination.Width) / 2;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }
        #endregion

        #region Real-Time Search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim().ToLowerInvariant();

            if (string.IsNullOrEmpty(filter))
            {
                filteredLogs = new List<AuditLog>(allLogs);
            }
            else
            {
                filteredLogs = allLogs
                    .Where(log =>
                        log.UserId.ToString().Contains(filter) ||
                        (log.UserName?.ToLowerInvariant().Contains(filter) ?? false) ||
                        (log.ActionType?.ToLowerInvariant().Contains(filter) ?? false) ||
                        (log.Description?.ToLowerInvariant().Contains(filter) ?? false) ||
                        (log.TableAffected?.ToLowerInvariant().Contains(filter) ?? false) ||
                        log.CreatedAt.ToString().ToLowerInvariant().Contains(filter) ||
                        log.RecordId.ToString().Contains(filter) ||
                        (log.OldValues?.ToLowerInvariant().Contains(filter) ?? false) ||
                        (log.NewValues?.ToLowerInvariant().Contains(filter) ?? false)
                    )
                    .ToList();
            }

            currentPage = 1;
            totalPages = (int)Math.Ceiling((double)filteredLogs.Count / pageSize);
            LoadPage();
        }
        #endregion

        #region Tooltip — ipakita ang buong text kapag nag-hover sa cell
        private void dgvLogs_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var value = dgvLogs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrEmpty(value))
                    dgvLogs.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = value;
            }
        }
        #endregion

        #region Empty Event Handlers (keep intact)
        private void label3_Click(object sender, EventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void guna2Button1_Click(object sender, EventArgs e) { }
        private void guna2Button2_Click(object sender, EventArgs e) { }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dgvLogs_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void titlePanel_Paint(object sender, PaintEventArgs e) { }
        private void headerLabel_Click(object sender, EventArgs e) { }
        private void pnlPagination_Paint(object sender, PaintEventArgs e) { }
        private void FilterTxtBox_TextChanged(object sender, EventArgs e) { }
        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void guna2Panel7_Paint(object sender, PaintEventArgs e) { }
        private void guna2Panel1_Paint_2(object sender, PaintEventArgs e) { }
        private void guna2Panel1_Paint_3(object sender, PaintEventArgs e) { }
        private void lblPageInfo_Click(object sender, EventArgs e) { }
        #endregion
    }
}