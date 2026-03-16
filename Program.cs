using PL_VehicleRental.Forms;
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

            frmMain mainForm = new frmMain();

            var context = new ApplicationContext(mainForm);

            //Application.Run(context);

            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    mainForm.Show();
                    Application.Run(context);
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
