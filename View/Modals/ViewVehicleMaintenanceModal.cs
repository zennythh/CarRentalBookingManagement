using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            } else {
                panelDueSettings.Visible=false;
                panelIntervalSettings.Visible=true;
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
    }
}
