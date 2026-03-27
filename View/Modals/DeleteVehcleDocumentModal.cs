using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Modals {
    public partial class DeleteVehcleDocumentModal : Form {
        VehicleDocumentDto _document;

        public DeleteVehcleDocumentModal(VehicleDocumentDto document) {
            InitializeComponent();
            _document = document;

            labelHeader.Text = "Deleting document of " + document.VehiclePlateNum;
            labelDocumentTitle.Text = document.Title;
            labelDocumentType.Text = document.Category;
            labelIssueDate.Text = document.IssueDate.ToString("d");
            labelExtension.Text = document.Extension.Replace('.', ' ').ToUpper().TrimStart();
            labelIssuingAuthority.Text = document.IssuingAuthority;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(inputReason.Text)) {
                MessageBox.Show("Reason is required.");
                return;
            }

            string message = $"Are you sure you want to delete this {_document.Category} document?";
            if (System.Windows.Forms.MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
