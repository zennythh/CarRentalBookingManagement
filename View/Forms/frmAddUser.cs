using MySqlConnector;
using PL_VehicleRental.DAL.Repositories;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Helpers;
using PL_VehicleRental.Services;
using PL_VehicleRental.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using Guna.UI2.WinForms;

namespace PL_VehicleRental.Forms
{
    public partial class frmAddUser : System.Windows.Forms.UserControl
    {
        public event EventHandler UserAdded;
        public event EventHandler FormClosed;
        private Validator _validator;
        private UserService _userService;
        private readonly userRepository _repository = new userRepository();
        private readonly int _userId;
        private CancellationTokenSource _usernameCts;
        private bool _isUsernameAvailable = false;
        private bool _isSubmitting = false;
        private const long MaxFileSize = 2 * 1024 * 1024;
        private ToolTip _asyncToolTip;
        public frmAddUser()
        {
            InitializeComponent();
            _validator = new Validator();
            _userService = new UserService();
            _asyncToolTip = new ToolTip();
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
        }

        private void ClearFields()
        {
            fullNameTxt.Clear();
            userNameTextBox.Clear();
            emaiTextBox.Clear();
            phoneTxt.Clear();
            addressTextBox.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
            userImage.Image = null;

            _validator.Clear();

        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (_isSubmitting) return;
            addBtn.Enabled = false;

            try
            {
                _isSubmitting = true;
                _validator.Clear();

                _validator.Required(userNameTextBox, "Username is required");
                _validator.Required(fullNameTxt, "Full name is required");
                _validator.Required(addressTextBox, "Address is required");
                _validator.IsEmail(emaiTextBox, "Invalid email format");
                _validator.IsPhoneNumber(phoneTxt, "Invalid phone number.");

                _validator.Custom(phoneTxt, () =>
                {
                    return phoneTxt.Text.Length == 13 && phoneTxt.Text.StartsWith("+639");
                }, "Phone number must be +639 followed by 9 digits.");

                _validator.Custom(userNameTextBox, () => userNameTextBox.Text.Length >= 5, "Username must be at least 5 characters");
                _validator.Custom(userNameTextBox, () => Regex.IsMatch(userNameTextBox.Text, @"^[a-zA-Z0-9]+$"), "Username can only contain letters and numbers.");

                if (!_validator.Validate() || !_isUsernameAvailable)
                {
                    if (_validator.Validate() && !_isUsernameAvailable)
                    {
                        SetAsyncError(userNameTextBox, "Username already taken.");
                    }
                    return;
                }

                var dto = new UserInfoDto
                {
                    UserName = userNameTextBox.Text.Trim(),
                    FullName = fullNameTxt.Text.Trim(),
                    Email = emaiTextBox.Text.Trim(),
                    PhoneNumber = phoneTxt.Text.Trim(),
                    Address = addressTextBox.Text.Trim(),
                    Role = roleCmb.Text,
                    Status = statusCmb.Text
                };

                Image imageToSave = userImage.Image != null
                    ? ImageHelper.Resize(userImage.Image, 256, 256)
                    : null;

                var result = await _userService.CreateUserAsync(dto, imageToSave);

                if (!result.Success)
                {
                    MessageBox.Show(result.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(result.Message, "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                OnUserAdded();
                Parent?.Controls.Remove(this);
            }
            finally
            {
                _isSubmitting = false;
                UpdateAddButtonState();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
            ClearFields();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            OnFormClosed();
            Parent?.Controls.Remove(this);
        }

        protected virtual void OnUserAdded()
        {
            UserAdded?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnFormClosed()
        {
            FormClosed?.Invoke(this, EventArgs.Empty);
        }
        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            fullNameTxt.Clear();
            userNameTextBox.Clear();
            addressTextBox.Clear();
            phoneTxt.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
        }

        private void UpdateAddButtonState()
        {
            bool basicValid =
                !string.IsNullOrWhiteSpace(userNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(fullNameTxt.Text) &&
                !string.IsNullOrWhiteSpace(emaiTextBox.Text) &&
                !string.IsNullOrWhiteSpace(phoneTxt.Text) &&
                !string.IsNullOrWhiteSpace(addressTextBox.Text) &&
                roleCmb.SelectedIndex != -1 &&
                statusCmb.SelectedIndex != -1;

            addBtn.Enabled = basicValid && _isUsernameAvailable;
        }

        private void SetAsyncError(Control control, string message)
        {
            if (control is Guna2TextBox gunaTxt)
            {
                if (string.IsNullOrEmpty(message))
                {
                    gunaTxt.BorderColor = Color.FromArgb(213, 218, 223);
                    gunaTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    gunaTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);

                    _asyncToolTip.SetToolTip(control, null);
                    _asyncToolTip.Hide(control);
                }
                else
                {
                    gunaTxt.BorderColor = Color.Red;
                    gunaTxt.HoverState.BorderColor = Color.Red;
                    gunaTxt.FocusedState.BorderColor = Color.Red;

                    _asyncToolTip.SetToolTip(control, message);
                    _asyncToolTip.Show(message, control);
                }
            }
        }

        private async void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _usernameCts?.Cancel();
            _usernameCts = new CancellationTokenSource();
            var token = _usernameCts.Token;

            string username = userNameTextBox.Text.Trim();

            if(string.IsNullOrWhiteSpace(username))
            {
                SetAsyncError(userNameTextBox, "Username is required");
                _isUsernameAvailable = false;
                return;
            }


            try
            {
                SetAsyncError(userNameTextBox, null);
                await Task.Delay(500, token);

                bool exists = await _userService.UsernameExistsAsync(username);

                if(exists)
                {
                    SetAsyncError(userNameTextBox, "Username already taken.");
                    _isUsernameAvailable = false;
                } else
                {
                    SetAsyncError(userNameTextBox, "");
                   _isUsernameAvailable = true;
                }

            } catch (TaskCanceledException)
            {
                return;
            }

            UpdateAddButtonState();
        }

        private void fullNameTxt_TextChanged(object sender, EventArgs e)
        {
            string fullname = fullNameTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullname))
            {
                SetAsyncError(fullNameTxt, "Name is required");
                return;
            }
            UpdateAddButtonState();
        }

        private void emaiTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void roleCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
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

                    if (img.Width > 3000 || img.Height > 3000)
                    {
                        MessageBox.Show("Image resolution is too high. Max 3000x3000 allowed.",
                                "Image Too Large",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                        return;
                    }

                    if (userImage != null)
                    {
                        lblImagePlaceholder.Visible = false;
                    }

                    userImage.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            userImage.SizeMode = PictureBoxSizeMode.Zoom;
            userImage.Anchor = AnchorStyles.None;
            userImage.Location = new Point((pnlUserImage.Width - userImage.Width) / 2,
                                            (pnlUserImage.Height - userImage.Height) / 2);

            lblImagePlaceholder.Anchor = AnchorStyles.None;
            lblImagePlaceholder.Location = new Point((pnlUserImage.Width - lblImagePlaceholder.Width) / 2,
                                                      (pnlUserImage.Height - lblImagePlaceholder.Height) / 2);

            lblImagePlaceholder.Click += userImage_Click;
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void phoneTxt_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneTxt.Text))
            {
                phoneTxt.Text = "+63";
                phoneTxt.SelectionStart = phoneTxt.Text.Length;
            }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (!phoneTxt.Text.StartsWith("+63"))
            {
                phoneTxt.Text = "+63";
                phoneTxt.SelectionStart = phoneTxt.Text.Length;
            }
            UpdateAddButtonState();
        }

        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneTxt_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneTxt.Text))
            {
                phoneTxt.Text = "+63";
                phoneTxt.SelectionStart = phoneTxt.Text.Length;
            }
        }

        private void lblImagePlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Resize(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                int newX = (Parent.Width - this.Width) / 2;
                int newY = (Parent.Height - this.Height) / 2;

                newX = Math.Max(0, newX);
                newY = Math.Max(0, newY);

                this.Location = new Point(newX, newY);
            }
        }

        private void userImage_Resize(object sender, EventArgs e)
        {

        }
    }
}