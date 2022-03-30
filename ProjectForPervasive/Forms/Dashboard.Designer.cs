namespace ProjectForPervasive.Forms
{
	partial class Dashboard
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
			this.clock = new System.Windows.Forms.Timer(this.components);
			this.tempretureTimer = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.btnWeather = new System.Windows.Forms.Button();
			this.lblClock = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// clock
			// 
			this.clock.Interval = 1000;
			this.clock.Tick += new System.EventHandler(this.clock_Tick);
			// 
			// tempretureTimer
			// 
			this.tempretureTimer.Interval = 60000;
			this.tempretureTimer.Tick += new System.EventHandler(this.tempretureTimer_Tick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.button1.Location = new System.Drawing.Point(52, 135);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(165, 64);
			this.button1.TabIndex = 0;
			this.button1.Text = "Daily Scheduler";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnWeather
			// 
			this.btnWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.btnWeather.Location = new System.Drawing.Point(52, 63);
			this.btnWeather.Name = "btnWeather";
			this.btnWeather.Size = new System.Drawing.Size(165, 55);
			this.btnWeather.TabIndex = 1;
			this.btnWeather.Text = "Weather";
			this.btnWeather.UseVisualStyleBackColor = true;
			this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
			// 
			// lblClock
			// 
			this.lblClock.AutoSize = true;
			this.lblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblClock.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblClock.Location = new System.Drawing.Point(260, 97);
			this.lblClock.Name = "lblClock";
			this.lblClock.Size = new System.Drawing.Size(120, 31);
			this.lblClock.TabIndex = 4;
			this.lblClock.Text = "00:00:00";
			this.lblClock.Visible = false;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblDate.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblDate.Location = new System.Drawing.Point(500, 104);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(120, 31);
			this.lblDate.TabIndex = 5;
			this.lblDate.Text = "00:00:00";
			this.lblDate.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(260, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 31);
			this.label2.TabIndex = 6;
			this.label2.Text = "Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(509, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 31);
			this.label3.TabIndex = 7;
			this.label3.Text = "Date";
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblWelcome.Location = new System.Drawing.Point(153, 2);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(126, 31);
			this.lblWelcome.TabIndex = 18;
			this.lblWelcome.Text = "Welcome";
			this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.button2.Location = new System.Drawing.Point(52, 294);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(165, 62);
			this.button2.TabIndex = 19;
			this.button2.Text = "Voice Communication";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.button3.Location = new System.Drawing.Point(52, 215);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(165, 61);
			this.button3.TabIndex = 20;
			this.button3.Text = "Calendar Scheduler";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label11
			// 
			this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
			this.label11.Location = new System.Drawing.Point(655, 2);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(84, 26);
			this.label11.TabIndex = 17;
			this.label11.Text = "Log out";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 516);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblClock);
			this.Controls.Add(this.btnWeather);
			this.Controls.Add(this.button1);
			this.Name = "Dashboard";
			this.Text = "TaskSchedule";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer clock;
		private System.Windows.Forms.Timer tempretureTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label11;
	}
}