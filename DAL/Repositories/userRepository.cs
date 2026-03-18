using VehicleManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using VehicleManagementSystem.Dto;
using System.Security.Cryptography;
using Org.BouncyCastle.Bcpg;
using System.Drawing;
using VehicleManagementSystem.Helpers;
using System.Runtime.InteropServices;

namespace PL_VehicleRental.DAL.Repositories
{
    public class userRepository
    {
        public static class PasswordHelper
        {
            private const string DefaultPassword = "userpass";

            public static string HashPassword(string password)
                => BCrypt.Net.BCrypt.HashPassword(password);

            public static string GetDefaultPasswordHash()
                => BCrypt.Net.BCrypt.HashPassword(DefaultPassword);

            public static bool Verify(string inputPassword, string storedHash)
                => BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
        }

        public async Task<bool> UsernameExistsAsync(string username)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                const string query = @"SELECT COUNT(*) FROM users WHERE userName = @userName";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);

                   int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    return count > 0;
                }
            }
        }

        public async Task<int> InsertAsync(UserInfoDto dto, string userImage)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                const string sql = @"INSERT INTO users (userName, fullName, email, phoneNumber, address, role, status, passwordHash, isDefaultPassword, isDeleted, imagePath)
                                     VALUES (@userName, @fullName, @email, @phoneNumber, @address, @role, @status, @passwordHash, 1, 0, @ImagePath);
                                     SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", dto.UserName);
                    cmd.Parameters.AddWithValue("@fullName", dto.FullName);
                    cmd.Parameters.AddWithValue("@email", dto.Email);
                    cmd.Parameters.AddWithValue("@phoneNumber", dto.PhoneNumber);
                    cmd.Parameters.AddWithValue("@address", dto.Address);
                    cmd.Parameters.AddWithValue("@role", dto.Role);
                    cmd.Parameters.AddWithValue("@status", dto.Status);
                    cmd.Parameters.AddWithValue("@passwordHash", PasswordHelper.GetDefaultPasswordHash());
                    cmd.Parameters.AddWithValue("@isDeleted", dto.isDeleted);
                    cmd.Parameters.AddWithValue("@ImagePath", (object)userImage ?? (object)DBNull.Value);

                    int newId = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    return newId;
                }
            }
        }

        public async Task<UserInfoDto> ValidateLoginAsync(string usernameOrEmail, string password)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                const string sql = @"SELECT id, userName, fullName, email, address, role, status, passwordHash, isDefaultPassword, imagePath
                                     FROM users WHERE (userName = @input OR email = @input) AND status = 'Active'";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@input", usernameOrEmail);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (!await reader.ReadAsync()) return null;

                        var storedHash = reader.GetString("passwordHash");
                        if (!PasswordHelper.Verify(password, storedHash)) return null;

                        return new UserInfoDto
                        {
                            Id = reader.GetInt32("id"),
                            UserName = reader.GetString("userName"),
                            FullName = reader.GetString("fullName"),
                            Email = reader.GetString("email"),
                            Address = reader.GetString("address"),
                            Role = reader.GetString("role"),
                            Status = reader.GetString("status"),
                            isDefaultPassword = reader.GetBoolean("isDefaultPassword"),
                            ImagePath = reader.IsDBNull(reader.GetOrdinal("imagePath"))
                                        ? null
                                        : reader.GetString("imagePath")
                        };

                    }
                }
                    
            }
        }

        public async Task<bool> ChangePasswordAsync(string username, string newPassword)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                const string sql = @"UPDATE users SET passwordHash = @hash, isDefaultPassword = 0 
                                     WHERE userName = @userName";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@hash", PasswordHelper.HashPassword(newPassword));
                    cmd.Parameters.AddWithValue("@userName", username);

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }

        public async Task<(List<UserInfoDto> Users, int TotalCount)> GetPagedUsersAsync(string search, int pageNumber, int pageSize, string currentUserRole)
        {
            var users = new List<UserInfoDto>();
            int totalCount = 0;

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                string searchParam = $"%{search}%";

                string whereClause = @"
                                        WHERE
                                        (
                                            (@CurrentUserRole = 'Superadmin' AND isDeleted = 0)
                                            OR
                                            (@CurrentUserRole != 'Superadmin' AND isDeleted = 0 AND status = 'Active')
                                        )
                                        AND (
                                             userName LIKE @Search
                                             OR fullName LIKE @Search
                                             OR email LIKE @Search
                                             OR address LIKE @Search
                                             )";


                string countQuery = $@"
                                    SELECT COUNT(*) 
                                    FROM users 
                                    {whereClause}";

                using (var countCmd = new MySqlCommand(countQuery, conn))
                {
                    countCmd.Parameters.AddWithValue("@Search", searchParam);
                    countCmd.Parameters.AddWithValue("@CurrentUserRole", currentUserRole);
                    totalCount = Convert.ToInt32(await countCmd.ExecuteScalarAsync());
                }

                string dataQuery = $@"
                SELECT id, userName, fullName, email, address, role, status
                FROM users 
                {whereClause}
                ORDER BY created_at DESC LIMIT @PageSize OFFSET @Offset";

                using (var cmd = new MySqlCommand(dataQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", searchParam);
                    cmd.Parameters.AddWithValue("@CurrentUserRole", currentUserRole);
                    cmd.Parameters.AddWithValue("PageSize", pageSize);
                    cmd.Parameters.AddWithValue("Offset", (pageNumber - 1) * pageSize);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            users.Add(new UserInfoDto
                            {
                                Id = reader.GetInt32("id"),
                                UserName = reader.GetString("userName"),
                                FullName = reader.GetString("fullName"),
                                Email = reader.GetString("email"),
                                Address = reader.GetString("address"),
                                Role = reader.GetString("role"),
                                Status = reader.GetString("status")
                            });
                        }
                    }
                }
            }

            return (users, totalCount);
        }

        public async Task<bool> UpdateUserAsync(UserInfoDto user, Image newImage = null)
        {
            var imageService = new UserImageService();

            string newImagePath = null;
            string oldImagePath = null;
            string query;

            if(user.isImageChanged)
            {
                query = @"
                UPDATE users 
                SET
                    userName = @Username,
                    fullName = @Fullname,
                    email = @Email,
                    phoneNumber = @PhoneNumber,
                    address = @Address,
                    role = @Role,
                    status = @Status,
                    imagePath = @ImagePath
                WHERE id = @Id";
            } 
            else
            {
               query = @"
                UPDATE users 
                SET
                    userName = @Username,
                    fullName = @Fullname,
                    email = @Email,
                    phoneNumber = @PhoneNumber,
                    address = @Address,
                    role = @Role,
                    status = @Status
                WHERE id = @Id";
            }

                using (MySqlConnection conn = MySQLConnectionContext.Create())
                {
                    await conn.OpenAsync();

                const string selectQuery = "SELECT imagePath FROM users WHERE id = @Id";

                using (var selectCmd = new MySqlCommand(selectQuery, conn))
                {
                    selectCmd.Parameters.AddWithValue("@Id", user.Id);
                    var result = await selectCmd.ExecuteScalarAsync();
                    oldImagePath = result == DBNull.Value ? null : result?.ToString();
                }

                if (user.isImageChanged && newImage != null)
                {
                    newImagePath = imageService.Save(newImage);
                }

                using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", user.Id);
                        cmd.Parameters.AddWithValue("@Username", user.UserName);
                        cmd.Parameters.AddWithValue("@Fullname", user.FullName);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Address", user.Address);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@Status", user.Status);

                    if (user.isImageChanged)
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", (object)newImagePath ?? DBNull.Value);
                    }

                    int rows = await cmd.ExecuteNonQueryAsync();

                    if (rows > 0 && user.isImageChanged && oldImagePath != null)
                    {
                        imageService.Delete(oldImagePath);
                    }
                    return rows > 0;
                    }
                }
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            const string query = @"UPDATE users SET isDeleted = 1 WHERE id = @Id";

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);

                    int rows = await cmd.ExecuteNonQueryAsync();

                    return rows > 0;
                }
            }
        }

        public async Task<bool> UpdateUserImageAsync(int userId, byte[] imageBytes)
        {
            const string query = @"UPDATE users SET userImage = @Image WHERE id = @Id";

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Image", imageBytes);
                    cmd.Parameters.AddWithValue("@Id", userId);

                    int rows = await cmd.ExecuteNonQueryAsync();
                    return rows > 0;
                }
            }
        }

        public async Task<byte[]> GetUserImageAsync(int userId)
        {
            const string query = @"SELECT userImage FROM users WHERE id = @Id AND isDeleted = 0";

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);

                    object result = await cmd.ExecuteScalarAsync();

                    return result != DBNull.Value ? (byte[])result : null;
                }
            }
        }
    }
}
