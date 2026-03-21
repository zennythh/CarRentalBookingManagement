using MySqlConnector;
using PL_VehicleRental.DAL.Repositories;
using VehicleManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;
using System.Windows;

namespace PL_VehicleRental.Services
{
    public class UserService
    {
        private readonly userRepository _repository;

        public UserService()
        {
            _repository = new userRepository();
        }

        public async Task<(bool Success, string Message, int UserId)> CreateUserAsync(UserInfoDto dto, Image userImage)
        {
            if (await _repository.UsernameExistsAsync(dto.UserName))
                return (false, "Username already exists.", 0);

            if (await _repository.EmailExistsAsync(dto.Email))
                return (false, "Email already exists.", 0);

            string imagePath = null;
            var imageService = new UserImageService();
            
            if (userImage != null)
            {
                imagePath = imageService.Save(userImage);
            }

            var insertResult = await _repository.InsertAsync(dto, imagePath);
            MessageBox.Show($"User created! \n Temporary password: {insertResult.TemporaryPassword}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            if (insertResult <= 0) return (false, "Failed to insert user.", 0);

            return (true, "User created successfully.", insertResult);
        }

        public async Task<bool> UsernameExistsAsync(string username)
        {
            return await _repository.UsernameExistsAsync(username);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _repository.EmailExistsAsync(email);
        }
    }
}
