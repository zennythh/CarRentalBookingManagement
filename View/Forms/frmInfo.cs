
using Guna.UI2.WinForms;
using MySqlConnector;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Forms
{
    public partial class frmInfo : Form
    {
        private readonly int _userId;
        private UserStatus _userStatus;
        public enum UserStatus
        {
            Active,
            Inactive,
            Suspended
        }

        public frmInfo(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ToggleLoading(bool isLoading)
        {
            progressBar.Visible = isLoading;

            pnlMain.Enabled = !isLoading;
        }

        private async Task LoadUserInfoAsync()
        {
            ToggleLoading(true);
            UserInfoDto user = await GetUserByIdAsync(_userId);

            if (user == null)
            {
                MessageBox.Show("User not found.");
                Close();
                return;
            }

            BindUser(user);
            ToggleLoading(false);
            pnlProgress.Visible = false;
        }

        private async Task<UserInfoDto> GetUserByIdAsync(int userId)
        {
            const string query = @"
                                SELECT id, userName, fullName, email, phoneNumber, address, role, status, imagePath
                                FROM users
                                WHERE id = @id";

            using (var conn = MySQLConnectionContext.Create())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
               await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (!await reader.ReadAsync()) 
                        return null;

                    string dbStatus = reader.GetString("status");
                    _userStatus = ParseStatus(dbStatus);

                    return new UserInfoDto
                    {
                        Id = reader.GetInt32("id"),
                        UserName = reader.GetString("userName"),
                        FullName = reader.GetString("fullName"),
                        Email = reader.GetString("email"),
                        PhoneNumber = reader.IsDBNull(reader.GetOrdinal("phoneNumber")) ? "N/A" : reader.GetString("phoneNumber"),
                        Address = reader.GetString("address"),
                        Status = dbStatus,
                        Role = reader.GetString("role"),
                        ImagePath = reader.IsDBNull(reader.GetOrdinal("imagePath"))
                        ? null
                        : reader.GetString("imagePath")
                    };
                }
            }
        }

        private void BindUser(UserInfoDto user)
        {
            lblUsername.Text = user.UserName;
            lblFullName.Text = user.FullName;
            lblEmail.Text = user.Email;
            lblPhone.Text = user.PhoneNumber;
            lblAddress.Text = user.Address;
            lblRole.Text = user.Role;
            lblStatus.Text = user.Status;

            if (userImage.Image != null && userImage.Image != VehicleManagementSystem.Properties.Resources.avatar_default)
                userImage.Image.Dispose();

            if (!string.IsNullOrWhiteSpace(user.ImagePath))
            {
                var service = new UserImageService();
                string fullPath = service.GetFullPath(user.ImagePath);

                if (File.Exists(fullPath))
                {
                    using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        userImage.Image = Image.FromStream(fs);
                    }
                    return;
                } 
                else
                {
                    userImage.Image = VehicleManagementSystem.Properties.Resources.avatar_default;
                }
            } 
            else
            {
                userImage.Image = VehicleManagementSystem.Properties.Resources.avatar_default;
            }
            
        }

        private Color GetStatusColor(UserStatus status)
        {
            switch (status)
            {
                case UserStatus.Active:
                    return Color.Green;

                case UserStatus.Inactive:
                    return Color.Goldenrod;

                case UserStatus.Suspended:
                    return Color.Red;

                default:
                    return Color.Black;
            }
        }

        private UserStatus ParseStatus(string dbStatus)
        {
            return Enum.TryParse(dbStatus, true, out UserStatus status) ? status : UserStatus.Inactive;
        }
        private void SetUserStatus(Label lblStatus, UserStatus status)
        {
            lblStatus.Text = status.ToString();
            lblStatus.ForeColor = GetStatusColor(status);
            lblStatus.Font = status == UserStatus.Suspended 
                ? new Font(lblStatus.Font, FontStyle.Bold)
                : new Font(lblStatus.Font, FontStyle.Regular);
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            userImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private async void frmInfo_Shown(object sender, EventArgs e)
        {
           await LoadUserInfoAsync();
            SetUserStatus(lblStatus, _userStatus);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
