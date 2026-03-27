using PL_VehicleRental.Forms;
using PL_VehicleRental.Services.Security;
using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using VehicleManagementSystem.View.Forms;

namespace VehicleManagementSystem {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            while (true)
            {
                using (frmLogin login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                }

                using (frmMain mainForm = new frmMain())
                {
                    Application.Run(mainForm);

                    if (Session.User != null) break;
                }
            }
        }
    }
}
