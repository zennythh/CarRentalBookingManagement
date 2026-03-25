    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.UserControls {
    using Guna.UI2.WinForms;
    using Org.BouncyCastle.Asn1.Cmp;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class ucLoadingOverlay : UserControl {
        public ucLoadingOverlay() {
            InitializeComponent();
            //this.Resize += (s, e) => CenterControls();
        }

        private void CenterControls() {
            progressBar.Location = new Point(
                (this.Width - progressBar.Width) / 2,
                (this.Height - progressBar.Height) / 2
            );
        }

        public void ShowLoading(Control parent) {
            if (!parent.Controls.Contains(this)) {
                parent.Controls.Add(this);
            }

            this.Dock = DockStyle.Fill; 
            this.BringToFront();        
            this.Visible = true;
            //CenterControls();
        }

        public void HideLoading() {
            this.Visible = false;
        }
    }
}
