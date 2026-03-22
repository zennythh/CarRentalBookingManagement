using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.Services.Implementations {
    internal class VehicleMaintenanceServices {

        public void AddMaintenanceTaskDefinition(VehicleMaintenanceTypeDto task) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = @"
                    INSERT INTO MaintenanceTaskDefinitions 
                    (TaskName, Description, DefaultMileageInterval, DefaultMonthInterval) 
                    VALUES 
                    (@Name, @Desc, @Mileage, @Months);";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@Name", task.TaskName.Trim());
                    cmd.Parameters.AddWithValue("@Desc", (object)task.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Mileage", task.DefaultMileageInterval);
                    cmd.Parameters.AddWithValue("@Months", task.DefaultMonthInterval);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<VehicleMaintenanceTypeDto> GetAllTaskDefinitions() {
            var tasks = new List<VehicleMaintenanceTypeDto>();

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = "SELECT * FROM MaintenanceTaskDefinitions ORDER BY TaskName ASC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            tasks.Add(new VehicleMaintenanceTypeDto {
                                TaskID = reader.GetInt32("TaskID"),
                                TaskName = reader.GetString("TaskName"),
                                Description = reader.IsDBNull(reader.GetOrdinal("Description"))
                                              ? ""
                                              : reader.GetString("Description"),

                                DefaultMileageInterval = reader.IsDBNull(reader.GetOrdinal("DefaultMileageInterval"))
                                                         ? (int?)null
                                                         : reader.GetInt32("DefaultMileageInterval"),

                                DefaultMonthInterval = reader.IsDBNull(reader.GetOrdinal("DefaultMonthInterval"))
                                                       ? (int?)null
                                                       : reader.GetInt32("DefaultMonthInterval")
                            });
                        }
                    }
                }
            }
            return tasks;
        }

        public void AddMaintenanceSchedule(VehicleMaintenanceScheduleDto schedule) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = @"
            INSERT INTO VehicleMaintenanceSchedules 
            (VehiclePlateNum, TypeId, CustomMileageInterval, CustomMonthInterval, 
             LastServiceOdometer, LastServiceDate, NextServiceOdometer, NextServiceDate) 
            VALUES 
            (@Plate, @TypeId, @IntervalKm, @IntervalMonths, 
             @LastOdo, @LastDate, @NextOdo, @NextDate);";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@Plate", schedule.PlateNumber);
                    cmd.Parameters.AddWithValue("@TypeId", schedule.TypeId);

                    cmd.Parameters.AddWithValue("@IntervalKm", (object)schedule.IntervalKm ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IntervalMonths", (object)schedule.IntervalMonths ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastOdo", schedule.LastPerformedOdometer);
                    cmd.Parameters.AddWithValue("@LastDate", schedule.LastPerformedDate);

                    cmd.Parameters.AddWithValue("@NextOdo", (object)schedule.NextDueOdometer ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NextDate", (object)schedule.NextDueDate ?? DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
