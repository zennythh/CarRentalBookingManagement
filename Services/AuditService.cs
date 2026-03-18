using VehicleManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;
using MySqlConnector;

namespace PL_VehicleRental.Services
{
    public class AuditService
    {
        public static async Task LogAsync(AuditLog log)
        {
            string query = @"INSERT INTO AuditLogs
                            (userId, actionType, description, tableAffected, recordId, oldValues, newValues)
                            VALUES
                            (@userId, @actionType, @description, @tableAffected, @recordId, @oldValues, @newValues)";

            using (var conn = MySQLConnectionContext.Create())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", log.UserId);
                cmd.Parameters.AddWithValue("@actionType", log.ActionType);
                cmd.Parameters.AddWithValue("@description", log.Description);
                cmd.Parameters.AddWithValue("@tableAffected", log.TableAffected);
                cmd.Parameters.AddWithValue("@recordId", log.RecordId);
                cmd.Parameters.AddWithValue("@oldValues", log.OldValues);
                cmd.Parameters.AddWithValue("@newValues", log.NewValues);

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<List<AuditLog>> GetAuditLogsAsync()
        {
            var logs = new List<AuditLog>();

            string query = @"SELECT 
                            a.id, u.userName, a.actionType, a.description, a.tableAffected, a.createdAt
                            FROM AuditLogs a 
                            LEFT JOIN users u ON u.id = a.userId
                            ORDER BY a.createdAt DESC";

            using (var conn = MySQLConnectionContext.Create())
            using (var cmd = new MySqlCommand(query, conn))
            {
                await conn.OpenAsync();
                
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while(await reader.ReadAsync())
                    {
                        logs.Add(new AuditLog
                        {
                            UserId = reader.GetInt32("id"),
                            UserName = reader.GetString("userName"),
                            ActionType = reader.GetString("actionType"),
                            Description = reader.GetString("description"),
                            TableAffected = reader.GetString("tableAffected"),
                            CreatedAt = reader.GetDateTime("createdAt")
                        });
                    }
                }
            }
            return logs;
        }
    }
}
