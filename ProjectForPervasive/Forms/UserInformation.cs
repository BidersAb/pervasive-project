using ProjectForPervasive.Model;
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
	public partial class UserInformation : Form
	{
		public static string FirstNam ="";
		public static string LastName ="";
		public static string Age ="";
		public static string Gender ="";
		public static string City="";
		public static string Country ="";
		public static string Email ="";
		public static string PhoneNumber = "";

		public UserInformation()
		{
			InitializeComponent();
		}

		private void UserInformation_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
				UserRegistor();

			}
			
		}
		public void UserRegistor()
        {
			FirstNam = txtFirstName.Text;
			LastName = txtLastName.Text;
			Age = txtAge.Text;
			Gender = txtGender.Text;
			City = txtCity.Text;
			Country = txtCountry.Text;
			Email = txtCountry.Text;
			PhoneNumber = txtPhoneNumber.Text;
			Profile profile = new Profile()
			{
				FirstName = txtFirstName.Text,
				LastName = txtLastName.Text,
				Age = txtAge.Text,
				Gender = txtGender.Text
			};
			var address = new Address()
			{
				City = txtCity.Text,
				Country = txtCountry.Text,
				Email = txtEmail.Text,
				PhoneNumber = phoneNumber.Text,
			};

			User user = new User(profile, address);
			Form dashboard = new Dashboard();
			dashboard.ShowDialog();
			dashboard.Close();
			this.Close();
		}
        private void btnUserClear_Click(object sender, EventArgs e)
        {
			txtFirstName.Text = "";
			txtLastName.Text = "";
			txtAge.Text = "";
			txtGender.Text = "";
			txtCountry.Text = "";
			txtCity.Text = "";
			txtEmail.Text = "";
			txtPhoneNumber.Text = "";
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
			if(string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtFirstName, "First Name is required");
            }
			else
            {
				e.Cancel = false;
				errorProvider1.SetError(txtFirstName, "");
            }
			if (string.IsNullOrWhiteSpace(txtLastName.Text))
			{
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtLastName, "Last Name is required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtLastName, "");
			}
			if (string.IsNullOrWhiteSpace(txtAge.Text))
			{
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtAge, "Age is required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtAge, "");
			}
			if (string.IsNullOrWhiteSpace(txtGender.Text))
			{
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtGender, "Gender is required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtGender, "");
			}
			if (string.IsNullOrWhiteSpace(txtCountry.Text))
			{
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtCountry, "Country is required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtCountry, "");
			}
			if (string.IsNullOrWhiteSpace(txtCity.Text))
			{
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtCity, "City is required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtCity, "");
			}
			if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
			{
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtPhoneNumber, "Phone Number is required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtPhoneNumber, "");
			}
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				e.Cancel = true;
				txtFirstName.Focus();
				errorProvider1.SetError(txtEmail, "Email is required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtEmail, "");
			}
		}

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
