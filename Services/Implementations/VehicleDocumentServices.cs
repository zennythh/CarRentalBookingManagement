using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.Services.Implementations {
    public class VehicleDocumentServices {
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

        public void UpdateVehicleDocument(VehicleDocumentDto document) {
            using (var connection = MySQLConnectionContext.Create()) {
                string query = @"
                UPDATE VehicleDocuments 
                SET 
                    DocumentTitle = @Title, 
                    Category = @Category, 
                    IssuingAuthority = @IssuingAuthority, 
                    IssueDate = @IssueDate, 
                    ExpirationDate = @ExpirationDate, 
                    FilePath = @FilePath, 
                    FileExtension = @Extension
                WHERE DocumentID = @DocumentID AND IsActive = 1;";

                // UpdatedAt = NOW()


                using (var cmd = new MySqlCommand(query, connection)) {
                    cmd.Parameters.AddWithValue("@Title", document.Title);
                    cmd.Parameters.AddWithValue("@Category", document.Category);
                    cmd.Parameters.AddWithValue("@IssuingAuthority", document.IssuingAuthority);
                    cmd.Parameters.AddWithValue("@IssueDate", document.IssueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", (object)document.ExpirationDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FilePath", document.FilePath);
                    cmd.Parameters.AddWithValue("@Extension", document.Extension);
                    cmd.Parameters.AddWithValue("@DocumentID", document.DocumentID);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<VehicleDocumentDto> GetSearchedVehicleDocument(string searchQuery, string vehiclePlateNum) {
            var documents = new List<VehicleDocumentDto>();

            string search = string.IsNullOrWhiteSpace(searchQuery) ? null : $"%{searchQuery.Trim().ToLower()}%";
            string plate = vehiclePlateNum.Trim().ToLower();

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                conn.Open();

                string sql = @"
                    SELECT * FROM VehicleDocuments
                    WHERE LOWER(VehiclePlateNum) = @Plate 
                      AND IsActive = 1
                      AND (@Search IS NULL OR (
                          LOWER(Category) LIKE @Search OR 
                          LOWER(IssuingAuthority) LIKE @Search OR 
                          LOWER(DocumentTitle) LIKE @Search OR
                          LOWER(FileExtension) LIKE @Search
                      ))
                    ORDER BY DateUploaded DESC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@Search", (object)search ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Plate", plate);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            documents.Add(new VehicleDocumentDto {
                                DocumentID = reader.GetInt32("DocumentID"),
                                VehiclePlateNum = reader.GetString("VehiclePlateNum"),
                                Title = reader.GetString("DocumentTitle"),
                                Category = reader.GetString("Category"),
                                IssuingAuthority = reader.GetString("IssuingAuthority"),
                                IssueDate = reader.GetDateTime("IssueDate"),
                                // Handle nullable expiration date
                                ExpirationDate = reader.IsDBNull(reader.GetOrdinal("ExpirationDate"))
                                                 ? (DateTime?)null
                                                 : reader.GetDateTime("ExpirationDate"),
                                FilePath = reader.GetString("FilePath"),
                                Extension = reader.GetString("FileExtension"),
                            });
                        }
                    }
                }
            }
            return documents;
        }

        public void DeleteVehicleDocument(int documentId) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                conn.Open();

                string sql = @"UPDATE VehicleDocuments 
                       SET IsActive = 0 
                       WHERE DocumentID = @id;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@id", documentId);
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
                            DocumentID, VehiclePlateNum, DocumentTitle, Category, IssuingAuthority, 
                            IssueDate, ExpirationDate, FilePath, FileExtension 
                        FROM VehicleDocuments 
                        WHERE VehiclePlateNum = @plate AND IsActive = 1
                        ORDER BY DateUploaded DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@plate", plateNumber);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            documents.Add(new VehicleDocumentDto {
                                DocumentID = (int)reader["DocumentID"],
                                VehiclePlateNum = reader["VehiclePlateNum"].ToString(),
                                Title = reader["DocumentTitle"].ToString(),
                                Category = reader["Category"].ToString(),
                                IssuingAuthority = reader["IssuingAuthority"].ToString(),
                                IssueDate = Convert.ToDateTime(reader["IssueDate"]),

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
