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
		public UserInformation()
		{
			InitializeComponent();
		}

		private void UserInformation_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
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
				Country =txtCountry.Text,
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
    }
}
