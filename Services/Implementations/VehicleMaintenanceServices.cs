using MySqlConnector;
using System;
using System.Collections.Generic;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.Services.Implementations {
    internal class VehicleMaintenanceServices {

        public void AddNewMaintenanceType(VehicleMaintenanceTypeDto task) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = @"
                    INSERT INTO VehicleMaintenanceTypes
                        (MaintenanceName, Description, Priority, SuggestedMileageInterval, SuggestedMonthInterval) 
                    VALUES 
                        (@Name, @Desc, @Priority, @Mileage, @Months);";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@Name", task.MaintenanceName.Trim());
                    cmd.Parameters.AddWithValue("@Priority", task.Priority.Trim());
                    cmd.Parameters.AddWithValue("@Desc", (object)task.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Mileage", task.SuggestedMileageInterval);
                    cmd.Parameters.AddWithValue("@Months", task.SuggestedMonthInterval);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<VehicleMaintenanceTypeDto> GetAllTaskDefinitions() {
            var tasks = new List<VehicleMaintenanceTypeDto>();

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = "SELECT * FROM VehicleMaintenanceTypes ORDER BY MaintenanceName ASC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            tasks.Add(new VehicleMaintenanceTypeDto {
                                MaintenanceTypeID = reader.GetInt32("MaintenanceTypeID"),
                                MaintenanceName = reader.GetString("MaintenanceName"),
                                Priority = reader.GetString("Priority"),
                                Description = reader.IsDBNull(reader.GetOrdinal("Description"))
                                              ? ""
                                              : reader.GetString("Description"),

                                SuggestedMileageInterval = reader.IsDBNull(reader.GetOrdinal("SuggestedMileageInterval"))
                                                         ? (int?)null
                                                         : reader.GetInt32("SuggestedMileageInterval"),

                                SuggestedMonthInterval = reader.IsDBNull(reader.GetOrdinal("SuggestedMonthInterval"))
                                                       ? (int?)null
                                                       : reader.GetInt32("SuggestedMonthInterval")
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
                    cmd.Parameters.AddWithValue("@Plate", schedule.VehiclePlateNum);
                    cmd.Parameters.AddWithValue("@TypeId", schedule.MaintenanceTypeID);

                    cmd.Parameters.AddWithValue("@IntervalKm", (object)schedule.MileageInterval ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IntervalMonths", (object)schedule.MonthInterval ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastOdo", schedule.LastServiceMileage);
                    cmd.Parameters.AddWithValue("@LastDate", schedule.LastServiceDate);

                    cmd.Parameters.AddWithValue("@NextOdo", (object)schedule.NextDueMileage ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NextDate", (object)schedule.NextDueDate ?? DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
