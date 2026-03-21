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
    public partial class frmEdit : System.Windows.Forms.UserControl
    {
        public event EventHandler UserUpdated;
        public event EventHandler FormClosed;
        private readonly int _userId;
        private UserStatus _userStatus;
        private readonly userRepository _repository;
        private bool _isImageChanged;
        private bool _hasStartedInitialLoad;
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
            _hasStartedInitialLoad = false;
        }

        protected virtual void OnUserUpdated()
        {
            UserUpdated?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnFormClosed()
        {
            FormClosed?.Invoke(this, EventArgs.Empty);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void ToggleLoading(bool isLoading)
        {
            progressBar.Visible = isLoading;

            pnlMain.Enabled = !isLoading;
        }

        private async Task LoadUserInfoAsync()
        {
            ToggleLoading(true);
            pnlProgress.Visible = true;

            try
            {
                UserInfoDto user = await GetUserByIdAsync(_userId);


                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    OnFormClosed();
                    Parent?.Controls.Remove(this);
                    return;
                }
                BindUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user information:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                OnFormClosed();
                Parent?.Controls.Remove(this);
            }
            finally
            {
                ToggleLoading(false);
                pnlProgress.Visible = false;
            }
        }

        private async Task<UserInfoDto> GetUserByIdAsync(int userId)
        {
            const string query = @"
                                SELECT id, userName, fullName, gender, email, phoneNumber, address, role, status, imagePath
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
                        Gender = reader.IsDBNull(reader.GetOrdinal("gender")) ? null : reader.GetString("gender"),
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
            genderCmb.SelectedItem = user.Gender;
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

        private void frmEdit_Shown(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            OnFormClosed();
            Parent?.Controls.Remove(this);
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
                    Gender = genderCmb.SelectedItem.ToString(),
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

                    OnUserUpdated();
                    Parent?.Controls.Remove(this);
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
            
            if (_hasStartedInitialLoad)
            {
                return;
            }
            _hasStartedInitialLoad = true;
            BeginInvoke(new Action(async () => await LoadUserInfoAsync()));
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

        private async void btnResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleLoading(true);

                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to reset the password for '{txtUserName.Text}'?\n\nA temporary password will be generated and displayed.",
                    "Confirm Password Reset",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                {
                    ToggleLoading(false);
                    return;
                }

                var result = await _repository.ResetPasswordAsync(txtUserName.Text);

                if (result.Success)
                {
                    MessageBox.Show(
                        $"Password reset successfully!\n\nTemporary Password: {result.TemporaryPassword}\n\nThe user must change this password on their next login.",
                        "Password Reset",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show(
                        $"Failed to reset password: {result.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error resetting password:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                ToggleLoading(false);
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
