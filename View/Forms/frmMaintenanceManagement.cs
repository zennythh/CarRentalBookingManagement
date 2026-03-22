using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.Forms {
    public partial class frmMaintenanceManagement : Form {
        public frmMaintenanceManagement() {
            InitializeComponent();
        }

        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void btnAddType_Click(object sender, EventArgs e) {
            using (var AddNewVehicleMaintenanceTypeModal = new AddNewVehicleMaintenanceTypeModal()) {
                AddNewVehicleMaintenanceTypeModal.ShowDialog();
            }
        }


    }
}
