using MySqlConnector;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagementSystem;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.Services {
    internal class BookingServices {

        internal static BookingDto MapReaderToBooking(MySqlDataReader reader) {
            var booking = new BookingDto {
                BookingID = reader.GetString("BookingID"),
                FirstName = reader.GetString("FirstName"),
                LastName = reader.GetString("LastName"),
                LicenseNumber = reader.GetString("LicenseNum"),
                Email = reader.GetString("Email"),
                PhoneNumber = reader.GetString("PhoneNumber"),
                VehicleVIN = reader.GetString("VehicleVIN"),

                // We standardized our SQL queries to always use 'FullVehicleName'
                VehicleName = reader.GetString("FullVehicleName"),

                LicensePlate = reader.GetString("LicensePlate"),
                ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString("ImagePath"),
                Status = reader.GetString("Status"),
                DateSubmitted = reader.GetDateTime("DateSubmitted"),
                DateSchedOut = reader.GetDateTime("DateSchedOut"),
                DateDue = reader.GetDateTime("DateDue"),
                DailyRate = reader.GetDecimal("DailyRate"),
                ProjectedPrice = reader.GetDecimal("ProjectedPrice"),

                // Nullable Dates
                DateOut = reader.IsDBNull(reader.GetOrdinal("DateOut")) ? (DateTime?)null : reader.GetDateTime("DateOut"),
                DateIn = reader.IsDBNull(reader.GetOrdinal("DateIn")) ? (DateTime?)null : reader.GetDateTime("DateIn"),

                // Usage Metrics
                MileageOut = reader.IsDBNull(reader.GetOrdinal("MileageOut")) ? (int?)null : reader.GetInt32("MileageOut"),
                MileageIn = reader.IsDBNull(reader.GetOrdinal("MileageIn")) ? (int?)null : reader.GetInt32("MileageIn"),
                FuelLevelOut = reader.IsDBNull(reader.GetOrdinal("FuelLevelOut")) ? null : reader.GetString("FuelLevelOut"),
                FuelLevelIn = reader.IsDBNull(reader.GetOrdinal("FuelLevelIn")) ? null : reader.GetString("FuelLevelIn"),

                // Prices (Handling potential nulls for decimals)
                AdditionalFees = reader.IsDBNull(reader.GetOrdinal("AdditionalFees")) ? 0 : reader.GetDecimal("AdditionalFees"),
                TotalPrice = reader.IsDBNull(reader.GetOrdinal("TotalPrice")) ? 0 : reader.GetDecimal("TotalPrice")
            };

            // Dynamic Damage Detection: Check if column exists without needing SchemaTable
            for (int i = 0; i < reader.FieldCount; i++) {
                if (reader.GetName(i).Equals("DamageCount", StringComparison.OrdinalIgnoreCase)) {
                    int damageCount = reader.IsDBNull(i) ? 0 : reader.GetInt32(i);
                    booking.HasDamage = damageCount > 0;
                    break;
                }
            }

            return booking;
        }

        public async Task<List<BookingDto>> GetAllBookings() {
            List<BookingDto> bookings = new List<BookingDto>();
            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath, v.DailyRate 
                             FROM Bookings b 
                             JOIN Vehicles v ON b.VehicleVIN = v.VIN";

            using (var conn = MySQLConnectionContext.Create()) {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand(query, conn)) {
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        while (await reader.ReadAsync()) {
                            bookings.Add(MapReaderToBooking(reader));
                        }
                    }
                }
            }
            return bookings;
        }

        public async Task<List<BookingDto>> GetBookingsByStatus(string status) {
            List<BookingDto> list = new List<BookingDto>();
            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath, v.DailyRate";

            if (status == "Completed") {
                query += @", (SELECT COUNT(*) FROM VehicleDamages vd 
                             JOIN VehicleInspections vi ON vd.InspectionID = vi.InspectionID 
                             WHERE vi.BookingID = b.BookingID) AS DamageCount";
            }

            query += @" FROM Bookings b 
                        JOIN Vehicles v ON b.VehicleVIN = v.VIN 
                        WHERE b.Status = @status AND b.Deleted = 0 
                        ORDER BY b.DateIn DESC, b.DateSubmitted DESC";

            using (var conn = MySQLConnectionContext.Create()) {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@status", status);
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        while (await reader.ReadAsync()) {
                            list.Add(MapReaderToBooking(reader));
                        }
                    }
                }
            }
            return list;
        }

        public List<BookingDto> SearchBookings(string searchTerm, string status = "Pending") {
            List<BookingDto> results = new List<BookingDto>();
            using (var connection = MySQLConnectionContext.Create()) {
                try {
                    connection.Open();
                    string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath, v.DailyRate 
                                     FROM Bookings b
                                     JOIN Vehicles v ON b.VehicleVIN = v.VIN
                                     WHERE b.Status = @status AND b.Deleted = 0
                                     AND (b.BookingID LIKE @search OR b.FirstName LIKE @search OR b.LastName LIKE @search 
                                          OR b.LicenseNum LIKE @search OR b.Email LIKE @search OR b.PhoneNumber LIKE @search)";

                    using (var cmd = new MySqlCommand(query, connection)) {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                        using (var reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                results.Add(MapReaderToBooking(reader));
                            }
                        }
                    }
                } catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            return results;
        }

        public static List<BookingDto> GetConflictingBookings(string currentBookingID, string vin, DateTime requestedStart, DateTime requestedEnd) {
            List<BookingDto> conflicts = new List<BookingDto>();
            int bufferHours = 3;

            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath, v.DailyRate 
                            FROM Bookings b
                            JOIN Vehicles v ON b.VehicleVIN = v.VIN
                            WHERE b.VehicleVIN = @vin 
                            AND b.Status IN ('Pending', 'Approved', 'Ongoing')
                            AND @RequestedStart < DATE_ADD(b.DateDue, INTERVAL @Buffer HOUR)
                            AND @RequestedEnd > b.DateSchedOut
                            AND b.BookingID != @CurrentBookingID 
                            AND b.Deleted = 0";

            using (var conn = MySQLConnectionContext.Create()) {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@CurrentBookingID", currentBookingID);
                    cmd.Parameters.AddWithValue("@vin", vin);
                    cmd.Parameters.AddWithValue("@RequestedStart", requestedStart);
                    cmd.Parameters.AddWithValue("@RequestedEnd", requestedEnd);
                    cmd.Parameters.AddWithValue("@Buffer", bufferHours);

                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            conflicts.Add(MapReaderToBooking(reader));
                        }
                    }
                }
            }
            return conflicts;
        }

        public (bool success, string message) ProcessApproval(PendingInfosDto info) {
            using (var connection = MySQLConnectionContext.Create()) {
                connection.Open();
                using (var transaction = connection.BeginTransaction()) {
                    try {
                        var conflicts = GetConflictingBookings(info.BookingID, info.VehicleVIN, info.DateSchedOut, info.DateDue);
                        var bookingsToReject = conflicts.Where(c => c.Status == "Pending").ToList();

                        bool hasHardDirectConflict = conflicts.Any(c =>
                            (c.Status == "Approved" || c.Status == "Ongoing") &&
                            info.DateSchedOut < c.DateDue);

                        if (hasHardDirectConflict) {
                            return (false, "CANNOT APPROVE: Direct overlap with an active/approved booking.");
                        }

                        if (bookingsToReject.Count > 0) {
                            string ids = string.Join("','", bookingsToReject.Select(c => c.BookingID));
                            string rejectQuery = $"UPDATE Bookings SET Status = 'Rejected' WHERE BookingID IN ('{ids}')";

                            using (var cmd = new MySqlCommand(rejectQuery, connection, transaction)) {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        string updateBooking = @"UPDATE Bookings SET 
                                        FirstName=@fn, LastName=@ln, LicenseNum=@lic, Email=@em, PhoneNumber=@ph, 
                                        DateSchedOut=@start, DateDue=@due, 
                                        ProjectedPrice=@price, Status='Approved' 
                                        WHERE BookingID=@bid";

                        using (var cmd = new MySqlCommand(updateBooking, connection, transaction)) {
                            cmd.Parameters.AddWithValue("@fn", info.FirstName);
                            cmd.Parameters.AddWithValue("@ln", info.LastName);
                            cmd.Parameters.AddWithValue("@lic", info.LicenseNumber);
                            cmd.Parameters.AddWithValue("@em", info.Email);
                            cmd.Parameters.AddWithValue("@ph", info.PhoneNumber);
                            cmd.Parameters.AddWithValue("@start", info.DateSchedOut);
                            cmd.Parameters.AddWithValue("@due", info.DateDue);
                            cmd.Parameters.AddWithValue("@price", info.ProjectedPrice);
                            cmd.Parameters.AddWithValue("@bid", info.BookingID);
                            cmd.ExecuteNonQuery();
                        }

                        string updateVehicle = "UPDATE Vehicles SET CurrentStatus = 'Rented' WHERE VIN = @vin";
                        using (var cmd = new MySqlCommand(updateVehicle, connection, transaction)) {
                            cmd.Parameters.AddWithValue("@vin", info.VehicleVIN);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return (true, "Approval successful. Conflicting requests rejected.");
                    } catch (Exception ex) {
                        transaction.Rollback();
                        return (false, $"Database Error: {ex.Message}");
                    }
                }
            }
        }

        public (bool success, string message) ProcessRejection(string bookingID)
        {
            using (var connection = MySQLConnectionContext.Create())
            {
                try
                {
                    connection.Open();
                    // Note: Fixed the double update in the original query and added quotes for VARCHAR ID
                    string query = @"UPDATE Bookings SET Status = 'Rejected' WHERE BookingID = @bid; 
                             UPDATE Vehicles SET CurrentStatus = 'Available' 
                             WHERE VIN = (SELECT VehicleVIN FROM Bookings WHERE BookingID = @bid);";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@bid", bookingID);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            return (true, "Booking has been rejected.");
                        else
                            return (false, "Booking not found or already updated.");
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Database Error: {ex.Message}");
                }
            }
        }

        public (bool success, string message) ProcessUnitRelease(string bookingID, string vin, int mileageOut, string fuelOut)
        {
            using (var connection = MySQLConnectionContext.Create())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Update Booking status and metrics
                        string updateBooking = @"UPDATE Bookings SET 
                                        Status = 'Ongoing', 
                                        DateOut = @dateOut, 
                                        MileageOut = @mOut, 
                                        FuelLevelOut = @fOut 
                                        WHERE BookingID = @bid";

                        using (var cmd = new MySqlCommand(updateBooking, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@dateOut", DateTime.Now);
                            cmd.Parameters.AddWithValue("@mOut", mileageOut);
                            cmd.Parameters.AddWithValue("@fOut", fuelOut);
                            cmd.Parameters.AddWithValue("@bid", bookingID);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update Vehicle status
                        string updateVehicle = "UPDATE Vehicles SET CurrentStatus = 'Rented' WHERE VIN = @vin";
                        using (var cmd = new MySqlCommand(updateVehicle, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@vin", vin);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return (true, "Vehicle successfully released!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, $"Database Error: {ex.Message}");
                    }
                }
            }
        }

        // Added parameters: mileageIn and fuelIn
        public async Task<bool> SaveFullInspection(string bookingID, string vin, string notes, string damages,
                                                  List<string> imagePaths, int mileageIn, string fuelIn)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();
                using (var trans = await conn.BeginTransactionAsync())
                {
                    try
                    {
                        // 1. Create the Parent Inspection Record
                        string insertInspection = @"INSERT INTO VehicleInspections (VIN, BookingID, GeneralNotes, InspectedAt) 
                                           VALUES (@vin, @bid, @notes, @at);
                                           SELECT LAST_INSERT_ID();";

                        int inspectionID;
                        using (var cmd = new MySqlCommand(insertInspection, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@vin", vin);
                            cmd.Parameters.AddWithValue("@bid", bookingID);
                            cmd.Parameters.AddWithValue("@notes", string.IsNullOrWhiteSpace(notes) ? (object)DBNull.Value : notes);
                            cmd.Parameters.AddWithValue("@at", DateTime.Now);
                            inspectionID = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                        }

                        // 2. Insert Damages and 3. Insert Images (Logic remains same as previous migration)
                        // ... [Omitted for brevity, keep your existing logic here] ...

                        // 4. Update Booking Status AND Usage Metrics
                        // Fixed: Now includes MileageIn and FuelLevelIn
                        string updateBooking = @"UPDATE Bookings SET 
                                        Status = 'Completed', 
                                        DateIn = @now,
                                        MileageIn = @mIn,
                                        FuelLevelIn = @fIn
                                        WHERE BookingID = @bid";

                        using (var cmd = new MySqlCommand(updateBooking, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            cmd.Parameters.AddWithValue("@mIn", mileageIn);
                            cmd.Parameters.AddWithValue("@fIn", fuelIn);
                            cmd.Parameters.AddWithValue("@bid", bookingID);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        // 5. Release Vehicle AND Sync Odometer
                        // Fixed: Updates CurrentOdometerReading to match the inspection results
                        string updateVehicle = @"UPDATE Vehicles SET 
                                        CurrentStatus = 'Available', 
                                        CurrentOdometerReading = @mIn 
                                        WHERE VIN = @vin";

                        using (var cmd = new MySqlCommand(updateVehicle, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@mIn", mileageIn);
                            cmd.Parameters.AddWithValue("@vin", vin);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        await trans.CommitAsync();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        await trans.RollbackAsync();
                        Console.WriteLine($"Migration Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public async Task<int> GetVehicleMileage(string vin)
        {
            int currentMileage = 0;
            string query = "SELECT CurrentOdometerReading FROM Vehicles WHERE VIN = @vin";

            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vin", vin);
                    var result = await cmd.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        currentMileage = Convert.ToInt32(result);
                    }
                }
            }
            return currentMileage;
        }
    }
}