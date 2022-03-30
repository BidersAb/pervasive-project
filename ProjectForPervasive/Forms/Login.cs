using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForPervasive.Forms
{
    public partial class Login : Form
    {
        public static string FullName = "";
        public static string City = "";
        public static string Email = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FullName = txtLogFullName.Text;
                City = txtLogCity.Text;
                Email = txtLogEmail.Text;
                Form dashboard = new Dashboard();
                dashboard.ShowDialog();
                dashboard.Close();
                this.Close();
            }
        }
        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtLogFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogFullName.Text))
            {
                e.Cancel = true;
                txtLogFullName.Focus();
                errorLogIn.SetError(txtLogFullName, "First Name is required");
            }
            else
            {
                e.Cancel = false;
                errorLogIn.SetError(txtLogFullName, "");
            }
        }

        private void txtLogCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogCity.Text))
            {
                e.Cancel = true;
                txtLogCity.Focus();
                errorLogIn.SetError(txtLogCity, "First Name is required");
            }
            else
            {
                e.Cancel = false;
                errorLogIn.SetError(txtLogCity, "");
            }
        }
    }
}
