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
using PL_VehicleRental.Services;
using PL_VehicleRental.Validation;
using System.Text.RegularExpressions;
using Guna.UI2.WinForms;

namespace PL_VehicleRental.Forms
{
    public partial class frmEdit : System.Windows.Forms.UserControl
    {
        public event EventHandler UserUpdated;
        public event EventHandler FormClosed;
        private readonly int _userId;
        private UserStatus _userStatus;
        private readonly userRepository _repository;
        private readonly Validator _validator;
        private bool _isSubmitting;
        private readonly UserService _userService;
        private bool _isImageChanged;
        private bool _hasStartedInitialLoad;
        private bool _isBindingData;
        private const long MaxFileSize = 2 * 1024 * 1024;
        
        private string _originalUserName;
        private string _originalFullName;
        private string _originalGender;
        private string _originalEmail;
        private string _originalPhoneNumber;
        private string _originalAddress;
        private string _originalRole;
        private string _originalStatus;
        
        public enum UserStatus
        {
            Active,
            Inactive,
            Suspended
        }
        public frmEdit(int userId)
        {
            InitializeComponent();
            _validator = new Validator();
            _userService = new UserService();
            _userId = userId;
            _repository = new userRepository();
            _isImageChanged = false;
            _hasStartedInitialLoad = false;

            ConfigureValidation();
            UpdateAddButtonState();
        }

        private void ConfigureValidation()
        {
            _validator.Required(txtUserName, "Username is required.", lblUsernameError);
            _validator.Custom(txtUserName, () => txtUserName.Text.Trim().Length >= 5, "Username must be at least 5 characters.", lblUsernameError);
            _validator.Custom(txtUserName, () => Regex.IsMatch(txtUserName.Text.Trim(), @"^[a-zA-Z0-9]+$"), "Username can only contain letters and numbers.", lblUsernameError);
            _validator.Custom(txtFullName, () => txtFullName.Text.Trim().Length >= 5, "Name must be atleast 5 characters.", lblFullNameError);
            _validator.Custom(txtFullName, () => Regex.IsMatch(txtFullName.Text.Trim(), @"^[a-zA-Z\s\-']+$"), "Invalid character.", lblFullNameError);
            _validator.Custom(txtAddress, () => Regex.IsMatch(txtAddress.Text.Trim(), @"^[a-zA-Z0-9\s.,'#-]+$"), "Invalid character.", lblAddressError);

            _validator.Required(txtFullName, "Full name is required.", lblFullNameError);
            _validator.Required(txtEmail, "Email is required.", lblEmailError);
            _validator.IsEmail(txtEmail, "Invalid email format.", lblEmailError);
            _validator.Required(txtPhone, "Phone number is required.", lblPhoneError);
            _validator.IsPhoneNumber(txtPhone, "Phone number must be +639 followed by 9 digits.", lblPhoneError);
            _validator.Required(txtAddress, "Address is required.", lblAddressError);
        }

        private bool IsUsernameInputValid()
        {
            string username = txtUserName.Text.Trim();
            return !string.IsNullOrWhiteSpace(username) && username.Length >= 5 && Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
        }

        private bool IsFullNameInputValid()
        {
            string fullName = txtFullName.Text.Trim();
            return !string.IsNullOrWhiteSpace(fullName) && fullName.Length >= 5 && Regex.IsMatch(fullName, @"^[a-zA-Z\s\-']+$");
        }

        private bool IsEmailInputValid()
        {
            string email = txtEmail.Text.Trim();
            return !string.IsNullOrWhiteSpace(email)
                && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsAddressInputValid()
        {
            string address = txtAddress.Text.Trim();
            return !string.IsNullOrWhiteSpace(address)
                && Regex.IsMatch(address, @"^[a-zA-Z0-9\s.,'#-]+$");
        }

        private bool IsPhoneInputValid()
        {
            string text = txtPhone.Text.Trim();
            if (text.StartsWith("+63"))
            {
                text = text.Substring(3);
            }
            return text.Length == 10 && Regex.IsMatch(text, @"^\d{10}$");
        }


        private bool HasUserDataChanged()
        {
            return txtUserName.Text != _originalUserName ||
                   txtFullName.Text != _originalFullName ||
                   genderCmb.SelectedItem?.ToString() != _originalGender ||
                   txtEmail.Text != _originalEmail ||
                   txtPhone.Text != _originalPhoneNumber ||
                   txtAddress.Text != _originalAddress ||
                   roleCmb.SelectedItem?.ToString() != _originalRole ||
                   statusCmb.SelectedItem?.ToString() != _originalStatus ||
                   _isImageChanged;
        }

        private void UpdateAddButtonState()
        {
            if (_isBindingData) return;

            bool basicValid =
                IsUsernameInputValid() &&
                IsFullNameInputValid() &&
                IsEmailInputValid() &&
                IsPhoneInputValid() &&
                IsAddressInputValid() &&
                genderCmb.SelectedIndex != -1 &&
                roleCmb.SelectedIndex != -1 &&
                statusCmb.SelectedIndex != -1;

            bool hasChanges = HasUserDataChanged();

            btnSave.Enabled = basicValid && hasChanges;
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
            _isBindingData = true;

            roleCmb.Items.Clear();

            roleCmb.Items.AddRange(new object[]
            {
                "Superadmin",
                "Admin",
                "Staff",
                "Mechanic",
                "HR",
                "Finance"
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

            _originalUserName = user.UserName;
            _originalFullName = user.FullName;
            _originalGender = user.Gender;
            _originalEmail = user.Email;
            _originalPhoneNumber = user.PhoneNumber;
            _originalAddress = user.Address;
            _originalRole = user.Role;
            _originalStatus = user.Status;
            _isImageChanged = false;

            _isBindingData = false;
            UpdateAddButtonState();

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
            if (_isSubmitting) return;

            btnSave.Enabled = false;

            try
            {
                _isSubmitting = true;
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
                    await AuditService.LogAsync(new AuditLog
                    {
                        UserId = Session.User.Id,
                        ActionType = "UPDATE",
                        Description = $"Updated user account: {user.UserName}",
                        TableAffected = "users",
                        RecordId = user.Id
                    });

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
                _isSubmitting = false;
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
                    UpdateAddButtonState();
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
            _isImageChanged = false;
            UpdateAddButtonState();
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
            _validator.ValidateControl(txtPhone);
            UpdateAddButtonState();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = "+63";
                txtPhone.SelectionStart = txtPhone.Text.Length;
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
                    MessageBoxIcon.Warning);

                if (confirmResult != DialogResult.Yes)
                {
                    ToggleLoading(false);
                    return;
                }

                var result = await _repository.ResetPasswordAsync(txtUserName.Text);

                if (result.Success)
                {
                    await AuditService.LogAsync(new AuditLog
                    {
                        UserId = Session.User.Id,
                        ActionType = "UPDATE",
                        Description = $"Password reset for user account: {txtUserName.Text}",
                        TableAffected = "users",
                        RecordId = result.UserId
                    });

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
            if (!_validator.ValidateControl(txtUserName))
            {
                UpdateAddButtonState();
                return;
            }
            UpdateAddButtonState();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtFullName.SelectionStart;
            string text = txtFullName.Text;

            if (!string.IsNullOrEmpty(text) && cursorPosition > 0)
            {
                string capitalizedText = char.ToUpper(text[0]) + text.Substring(1).ToLower();

                if(capitalizedText != text)
                {
                    txtFullName.Text = capitalizedText;
                    txtFullName.SelectionStart = cursorPosition;
                }
            }

            _validator.ValidateControl(txtFullName);
            UpdateAddButtonState();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!_validator.ValidateControl(txtEmail))
            {
                UpdateAddButtonState();
                return;
            }
            UpdateAddButtonState();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            _validator.ValidateControl(txtAddress);
            UpdateAddButtonState();
        }

        private void roleCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void genderCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
    }
}
