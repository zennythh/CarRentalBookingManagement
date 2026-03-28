using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using PL_VehicleRental.Services.Security;
using VehicleManagementSystem.Dto;
using MySqlConnector;

namespace VehicleManagementSystem {
    public partial class frmDashboard : Form
    {
        string connStr = "server=mysql-car-rental-ravenakira22-d25a.j.aivencloud.com;port=10681;database=testDb;uid=avnadmin;pwd=AVNS_KkSsK8DVbXftqWP322A;";

        private Timer pollingTimer;
        private string currentPeriod = "Monthly";
        private bool isRefreshing = false;
        private string lastBookingId;
        private int lastVehicleCount = 0;

        public frmDashboard()
        {
            InitializeComponent();
            this.MinimumSize = new Size(900, 600);
            this.SizeChanged += DashBoardForm_SizeChanged;
        }

        private bool HasRevenueAccess()
        {
            var role = Session.User?.Role;
            return role == UserRole.Superadmin || role == UserRole.Admin;
        }

        private async void DashBoardForm_Load(object sender, EventArgs e)
        {
            bool hasAccess = HasRevenueAccess();

            // Show cards and panels (always visible, just content changes)
            revenuePnl.Visible = true;
            guna2CustomGradientPanel4.Visible = true;

            await LoadKPIsAsync();
            await LoadPieChartAsync();

            if (hasAccess)
                await LoadGraphAsync(currentPeriod);
            else
                await LoadBookingGraphAsync(currentPeriod);

            lastBookingId = await GetLatestBookingIdAsync();
            lastVehicleCount = await GetVehicleCountAsync();

            pollingTimer = new Timer();
            pollingTimer.Interval = 3000;
            pollingTimer.Tick += PollingTimer_Tick;
            pollingTimer.Start();

            ResizeControls();
        }

        private void SafeInvoke(Action action)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
                this.Invoke((MethodInvoker)delegate { action(); });
        }

        private void DashBoardForm_SizeChanged(object sender, EventArgs e) => ResizeControls();

        private void ResizeControls()
        {
            int w = guna2Panel1.Width;
            int h = guna2Panel1.Height;

            int margin = 26;
            int cardHeight = 103;
            int gap = 10;

            int totalCardWidth = w - (margin * 2) - (gap * 3);
            int cardW = totalCardWidth / 4;

            int headerY = 21;
            int topCardY = 95;
            int chartY = topCardY + cardHeight + 15;
            int chartH = h - chartY - cardHeight - 40;
            int bottomCardY = chartY + chartH + 15;

            if (chartH < 150) chartH = 150;

            // Position cards
            headerPanel.Location = new Point(margin, headerY);
            headerPanel.Size = new Size(w - (margin * 2), 60);

            revenuePnl.Location = new Point(margin, topCardY);
            revenuePnl.Size = new Size(cardW, cardHeight);

            activerentPnl.Location = new Point(margin + (cardW + gap), topCardY);
            activerentPnl.Size = new Size(cardW, cardHeight);

            availablePnl.Location = new Point(margin + (cardW + gap) * 2, topCardY);
            availablePnl.Size = new Size(cardW, cardHeight);

            reservedPnl.Location = new Point(margin + (cardW + gap) * 3, topCardY);
            reservedPnl.Size = new Size(cardW, cardHeight);

            int chartPanelW = (int)(w * 0.56) - margin;
            int piePanelW = w - margin - chartPanelW - gap - margin;

            guna2CustomGradientPanel4.Location = new Point(margin, chartY);
            guna2CustomGradientPanel4.Size = new Size(chartPanelW, chartH);

            revenueChart.Location = new Point(15, 55);
            revenueChart.Size = new Size(chartPanelW - 25, chartH - 65);

            distributionPnl.Location = new Point(margin + chartPanelW + gap, chartY);
            distributionPnl.Size = new Size(piePanelW, chartH);

            pieChart1.Location = new Point(0, 0);
            pieChart1.Size = new Size(piePanelW, chartH);

            maintenancePnl.Location = new Point(margin, bottomCardY);
            maintenancePnl.Size = new Size(cardW, cardHeight);

            outofservicePnl.Location = new Point(margin + (cardW + gap), bottomCardY);
            outofservicePnl.Size = new Size(cardW, cardHeight);

            mostrentedPnl.Location = new Point(margin + (cardW + gap) * 2, bottomCardY);
            mostrentedPnl.Size = new Size(cardW, cardHeight);

            completedPnl.Location = new Point(margin + (cardW + gap) * 3, bottomCardY);
            completedPnl.Size = new Size(cardW, cardHeight);

            RepositionCardIcons(revenuePnl, guna2PictureBox2, totalRevenuelbl);
            RepositionCardIcons(activerentPnl, guna2PictureBox1, activeRentalslbl);
            RepositionCardIcons(availablePnl, guna2PictureBox5, AvailableCarslbl);
            RepositionCardIcons(reservedPnl, guna2PictureBox3, ReservedCarslbl);
            RepositionCardIcons(maintenancePnl, guna2PictureBox4, InMaintenancelbl);
            RepositionCardIcons(outofservicePnl, guna2PictureBox6, OutOfServicelbl);
            RepositionCardIcons(mostrentedPnl, guna2PictureBox7, MostRentedCarlbl);
            RepositionCardIcons(completedPnl, guna2PictureBox8, CompletedRentalslbl);

            int btnY = 12;
            int btnStart = (int)(chartPanelW * 0.22);
            int btnSpacing = 120;
            btnDaily.Location = new Point(btnStart, btnY);
            btnWeekly.Location = new Point(btnStart + btnSpacing, btnY);
            btnMonthly.Location = new Point(btnStart + btnSpacing * 2, btnY);
        }

        private void RepositionCardIcons(Control card, Control icon, Control valueLabel)
        {
            icon.Location = new Point(card.Width - icon.Width - 15,
                                      (card.Height - icon.Height) / 2);
            valueLabel.Location = new Point(valueLabel.Location.X,
                                            (card.Height - valueLabel.Height) / 2 + 5);
        }

        private async Task<string> GetLatestBookingIdAsync()
        {
            return await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "SELECT BookingID FROM Bookings ORDER BY BookingID DESC LIMIT 1", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "BK000";
                    }
                }
            });
        }

        private async Task<int> GetVehicleCountAsync()
        {
            return await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Vehicles", conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            });
        }

        private async void PollingTimer_Tick(object sender, EventArgs e)
        {
            if (isRefreshing) return;

            string newBookingId = await GetLatestBookingIdAsync();
            int newVehicleCount = await GetVehicleCountAsync();

            if (newBookingId != lastBookingId || newVehicleCount != lastVehicleCount)
            {
                isRefreshing = true;
                lastBookingId = newBookingId;
                lastVehicleCount = newVehicleCount;

                try
                {
                    await LoadKPIsAsync();
                    if (HasRevenueAccess())
                        await LoadGraphAsync(currentPeriod);
                    else
                        await LoadBookingGraphAsync(currentPeriod);
                    await LoadPieChartAsync();
                }
                finally
                {
                    isRefreshing = false;
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pollingTimer?.Stop();
            pollingTimer?.Dispose();
            base.OnFormClosed(e);
        }

        private async Task LoadKPIsAsync()
        {
            await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();

                    double totalRevenue = Convert.ToDouble(new MySqlCommand(
                        @"SELECT IFNULL(SUM(TotalPrice), 0)
                          FROM Bookings
                          WHERE Status = 'Completed' AND Deleted = 0", conn).ExecuteScalar());

                    int totalBookings = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Bookings WHERE Deleted = 0", conn).ExecuteScalar());

                    int activeRentals = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Rented'", conn).ExecuteScalar());

                    int reservedCars = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Bookings WHERE Status='Reserved'", conn).ExecuteScalar());

                    int inMaintenance = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='InMaintenance'", conn).ExecuteScalar());

                    int availableCars = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Available'", conn).ExecuteScalar());

                    int outOfService = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='OutOfService'", conn).ExecuteScalar());

                    int completedRentals = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Bookings WHERE Status='Completed' AND Deleted = 0", conn).ExecuteScalar());

                    string mostRentedCar = "N/A";
                    string mostRentedQuery = @"
                        SELECT CarName FROM (
                            SELECT CONCAT(v.Manufacturer,' ',v.Model) AS CarName,
                                   COUNT(*) AS RentalCount,
                                   MAX(b.DateDue) AS LatestBooking
                            FROM Bookings b
                            JOIN Vehicles v ON b.VehicleVIN=v.VIN
                            WHERE b.Status IN ('Out','Completed') AND b.Deleted=0
                            GROUP BY CarName
                            ORDER BY RentalCount DESC, LatestBooking DESC
                            LIMIT 1
                        ) AS sub";

                    using (MySqlCommand cmd = new MySqlCommand(mostRentedQuery, conn))
                    {
                        var result = cmd.ExecuteScalar();
                        mostRentedCar = result?.ToString() ?? "N/A";
                    }

                   SafeInvoke(() =>
{
    // Eto ang logic para sa unang card (Revenue vs Bookings)
    if (HasRevenueAccess())
    {
        // Admin View: Ipakita ang Revenue
        lblRevenueHeader.Text = "Total Revenue"; 
        totalRevenuelbl.Text = "₱" + totalRevenue.ToString("N2");
    }
    else
    {
        // Staff View: Ipakita ang Booking Count
        lblRevenueHeader.Text = "Total Bookings"; 
        totalRevenuelbl.Text = totalBookings.ToString();
    }

    // Ang mga sumusunod ay parehas lang para sa lahat ng roles
    activeRentalslbl.Text = activeRentals.ToString();
    ReservedCarslbl.Text = reservedCars.ToString();
    InMaintenancelbl.Text = inMaintenance.ToString();
    AvailableCarslbl.Text = availableCars.ToString();
    OutOfServicelbl.Text = outOfService.ToString();
    CompletedRentalslbl.Text = completedRentals.ToString();
    MostRentedCarlbl.Text = mostRentedCar;
});
                }
            });
        }

        // Staff graph: booking count
        private async Task LoadBookingGraphAsync(string period)
        {
            List<string> labels = new List<string>();
            List<double> values = new List<double>();

            await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();

                    string query = "";
                    if (period == "Daily")
                    {
                        query = @"SELECT DATE_FORMAT(DateDue,'%b %d') AS dateLabel, COUNT(*) AS bookingCount 
                          FROM Bookings WHERE Deleted=0 GROUP BY DATE(DateDue) ORDER BY DATE(DateDue)";
                    }
                    else if (period == "Weekly")
                    {
                        query = @"SELECT CONCAT(DATE_FORMAT(DATE_SUB(DateDue, INTERVAL WEEKDAY(DateDue) DAY), '%b %d'), ' - ', 
                          DATE_FORMAT(DATE_ADD(DateDue, INTERVAL (6 - WEEKDAY(DateDue)) DAY), '%b %d')) AS dateLabel, 
                          COUNT(*) AS bookingCount FROM Bookings WHERE Deleted=0 
                          GROUP BY YEAR(DateDue), WEEK(DateDue, 1) ORDER BY YEAR(DateDue), WEEK(DateDue, 1)";
                    }
                    else // Monthly
                    {
                        query = @"SELECT DATE_FORMAT(DateDue,'%b %Y') AS dateLabel, COUNT(*) AS bookingCount 
                          FROM Bookings WHERE Deleted=0 GROUP BY YEAR(DateDue), MONTH(DateDue) 
                          ORDER BY YEAR(DateDue), MONTH(DateDue)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labels.Add(reader["dateLabel"].ToString());
                            values.Add(Convert.ToDouble(reader["bookingCount"]));
                        }
                    }
                }
            });

            SafeInvoke(() =>
            {
                SeriesCollection series = new SeriesCollection();
                var chartSeries = (period == "Monthly") ? (Series)new ColumnSeries() : new LineSeries();

                chartSeries.Title = "Bookings";
                chartSeries.Values = new ChartValues<double>(values);
                chartSeries.DataLabels = true;

                series.Add(chartSeries);

                revenueChart.Series = series;
                revenueChart.AxisX.Clear();
                revenueChart.AxisX.Add(new Axis { Labels = labels });
                revenueChart.AxisY.Clear();
                revenueChart.AxisY.Add(new Axis
                {
                    Title = "Total Bookings",
                    LabelFormatter = val => val.ToString("N0") // No decimals for count
                });
            });
        }

        private async Task<PieSeries> CreateSeriesAsync(string title, string query,
            System.Windows.Media.Brush color)
        {
            int value = 0;
            await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        value = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            });

            return new PieSeries
            {
                Title = title,
                Values = new ChartValues<int> { value },
                DataLabels = true,
                LabelPoint = point => $"{point.Participation:P0}",
                Fill = color,
                Stroke = System.Windows.Media.Brushes.White,
                StrokeThickness = 2
            };
        }

        private async Task LoadPieChartAsync()
        {
            var seriesCollection = new SeriesCollection
            {
                await CreateSeriesAsync("Available",
                    "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Available'",
                    System.Windows.Media.Brushes.Green),

                await CreateSeriesAsync("Rented",
                    "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Rented'",
                    System.Windows.Media.Brushes.Blue),

                await CreateSeriesAsync("Reserved",
                    "SELECT COUNT(*) FROM Bookings WHERE Status='Reserved'",
                    System.Windows.Media.Brushes.Orange),

                await CreateSeriesAsync("Maintenance",
                    "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='InMaintenance'",
                    System.Windows.Media.Brushes.Gold),

                await CreateSeriesAsync("Out of Service",
                    "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='OutOfService'",
                    System.Windows.Media.Brushes.Red),

                await CreateSeriesAsync("Completed",
                    "SELECT COUNT(*) FROM Bookings WHERE Status='Completed'",
                    System.Windows.Media.Brushes.Purple)
            };

            SafeInvoke(() =>
            {
                pieChart1.Series = seriesCollection;
                pieChart1.LegendLocation = LegendLocation.Right;
            });
        }

        private async Task LoadGraphAsync(string period)
        {
            if (!HasRevenueAccess())
            {
                await LoadBookingGraphAsync(period);
                return;
            }

            List<string> labels = new List<string>();
            List<double> values = new List<double>();

            await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();

                    string query = "";

                    if (period == "Daily")
                    {
                        query = @"
                            SELECT DATE_FORMAT(DATE(DateDue),'%b %d') AS dateLabel,
                                   SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status='Completed' AND Deleted=0 AND DateDue IS NOT NULL
                            GROUP BY DATE(DateDue)
                            ORDER BY DATE(DateDue)";
                    }
                    else if (period == "Weekly")
                    {
                        query = @"
                            SELECT CONCAT(
                                DATE_FORMAT(DATE_SUB(MIN(DateDue),INTERVAL WEEKDAY(MIN(DateDue)) DAY),'%b %d'),
                                ' - ',
                                DATE_FORMAT(DATE_ADD(DATE_SUB(MIN(DateDue),INTERVAL WEEKDAY(MIN(DateDue)) DAY),INTERVAL 6 DAY),'%b %d')
                            ) AS dateLabel,
                            SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status='Completed' AND Deleted=0 AND DateDue IS NOT NULL
                            GROUP BY YEAR(DateDue), WEEK(DateDue,1)
                            ORDER BY YEAR(DateDue), WEEK(DateDue,1)";
                    }
                    else
                    {
                        query = @"
                            SELECT DATE_FORMAT(MIN(DateDue),'%b %Y') AS dateLabel,
                                   SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status='Completed' AND Deleted=0 AND DateDue IS NOT NULL
                            GROUP BY YEAR(DateDue), MONTH(DateDue)
                            ORDER BY YEAR(DateDue), MONTH(DateDue)";
                    }


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labels.Add(reader["dateLabel"].ToString());
                            values.Add(Convert.ToDouble(reader["revenue"]));
                        }
                    }
                }
            });

            SafeInvoke(() =>
            {
                SeriesCollection series = new SeriesCollection();
                if (period == "Monthly")
                {
                    series.Add(new ColumnSeries
                    {
                        Title = "Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true,
                        Fill = System.Windows.Media.Brushes.DodgerBlue
                    });
                }
                else
                {
                    series.Add(new LineSeries
                    {
                        Title = "Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true,
                        PointGeometrySize = 8,
                        Stroke = System.Windows.Media.Brushes.DodgerBlue,
                        Fill = System.Windows.Media.Brushes.Transparent
                    });
                }

                revenueChart.Series = series;
                revenueChart.AxisX.Clear();
                revenueChart.AxisX.Add(new Axis { Labels = labels });
                revenueChart.AxisY.Clear();
                revenueChart.AxisY.Add(new Axis
                {
                    LabelFormatter = val => "₱" + val.ToString("N2"),
                    MinValue = 0
                });
            });
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            currentPeriod = "Daily";
            if (HasRevenueAccess())
                LoadGraphAsync(currentPeriod);
            else
                LoadBookingGraphAsync(currentPeriod);
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            currentPeriod = "Weekly";
            if (HasRevenueAccess())
                LoadGraphAsync(currentPeriod);
            else
                LoadBookingGraphAsync(currentPeriod);
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            currentPeriod = "Monthly";
            if (HasRevenueAccess())
                LoadGraphAsync(currentPeriod);
            else
                LoadBookingGraphAsync(currentPeriod);
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e) { }
        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void guna2PictureBox2_Click(object sender, EventArgs e) { }
        private void activerentPnl_Paint(object sender, PaintEventArgs e) { }
        private void reservedPnl_Paint(object sender, PaintEventArgs e) { }
        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e) { }
        private void mostrentedPnl_Paint(object sender, PaintEventArgs e) { }
        private void availablePnl_Paint(object sender, PaintEventArgs e) { }
        private void outofservicePnl_Paint(object sender, PaintEventArgs e) { }
        private void distributionPnl_Paint(object sender, PaintEventArgs e) { }
        private void revenuePnl_Paint(object sender, PaintEventArgs e) { }
        private void revenueChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e) { }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e) { }
        private void InMaintenancelbl_Click(object sender, EventArgs e) { }
        private void btnExport_Click(object sender, EventArgs e) { }
    }
}