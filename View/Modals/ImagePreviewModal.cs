using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VehicleManagementSystem.View.Modals {
    public partial class ImagePreviewModal : Form {

        private WindowControls WindowActions;

        public ImagePreviewModal(string imageName, string imagePath) {
            InitializeComponent();
            WindowActions = new WindowControls(this);
            labelHeader.Text = imageName;

            LoadFileAsync(imageName, imagePath);
        }

        private async void LoadFileAsync(string imageName, string imagePath) {
            string extension = Path.GetExtension(imagePath).ToLower();

            if (extension == ".jpg" || extension == ".png" || extension == ".jpeg") {
                webView21.Visible = false;
                pictureBox.Image = System.Drawing.Image.FromFile(imagePath);
                pictureBox.BringToFront();
                pictureBox.Visible = true;
                return;
            }

            if (extension == ".pdf") {
                try {
                    pictureBox.Visible = false;
                    await webView21.EnsureCoreWebView2Async(null);

                    webView21.CoreWebView2.Profile.PreferredColorScheme =
                        Microsoft.Web.WebView2.Core.CoreWebView2PreferredColorScheme.Light;

                    webView21.CoreWebView2.Navigate(new Uri(imagePath).AbsoluteUri);

                    webView21.BringToFront();
                    webView21.Visible = true;
                } catch (Exception ex) {
                    MessageBox.Show("WebView2 Runtime is missing or corrupted. Please install it to view PDFs.");
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void maximizeBtn_Click(object sender, EventArgs e) {
            await WindowActions.ToggleMaximize(maximizeBtn);
        }
    }
}
