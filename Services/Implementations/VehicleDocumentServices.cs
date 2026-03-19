using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.Services.Implementations {
    internal class VehicleDocumentServices {
        public void AddVehicleDocument(VehicleDocumentDto doc) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                conn.Open();

                string sql = @"
            INSERT INTO VehicleDocuments (
                VehiclePlateNum,
                DocumentTitle,
                Category,
                IssuingAuthority,
                IssueDate,
                ExpirationDate,
                FilePath,
                FileExtension,
                IsActive
            ) 
            VALUES (
                @plate,
                @title,
                @category,
                @authority,
                @issueDate,
                @expDate,
                @path,
                @ext,
                @isActive
            );";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@plate", doc.VehiclePlateNum);
                    cmd.Parameters.AddWithValue("@title", doc.Title);
                    cmd.Parameters.AddWithValue("@category", doc.Category);
                    cmd.Parameters.AddWithValue("@authority", doc.IssuingAuthority);
                    cmd.Parameters.AddWithValue("@issueDate", doc.IssueDate);

                    cmd.Parameters.AddWithValue("@expDate", (object)doc.ExpirationDate ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@path", doc.FilePath);
                    cmd.Parameters.AddWithValue("@ext", doc.Extension);
                    cmd.Parameters.AddWithValue("@isActive", 1); 

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<VehicleDocumentDto> GetDocumentsByPlateNumber(string plateNumber) {
            List<VehicleDocumentDto> documents = new List<VehicleDocumentDto>();

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                conn.Open();
                string sql = @"
                        SELECT 
                            VehiclePlateNum, DocumentTitle, Category, IssuingAuthority, 
                            IssueDate, ExpirationDate, FilePath, FileExtension 
                        FROM VehicleDocuments 
                        WHERE VehiclePlateNum = @plate AND IsActive = 1
                        ORDER BY DateUploaded DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@plate", plateNumber);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            documents.Add(new VehicleDocumentDto {
                                VehiclePlateNum = reader["VehiclePlateNum"].ToString(),
                                Title = reader["DocumentTitle"].ToString(),
                                Category = reader["Category"].ToString(),
                                IssuingAuthority = reader["IssuingAuthority"].ToString(),
                                IssueDate = Convert.ToDateTime(reader["IssueDate"]),

                                // Handle DBNull for ExpirationDate
                                ExpirationDate = reader["ExpirationDate"] == DBNull.Value
                                                 ? (DateTime?)null
                                                 : Convert.ToDateTime(reader["ExpirationDate"]),

                                FilePath = reader["FilePath"].ToString(),
                                Extension = reader["FileExtension"].ToString()
                            });
                        }
                    }
                }
            }
            return documents;
        }
    }
}
