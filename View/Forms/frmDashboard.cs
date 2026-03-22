using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using MySql.Data.MySqlClient;

namespace Dshboard
{
    public partial class DashBoardForm : Form
    {
        string connStr = "server=mysql-car-rental-ravenakira22-d25a.j.aivencloud.com;port=10681;database=testDb;uid=avnadmin;pwd=AVNS_KkSsK8DVbXftqWP322A;";

        private Timer pollingTimer;
        private string currentPeriod = "Monthly";
        private bool isRefreshing = false;
        private int lastBookingId = 0;
        private int lastVehicleCount = 0;

        public DashBoardForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(900, 600);
            this.SizeChanged += DashBoardForm_SizeChanged;
        }

        private async void DashBoardForm_Load(object sender, EventArgs e)
        {
            await LoadKPIsAsync();
            await LoadGraphAsync(currentPeriod);
            await LoadPieChartAsync();

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
            {
                this.Invoke((MethodInvoker)delegate { action(); });
            }
        }

        //  RESPONSIVE

        private void DashBoardForm_SizeChanged(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            int w = guna2Panel1.Width;
            int h = guna2Panel1.Height;

            int margin = 26;
            int cardHeight = 103;
            int gap = 10;

            //  CARD WIDTH: 4 
            int totalCardWidth = w - (margin * 2) - (gap * 3);
            int cardW = totalCardWidth / 4;

            int headerY = 21;
            int topCardY = 95;
            int chartY = topCardY + cardHeight + 15;
            int chartH = h - chartY - cardHeight - 40;
            int bottomCardY = chartY + chartH + 15;

            if (chartH < 150) chartH = 150;

            // ── HEADER ──
            headerPanel.Location = new Point(margin, headerY);
            headerPanel.Size = new Size(w - (margin * 2), 60);

            // TOP CARDS
            revenuePnl.Location = new Point(margin, topCardY);
            revenuePnl.Size = new Size(cardW, cardHeight);

            activerentPnl.Location = new Point(margin + (cardW + gap), topCardY);
            activerentPnl.Size = new Size(cardW, cardHeight);

            availablePnl.Location = new Point(margin + (cardW + gap) * 2, topCardY);
            availablePnl.Size = new Size(cardW, cardHeight);

            reservedPnl.Location = new Point(margin + (cardW + gap) * 3, topCardY);
            reservedPnl.Size = new Size(cardW, cardHeight);

            // CHART PANELS
            int chartPanelW = (int)(w * 0.56) - margin;
            int piePanelW = w - margin - chartPanelW - gap - margin;

            // Revenue chart Panel
            guna2CustomGradientPanel4.Location = new Point(margin, chartY);
            guna2CustomGradientPanel4.Size = new Size(chartPanelW, chartH);

            // Revenue chart 
            revenueChart.Location = new Point(15, 55);
            revenueChart.Size = new Size(chartPanelW - 25, chartH - 65);

            // Pie chart Panel
            distributionPnl.Location = new Point(margin + chartPanelW + gap, chartY);
            distributionPnl.Size = new Size(piePanelW, chartH);

            // Pie chart 
            pieChart1.Location = new Point(0, 0);
            pieChart1.Size = new Size(piePanelW, chartH);

            // BOTTOM CARDS
            maintenancePnl.Location = new Point(margin, bottomCardY);
            maintenancePnl.Size = new Size(cardW, cardHeight);

            outofservicePnl.Location = new Point(margin + (cardW + gap), bottomCardY);
            outofservicePnl.Size = new Size(cardW, cardHeight);

            mostrentedPnl.Location = new Point(margin + (cardW + gap) * 2, bottomCardY);
            mostrentedPnl.Size = new Size(cardW, cardHeight);

            completedPnl.Location = new Point(margin + (cardW + gap) * 3, bottomCardY);
            completedPnl.Size = new Size(cardW, cardHeight);

            // REPOSITION ICONS INSIDE CARDS
            RepositionCardIcons(revenuePnl, guna2PictureBox2, totalRevenuelbl);
            RepositionCardIcons(activerentPnl, guna2PictureBox1, activeRentalslbl);
            RepositionCardIcons(availablePnl, guna2PictureBox5, AvailableCarslbl);
            RepositionCardIcons(reservedPnl, guna2PictureBox3, ReservedCarslbl);
            RepositionCardIcons(maintenancePnl, guna2PictureBox4, InMaintenancelbl);
            RepositionCardIcons(outofservicePnl, guna2PictureBox6, OutOfServicelbl);
            RepositionCardIcons(mostrentedPnl, guna2PictureBox7, MostRentedCarlbl);
            RepositionCardIcons(completedPnl, guna2PictureBox8, CompletedRentalslbl);

            // REPOSITION BUTTONS
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

  
        private async Task<int> GetLatestBookingIdAsync()
        {
            return await Task.Run(() =>
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();
                    return Convert.ToInt32(new MySqlCommand(
                        "SELECT IFNULL(MAX(BookingID), 0) FROM Bookings", conn).ExecuteScalar());
                }
            });
        }

        private async Task<int> GetVehicleCountAsync()
        {
            return await Task.Run(() =>
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();
                    return Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles", conn).ExecuteScalar());
                }
            });
        }

        private async void PollingTimer_Tick(object sender, EventArgs e)
        {
            if (isRefreshing) return;

            int newBookingId = await GetLatestBookingIdAsync();
            int newVehicleCount = await GetVehicleCountAsync();

            if (newBookingId != lastBookingId || newVehicleCount != lastVehicleCount)
            {
                isRefreshing = true;
                lastBookingId = newBookingId;
                lastVehicleCount = newVehicleCount;

                try
                {
                    await LoadKPIsAsync();
                    await LoadGraphAsync(currentPeriod);
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

                    double totalRevenue = Convert.ToDouble(new MySqlCommand(@"
                        SELECT IFNULL(SUM(TotalPrice), 0)
                        FROM Bookings
                        WHERE Status = 'Completed'
                          AND Deleted = 0
                    ", conn).ExecuteScalar());

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
                        SELECT CarName, COUNT(*) AS RentalCount
                        FROM (
                            SELECT CONCAT(v.Manufacturer, ' ', v.Model) AS CarName
                            FROM Bookings b
                            JOIN Vehicles v ON b.VehicleVIN = v.VIN
                            WHERE b.Status IN ('Out', 'Completed')
                              AND b.Deleted = 0

                            UNION ALL

                            SELECT vehicle AS CarName
                            FROM KioskBookings
                        ) AS CombinedBookings
                        GROUP BY CarName
                        ORDER BY RentalCount DESC
                        LIMIT 1";

                    using (var cmd = new MySqlCommand(mostRentedQuery, conn))
                    {
                        var result = cmd.ExecuteScalar();
                        mostRentedCar = result?.ToString() ?? "N/A";
                    }

                    SafeInvoke(() =>
                    {
                        totalRevenuelbl.Text = "₱" + totalRevenue.ToString("N2");
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

        //  PIE CHART

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
                    value = Convert.ToInt32(new MySqlCommand(query, conn).ExecuteScalar());
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

        //  REVENUE CHART

        private async Task LoadGraphAsync(string period)
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
                        query = @"
                            SELECT
                                DATE_FORMAT(DATE(DateDue), '%b %d') AS dateLabel,
                                SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status = 'Completed'
                              AND Deleted = 0
                              AND DateDue IS NOT NULL
                            GROUP BY DATE(DateDue)
                            ORDER BY DATE(DateDue)
                        ";
                    }
                    else if (period == "Weekly")
                    {
                        query = @"
                            SELECT
                                CONCAT(
                                    DATE_FORMAT(DATE_SUB(MIN(DateDue), INTERVAL WEEKDAY(MIN(DateDue)) DAY), '%b %d'),
                                    ' - ',
                                    DATE_FORMAT(DATE_ADD(DATE_SUB(MIN(DateDue), INTERVAL WEEKDAY(MIN(DateDue)) DAY), INTERVAL 6 DAY), '%b %d')
                                ) AS dateLabel,
                                SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status = 'Completed'
                              AND Deleted = 0
                              AND DateDue IS NOT NULL
                            GROUP BY YEAR(DateDue), WEEK(DateDue, 1)
                            ORDER BY YEAR(DateDue), WEEK(DateDue, 1)
                        ";
                    }
                    else
                    {
                        query = @"
                            SELECT
                                DATE_FORMAT(MIN(DateDue), '%b %Y') AS dateLabel,
                                SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status = 'Completed'
                              AND Deleted = 0
                              AND DateDue IS NOT NULL
                            GROUP BY YEAR(DateDue), MONTH(DateDue)
                            ORDER BY YEAR(DateDue), MONTH(DateDue)
                        ";
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

                if (period == "Daily")
                {
                    series.Add(new LineSeries
                    {
                        Title = "Daily Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true,
                        PointGeometrySize = 8
                    });
                }
                else if (period == "Weekly")
                {
                    series.Add(new LineSeries
                    {
                        Title = "Weekly Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true,
                        PointGeometrySize = 8
                    });
                }
                else
                {
                    series.Add(new ColumnSeries
                    {
                        Title = "Monthly Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true
                    });
                }

                revenueChart.Series = series;
                revenueChart.AxisX.Clear();
                revenueChart.AxisX.Add(new Axis { Labels = labels });
                revenueChart.AxisY.Clear();
                revenueChart.AxisY.Add(new Axis
                {
                    LabelFormatter = val => "₱" + val.ToString("N0"),
                    MinValue = 0
                });
            });
        }

        //  BUTTONS

        private async void btnDaily_Click(object sender, EventArgs e)
        {
            currentPeriod = "Daily";
            await LoadGraphAsync(currentPeriod);
        }

        private async void btnWeekly_Click(object sender, EventArgs e)
        {
            currentPeriod = "Weekly";
            await LoadGraphAsync(currentPeriod);
        }

        private async void btnMonthly_Click(object sender, EventArgs e)
        {
            currentPeriod = "Monthly";
            await LoadGraphAsync(currentPeriod);
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
    }
}