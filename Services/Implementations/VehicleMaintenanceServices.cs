using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.Services.Implementations {
    internal class VehicleMaintenanceServices {

        public async Task AddNewMaintenanceType(VehicleMaintenanceTypeDto task) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                await conn.OpenAsync();
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

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<List<VehicleMaintenanceTypeDto>> GetAllMaintenanceTypes() {
            var tasks = new List<VehicleMaintenanceTypeDto>();

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = "SELECT * FROM VehicleMaintenanceTypes ORDER BY MaintenanceName ASC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync()) {
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

        public async Task<List<VehicleMaintenanceScheduleDto>> GetMaintenanceSchedulesByVehicle(string vehiclePlateNum) {
            var schedules = new List<VehicleMaintenanceScheduleDto>();

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                await conn.OpenAsync();
                string sql = @"
            SELECT 
                ms.ScheduleID,
                ms.VehiclePlateNum,
                ms.MaintenanceTypeID,
                ms.ScheduleType,
                ms.Status,
                ms.DueDate,
                ms.DueMileage,
                ms.MileageInterval,
                ms.MonthInterval,
                ms.LastServiceMileage,
                ms.LastServiceDate,
                ms.CompletedDate,
                ms.IsActive,
                ms.CreatedDate,
                ms.LastModifiedDate,
                mt.MaintenanceName,
                mt.Description AS MaintenanceDescription,
                v.CurrentOdometerReading
            FROM VehicleMaintenanceSchedules ms
            INNER JOIN VehicleMaintenanceTypes mt 
                ON ms.MaintenanceTypeID = mt.MaintenanceTypeID
            INNER JOIN Vehicles v 
                ON ms.VehiclePlateNum = v.LicensePlate
            WHERE ms.VehiclePlateNum = @VehiclePlateNum
              AND ms.IsActive = 1
            ORDER BY 
                CASE ms.Status
                    WHEN 'Scheduled' THEN 1
                    WHEN 'Completed' THEN 2
                    WHEN 'Cancelled' THEN 3
                    ELSE 4
                END,
                ms.DueDate ASC,
                ms.DueMileage ASC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@VehiclePlateNum", vehiclePlateNum);

                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        while (reader.Read()) {
                            schedules.Add(new VehicleMaintenanceScheduleDto {
                                ScheduleID = reader.GetInt32("ScheduleID"),
                                VehiclePlateNum = reader.GetString("VehiclePlateNum"),
                                MaintenanceTypeID = reader.GetInt32("MaintenanceTypeID"),
                                MaintenanceName = reader.GetString("MaintenanceName"),

                                ScheduleType = reader.GetString("ScheduleType"),
                                Status = reader.GetString("Status"),

                                // One-time schedule fields
                                DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate"))
                                         ? (DateTime?)null
                                         : reader.GetDateTime("DueDate"),
                                DueMileage = reader.IsDBNull(reader.GetOrdinal("DueMileage"))
                                            ? (decimal?)null
                                            : reader.GetDecimal("DueMileage"),

                                // Recurring schedule fields
                                MileageInterval = reader.IsDBNull(reader.GetOrdinal("MileageInterval"))
                                                 ? (int?)null
                                                 : reader.GetInt32("MileageInterval"),
                                MonthInterval = reader.IsDBNull(reader.GetOrdinal("MonthInterval"))
                                               ? (int?)null
                                               : reader.GetInt32("MonthInterval"),
                                LastServiceMileage = reader.IsDBNull(reader.GetOrdinal("LastServiceMileage"))
                                                    ? (decimal?)null
                                                    : reader.GetDecimal("LastServiceMileage"),
                                LastServiceDate = reader.IsDBNull(reader.GetOrdinal("LastServiceDate"))
                                                 ? (DateTime?)null
                                                 : reader.GetDateTime("LastServiceDate"),

                                CompletedDate = reader.IsDBNull(reader.GetOrdinal("CompletedDate"))
                                               ? (DateTime?)null
                                               : reader.GetDateTime("CompletedDate"),


                                CurrentVehicleMileage = reader.GetDecimal("CurrentOdometerReading")
                            });
                        }
                    }
                }
            }

            return schedules;
        }

        public async Task AddMaintenanceSchedule(VehicleMaintenanceScheduleDto schedule) {
            ValidateScheduleDto(schedule);

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = BuildInsertSql(schedule.ScheduleType);
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@VehiclePlateNum", schedule.VehiclePlateNum);
                    cmd.Parameters.AddWithValue("@MaintenanceTypeID", schedule.MaintenanceTypeID);
                    cmd.Parameters.AddWithValue("@ScheduleType", schedule.ScheduleType);
                    cmd.Parameters.AddWithValue("@Status", schedule.Status ?? "Scheduled");
                    cmd.Parameters.AddWithValue("@Priority", schedule.Priority ?? "Normal");
                    cmd.Parameters.AddWithValue("@IsActive", 1);

                    if (schedule.ScheduleType == "Recurring") {
                        cmd.Parameters.AddWithValue("@MileageInterval", (object)schedule.MileageInterval ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MonthInterval", (object)schedule.MonthInterval ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@LastServiceMileage", (object)schedule.LastServiceMileage ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@LastServiceDate", (object)schedule.LastServiceDate ?? DBNull.Value);
                    } else if (schedule.ScheduleType == "OneTime") {
                        cmd.Parameters.AddWithValue("@DueDate", (object)schedule.DueDate ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DueMileage", (object)schedule.DueMileage ?? DBNull.Value);
                    }

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        private string BuildInsertSql(string scheduleType) {
            if (scheduleType == "Recurring") {
                return @"
            INSERT INTO VehicleMaintenanceSchedules 
            (
                VehiclePlateNum, 
                MaintenanceTypeID, 
                ScheduleType,
                Status,
                MileageInterval, 
                MonthInterval, 
                LastServiceMileage, 
                LastServiceDate,
                IsActive
            ) 
            VALUES 
            (
                @VehiclePlateNum, 
                @MaintenanceTypeID, 
                @ScheduleType,
                @Status,
                @MileageInterval, 
                @MonthInterval, 
                @LastServiceMileage, 
                @LastServiceDate,
                @IsActive
            );";
            } else if (scheduleType == "OneTime") {
                return @"
            INSERT INTO VehicleMaintenanceSchedules 
            (
                VehiclePlateNum, 
                MaintenanceTypeID, 
                ScheduleType,
                Status,
                DueDate,
                DueMileage,
                IsActive
            ) 
            VALUES 
            (
                @VehiclePlateNum, 
                @MaintenanceTypeID, 
                @ScheduleType,
                @Status,
                @DueDate,
                @DueMileage,
                @IsActive
            );";
            } else {
                throw new ArgumentException($"Invalid schedule type: {scheduleType}");
            }
        }

        private void ValidateScheduleDto(VehicleMaintenanceScheduleDto schedule) {
            if (string.IsNullOrWhiteSpace(schedule.VehiclePlateNum))
                throw new ArgumentException("Vehicle plate number is required.");

            if (schedule.MaintenanceTypeID <= 0)
                throw new ArgumentException("Valid maintenance type must be selected.");

            if (string.IsNullOrWhiteSpace(schedule.ScheduleType))
                throw new ArgumentException("Schedule type is required.");

            if (schedule.ScheduleType == "Recurring") {
                if (!schedule.MileageInterval.HasValue && !schedule.MonthInterval.HasValue)
                    throw new ArgumentException("Recurring maintenance requires at least one interval (mileage or time).");

                if (!schedule.LastServiceDate.HasValue)
                    throw new ArgumentException("Last service date is required for recurring maintenance.");

                if (schedule.MileageInterval.HasValue && !schedule.LastServiceMileage.HasValue)
                    throw new ArgumentException("Last service mileage is required when using mileage intervals.");
            } else if (schedule.ScheduleType == "OneTime") {
                if (!schedule.DueDate.HasValue && !schedule.DueMileage.HasValue)
                    throw new ArgumentException("One-time maintenance requires at least one due condition (date or mileage).");
            } else {
                throw new ArgumentException($"Invalid schedule type: {schedule.ScheduleType}. Must be 'Recurring' or 'OneTime'.");
            }
        }




    }
}
