namespace ProjectForPervasive.Forms
{
	partial class UserInformation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.lastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastName.Location = new System.Drawing.Point(116, 108);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(106, 25);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(252, 47);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(239, 30);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAge.Location = new System.Drawing.Point(252, 159);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(239, 30);
            this.txtAge.TabIndex = 3;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.Transparent;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.age.Location = new System.Drawing.Point(116, 166);
            this.age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(48, 25);
            this.age.TabIndex = 2;
            this.age.Text = "Age";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.Location = new System.Drawing.Point(252, 105);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(239, 30);
            this.txtLastName.TabIndex = 5;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.Color.Transparent;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstName.Location = new System.Drawing.Point(116, 54);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(106, 25);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "First Name";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGender.Location = new System.Drawing.Point(252, 214);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(239, 30);
            this.txtGender.TabIndex = 7;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gender.Location = new System.Drawing.Point(116, 222);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(77, 25);
            this.gender.TabIndex = 6;
            this.gender.Text = "Gender";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(741, 210);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(239, 30);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneNumber.Location = new System.Drawing.Point(576, 218);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(143, 25);
            this.phoneNumber.TabIndex = 14;
            this.phoneNumber.Text = "Phone Number";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCity.Location = new System.Drawing.Point(741, 101);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(239, 30);
            this.txtCity.TabIndex = 13;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.city.Location = new System.Drawing.Point(576, 108);
            this.city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(46, 25);
            this.city.TabIndex = 12;
            this.city.Text = "City";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(741, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email.Location = new System.Drawing.Point(576, 162);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 25);
            this.email.TabIndex = 10;
            this.email.Text = "Email";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCountry.Location = new System.Drawing.Point(741, 43);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(239, 30);
            this.txtCountry.TabIndex = 9;
            this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.BackColor = System.Drawing.Color.Transparent;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.country.Location = new System.Drawing.Point(576, 50);
            this.country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(81, 25);
            this.country.TabIndex = 8;
            this.country.Text = "Country";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(867, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserClear
            // 
            this.btnUserClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUserClear.Location = new System.Drawing.Point(727, 277);
            this.btnUserClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(116, 41);
            this.btnUserClear.TabIndex = 17;
            this.btnUserClear.Text = "Clear";
            this.btnUserClear.UseVisualStyleBackColor = true;
            this.btnUserClear.Click += new System.EventHandler(this.btnUserClear_Click);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUserCancel.Location = new System.Drawing.Point(581, 277);
            this.btnUserCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(116, 41);
            this.btnUserCancel.TabIndex = 18;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 375);
            this.Controls.Add(this.btnUserCancel);
            this.Controls.Add(this.btnUserClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.city);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.country);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.age);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lastName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInformation";
            this.Text = "UserInformation";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label age;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label firstName;
		private System.Windows.Forms.TextBox txtGender;
		private System.Windows.Forms.Label gender;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label phoneNumber;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label city;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label country;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnUserClear;
		private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}