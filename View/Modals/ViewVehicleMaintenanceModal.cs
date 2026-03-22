using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Modals {
    public partial class ViewVehicleMaintenanceModal : Form {
        VehicleMaintenanceScheduleDto _schedule;

        public ViewVehicleMaintenanceModal(VehicleMaintenanceScheduleDto schedule) {
            _schedule = schedule;
            InitializeComponent();

            if(schedule.ScheduleType == "OneTime") {
                panelIntervalSettings.Visible = false;
                panelDueSettings.Visible = true;
                saveBtn.Text = "Mark as complete";
            } else {
                panelDueSettings.Visible=false;
                panelIntervalSettings.Visible=true;
                saveBtn.Text = "Mark as complete";
            }

            labelHeader.Text = $"{schedule.ScheduleType} - {schedule.MaintenanceName}";

            labelScheduleType.Text = "High";
            //labelPriority.Text = schedule.IsUpcoming ? "Upcoming" : schedule.IsDueSoon ? "Due soon" : "Over due";
            labelMaintenanceType.Text = schedule.IsUpcoming ? "Upcoming" : schedule.IsDueSoon ? "Due soon" : "Over due";

            inputDueDate.Value = schedule?.DueDate ?? DateTime.Today;
            inputDueMileige.Text = schedule?.DueMileage.ToString() ?? "";
            inputMilleageInterval.Text = schedule?.MileageInterval.ToString() ?? "";
            inputMonthlyInterval.Text = schedule?.MonthInterval.ToString() ?? "";

            maintenanceCardControl.Bind(schedule);
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }

        private void saveBtn_Click(object sender, EventArgs e) {
            int currentMileage = (int)_schedule.CurrentVehicleMileage;
            DateTime completionDate = DateTime.Now;

            MarkMaintenanceAsComplete(_schedule);

            MessageBox.Show("Schedule has been set as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void MarkMaintenanceAsComplete(VehicleMaintenanceScheduleDto schedule) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql;
                DateTime completionDate = DateTime.Now;

                if (schedule.ScheduleType == "OneTime") {
                    // One-time tasks are archived with a Completed status
                    sql = @"UPDATE VehicleMaintenanceSchedules 
                    SET Status = 'Completed', 
                        CompletedDate = @Date, 
                        LastServiceMileage = @Mileage 
                    WHERE ScheduleID = @Id;";
                } else {
                    // Recurrent tasks stay 'Active' but reset their baseline
                    sql = @"UPDATE VehicleMaintenanceSchedules 
                    SET LastServiceDate = @Date, 
                        LastServiceMileage = @Mileage 
                    WHERE ScheduleID = @Id;";
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@Id", schedule.ScheduleID);
                    cmd.Parameters.AddWithValue("@Date", completionDate);
                    cmd.Parameters.AddWithValue("@Mileage", schedule.CurrentVehicleMileage);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {

            var result = MessageBox.Show($"Are you sure you want to stop tracking '{_schedule.MaintenanceName}' for this vehicle?",
                                         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                try {
                    UpdateScheduleActiveStatus(_schedule.ScheduleID, 0);


                    MessageBox.Show("Schedule removed from active maintenance.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } catch (Exception ex) {
                    MessageBox.Show($"Error removing task: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void UpdateScheduleActiveStatus(int scheduleId, int isActive) {
            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                string sql = "UPDATE VehicleMaintenanceSchedules SET IsActive = @isActive WHERE ScheduleID = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    cmd.Parameters.AddWithValue("@id", scheduleId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
