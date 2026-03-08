using PL_VehicleRental.Forms;
using System;
using System.Windows.Forms;
using VehicleManagementSystem.View.Forms;

namespace VehicleManagementSystem {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
