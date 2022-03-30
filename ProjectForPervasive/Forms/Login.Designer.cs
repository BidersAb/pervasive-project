
namespace ProjectForPervasive.Forms
{
    partial class Login
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
            this.txtLogCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.txtLogEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtLogFullName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.lblFullNameLogin = new System.Windows.Forms.Label();
            this.errorLogIn = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogCity
            // 
            this.txtLogCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLogCity.Location = new System.Drawing.Point(362, 117);
            this.txtLogCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogCity.Name = "txtLogCity";
            this.txtLogCity.Size = new System.Drawing.Size(239, 30);
            this.txtLogCity.TabIndex = 22;
            this.txtLogCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogCity_Validating);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.city.Location = new System.Drawing.Point(254, 120);
            this.city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(46, 25);
            this.city.TabIndex = 21;
            this.city.Text = "City";
            // 
            // txtLogEmail
            // 
            this.txtLogEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLogEmail.Location = new System.Drawing.Point(362, 171);
            this.txtLogEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogEmail.Name = "txtLogEmail";
            this.txtLogEmail.Size = new System.Drawing.Size(239, 30);
            this.txtLogEmail.TabIndex = 20;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email.Location = new System.Drawing.Point(254, 175);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 25);
            this.email.TabIndex = 19;
            this.email.Text = "Email";
            // 
            // txtLogFullName
            // 
            this.txtLogFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLogFullName.Location = new System.Drawing.Point(362, 64);
            this.txtLogFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogFullName.Name = "txtLogFullName";
            this.txtLogFullName.Size = new System.Drawing.Size(239, 30);
            this.txtLogFullName.TabIndex = 29;
            this.txtLogFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogFullName_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(497, 234);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 41);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoginCancel.Location = new System.Drawing.Point(362, 234);
            this.btnLoginCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(100, 41);
            this.btnLoginCancel.TabIndex = 27;
            this.btnLoginCancel.Text = "Cancel";
            this.btnLoginCancel.UseVisualStyleBackColor = true;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // lblFullNameLogin
            // 
            this.lblFullNameLogin.AutoSize = true;
            this.lblFullNameLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblFullNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFullNameLogin.Location = new System.Drawing.Point(254, 69);
            this.lblFullNameLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullNameLogin.Name = "lblFullNameLogin";
            this.lblFullNameLogin.Size = new System.Drawing.Size(100, 25);
            this.lblFullNameLogin.TabIndex = 30;
            this.lblFullNameLogin.Text = "Full Name";
            // 
            // errorLogIn
            // 
            this.errorLogIn.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFullNameLogin);
            this.Controls.Add(this.txtLogFullName);
            this.Controls.Add(this.btnLoginCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogCity);
            this.Controls.Add(this.city);
            this.Controls.Add(this.txtLogEmail);
            this.Controls.Add(this.email);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorLogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogCity;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox txtLogEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtLogFullName;
       // private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.Label lblFullNameLogin;
        private System.Windows.Forms.ErrorProvider errorLogIn;
    }
}