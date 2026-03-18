using PL_VehicleRental.DAL.Repositories;
using PL_VehicleRental.Services;
using PL_VehicleRental.Services.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Forms
{
    public partial class frmLogin : Form
    {
        private readonly userRepository _repository;
        public frmLogin()
        {
            InitializeComponent();
            _repository = new userRepository();
            this.AcceptButton = btnLogin;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = usernameTxt.Text.Trim();
            var password = passwordTxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = true;

            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "Logging in...";

                var user = await _repository.ValidateLoginAsync(username, password);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (user.isDefaultPassword)
                {
                    MessageBox.Show("You are using a default password. Please change it before continuing.",
                                    "Security Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (var changePassForm = new frmChangePassword(user.UserName))
                    {
                        changePassForm.ShowDialog();
                    }

                    usernameTxt.Clear();
                    passwordTxt.Clear();
                    usernameTxt.Focus();

                    MessageBox.Show(
                        "Password changed successfully. Please log in again using your new password.",
                        "Login Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (string.IsNullOrWhiteSpace(user.Role) ||
                    !Enum.TryParse<UserRole>(user.Role.Trim(), true, out var parsedRole))
                {
                    MessageBox.Show("Invalid role value in database.");
                    return;
                }

                Session.User = new CurrentUser
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FullName = user.FullName,
                    Role = parsedRole,
                    UserImagePath = user.ImagePath,
                };

                await AuditService.LogAsync(new AuditLog
                {
                    UserId = user.Id,
                    ActionType = "LOGIN",
                    Description = "User logged in",
                    TableAffected = "users",
                    RecordId = user.Id
                });

                Console.WriteLine($"'{user.ImagePath}'");
                Console.WriteLine($"Logged in user: '{user.Id}' - '{user.UserName}'");

                Console.WriteLine($"Role from DB: '{user.Role}'");
            } finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }

            this.DialogResult = DialogResult.OK;
           
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void chkShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            //passwordTxt.UseSystemPasswordChar = false;
        }

        private void chkShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            //passwordTxt.UseSystemPasswordChar = true;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
