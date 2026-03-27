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
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.Presenters;

namespace VehicleManagementSystem.UserControls.MaintenanceTab {
    public partial class MaintenanceDashboard : UserControl, IMaintenanceDashboardView {
        MaintenanceDashboardPresenter _presenter;
        ucLoadingOverlay _loader;

        public MaintenanceDashboard() {
            InitializeComponent();
            InitializeFirstLoad();
        }

        private async void InitializeFirstLoad() {
            _presenter = new MaintenanceDashboardPresenter(this, new VehicleMaintenanceServices());
            _presenter.LoadDashbord();
            _presenter.LoadUrgents();
            _presenter.LoadUpcoming();
        }

        public void SetIsLoading(bool isLoading) {
            if (isLoading) {
                _loader.ShowLoading(this);
            } else {
                _loader.HideLoading();
            }
        }

        public void DisplayUrgents(List<VehicleMaintenanceScheduleDto> schedules) {
            tableLayoutUrgent.SuspendLayout();
            const int DocumentCardHeight = 73;
            int TableMainHeight = DocumentCardHeight * schedules.Count;

            tableLayoutUrgent.Controls.Clear();
            tableLayoutUrgent.RowStyles.Clear();
            tableLayoutUrgent.RowCount = 0;
            tableLayoutUrgent.Height = TableMainHeight;
            this.Height += (TableMainHeight);

            int col = 0;
            int row = 0;

            foreach (var schedule in schedules) {
                var card = new ucMaintenanceDashboard();
                card.Bind(schedule);
                card.Dock = DockStyle.Fill;

                tableLayoutUrgent.Controls.Add(card, col, row);

                row++;
            }

            tableLayoutUrgent.ResumeLayout();
        }

        public void DisplayUpcoming(List<VehicleMaintenanceScheduleDto> schedules) {
            tableLayoutUpcoming.SuspendLayout();
            const int DocumentCardHeight = 73;
            int TableMainHeight = DocumentCardHeight * schedules.Count;

            tableLayoutUpcoming.Controls.Clear();
            tableLayoutUpcoming.RowStyles.Clear();
            tableLayoutUpcoming.RowCount = 0;
            tableLayoutUpcoming.Height = TableMainHeight;
            this.Height += (TableMainHeight);

            int col = 0;
            int row = 0;

            foreach (var schedule in schedules) {
                var card = new ucMaintenanceDashboard();
                card.Bind(schedule);
                card.Dock = DockStyle.Fill;

                tableLayoutUpcoming.Controls.Add(card, col, row);

                row++;
            }

            tableLayoutUpcoming.ResumeLayout();
        }


        public void DisplayDashboard(List<VehicleMaintenanceScheduleDto> schedules) {
            int total = schedules.Count;
            int upcoming = schedules.Count(s => s.IsUpcoming);
            int dueSoon = schedules.Count(s => s.IsDueSoon);
            int overdue = schedules.Count(s => s.IsOverdue);

            labelTotalCount.Text = total.ToString();
            labelUpcomingCount.Text = upcoming.ToString();
            labelDueSoonCount.Text = dueSoon.ToString();
            labelOverDueCount.Text = overdue.ToString();

            DisplayMostUpcoming(schedules);
        }



        private void DisplayMostUpcoming(List<VehicleMaintenanceScheduleDto> schedules) {
            var mostUrgent = schedules
                .Where(s => s.Status == "Scheduled" && !s.IsOverdue)
                .OrderByDescending(s => s.MaintenanceProgressPercentage)
                .FirstOrDefault();

            if (mostUrgent == null) return;

            labelMostUpcomingName.Text = $"{mostUrgent.VehiclePlateNum} - {mostUrgent.MaintenanceName}";
            string dayUntil = mostUrgent.DaysUntilDue > 0
                ? $"{mostUrgent.DaysUntilDue} days remaining"
                : $"{Math.Abs(mostUrgent.DaysUntilDue ?? 0)} days have passed";

            labelMostUpcomingDetials.Text = mostUrgent.MilesUntilDue < mostUrgent.DaysUntilDue * 50
                ? $"{mostUrgent.MilesUntilDue:N0} km remaining"
                : dayUntil;
        }
    }
}
