using MySqlConnector;
using PL_VehicleRental.DAL.Repositories;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Helpers;
using PL_VehicleRental.Services.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Forms
{
    public partial class frmEdit : Form
    {
        private readonly int _userId;
        private UserStatus _userStatus;
        private readonly userRepository _repository;
        private bool _isImageChanged;
        private const long MaxFileSize = 2 * 1024 * 1024;
        public enum UserStatus
        {
            Active,
            Inactive,
            Suspended
        }
        public frmEdit(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _repository = new userRepository();
            _isImageChanged = false;
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
                        PhoneNumber = reader.IsDBNull(reader.GetOrdinal("phoneNumber")) ? null : reader.GetString("phoneNumber"),
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
            roleCmb.Items.Clear();

            roleCmb.Items.AddRange(new object[]
            {
                "Superadmin",
                "Admin",
                "Staff",
                "Mechanic"
            });

            statusCmb.Items.Clear();

            statusCmb.Items.AddRange(new object[]
            {
                "Active",
                "Inactive",
                "Suspended"
            });

            txtUserName.Text = user.UserName;
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
            txtAddress.Text = user.Address;
            txtPhone.Text = user.PhoneNumber;
            roleCmb.SelectedItem = user.Role;
            statusCmb.SelectedItem = user.Status;

            if (userImage.Image != null &&
                userImage.Image != VehicleManagementSystem.Properties.Resources.avatar_default)
                userImage.Image.Dispose();

            var service = new UserImageService();

            if (!string.IsNullOrWhiteSpace(user.ImagePath))
            {
                string fullPath = service.GetFullPath(user.ImagePath);

                if (File.Exists(fullPath))
                {
                    using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        userImage.Image = Image.FromStream(fs);
                    }
                    return;
                }
            }
            userImage.Image = VehicleManagementSystem.Properties.Resources.avatar_default;
        }

        private UserStatus ParseStatus(string dbStatus)
        {
            return Enum.TryParse(dbStatus, true, out UserStatus status) ? status : UserStatus.Inactive;
        }

        private async void frmEdit_Shown(object sender, EventArgs e)
        {
            await LoadUserInfoAsync();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleLoading(true);

                if (!AuthorizationService.HasPermission(Permission.EditUser))
                {
                    MessageBox.Show("Access Denied.");
                    return;
                }

                var user = new UserInfoDto
                {
                    Id = _userId,
                    UserName = txtUserName.Text,
                    FullName = txtFullName.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhone.Text,
                    Address = txtAddress.Text,
                    Role = roleCmb.SelectedItem.ToString(),
                    Status = statusCmb.SelectedItem.ToString(),
                    isImageChanged = _isImageChanged
                };

                bool success = await _repository.UpdateUserAsync(user, userImage.Image);

                if (success)
                {
                    MessageBox.Show(
                        "User updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                } else
                {
                    MessageBox.Show("No changes were made.",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user:\n" + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            } finally
            {
                ToggleLoading(false);
            }
        }

        private void userImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(ofd.FileName);

                    if (fileInfo.Length > MaxFileSize)
                    {
                        MessageBox.Show("Image is too large. Maximum allowed size is 2MB.",
                                 "File Too Large",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                        return;
                    }

                    Image img = Image.FromFile(ofd.FileName);

                    if(img.Width > 3000 || img.Height > 3000)
                    {
                        MessageBox.Show("Image resolution is too high. Max 3000x3000 allowed.",
                                "Image Too Large",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                       
                        return;
                    }

                    userImage.Image = Image.FromFile(ofd.FileName);
                    _isImageChanged = true;
                }
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            userImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void resetImg_Click(object sender, EventArgs e)
        {
            userImage.Image = VehicleManagementSystem.Properties.Resources.avatar_default;
        }

        private void txtPhone_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = "+63";
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!txtPhone.Text.StartsWith("+63"))
            {
                txtPhone.Text = "+63";
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
