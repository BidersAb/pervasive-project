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
			this.button1 = new System.Windows.Forms.Button();
			this.btnWeather = new System.Windows.Forms.Button();
			this.panelDashbord = new System.Windows.Forms.Panel();
			this.btnShedule = new System.Windows.Forms.Button();
			this.lblClock = new System.Windows.Forms.Label();
			this.clock = new System.Windows.Forms.Timer(this.components);
			this.lblDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTempreture = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblLastUpdate = new System.Windows.Forms.Label();
			this.lblCondition = new System.Windows.Forms.Label();
			this.lblFahrenheit = new System.Windows.Forms.Label();
			this.lblCelsius = new System.Windows.Forms.Label();
			this.tempretureTimer = new System.Windows.Forms.Timer(this.components);
			this.imageWeather = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblCurrntCondition = new System.Windows.Forms.Label();
			this.lblCurrentFahrenheit = new System.Windows.Forms.Label();
			this.lblCurrentCelsius = new System.Windows.Forms.Label();
			this.panelDashbord.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageWeather)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.button1.Location = new System.Drawing.Point(510, 81);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 49);
			this.button1.TabIndex = 0;
			this.button1.Text = "Daily Schedule";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnWeather
			// 
			this.btnWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.btnWeather.Location = new System.Drawing.Point(510, 12);
			this.btnWeather.Name = "btnWeather";
			this.btnWeather.Size = new System.Drawing.Size(179, 49);
			this.btnWeather.TabIndex = 1;
			this.btnWeather.Text = "Weather";
			this.btnWeather.UseVisualStyleBackColor = true;
			this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
			// 
			// panelDashbord
			// 
			this.panelDashbord.Controls.Add(this.imageWeather);
			this.panelDashbord.Controls.Add(this.lblCurrntCondition);
			this.panelDashbord.Controls.Add(this.lblCurrentFahrenheit);
			this.panelDashbord.Controls.Add(this.lblCurrentCelsius);
			this.panelDashbord.Controls.Add(this.label7);
			this.panelDashbord.Controls.Add(this.label8);
			this.panelDashbord.Controls.Add(this.label9);
			this.panelDashbord.Controls.Add(this.label10);
			this.panelDashbord.Location = new System.Drawing.Point(31, 317);
			this.panelDashbord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelDashbord.Name = "panelDashbord";
			this.panelDashbord.Size = new System.Drawing.Size(492, 163);
			this.panelDashbord.TabIndex = 2;
			this.panelDashbord.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashbord_Paint);
			// 
			// btnShedule
			// 
			this.btnShedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.btnShedule.Location = new System.Drawing.Point(510, 150);
			this.btnShedule.Name = "btnShedule";
			this.btnShedule.Size = new System.Drawing.Size(179, 49);
			this.btnShedule.TabIndex = 3;
			this.btnShedule.Text = "Schedule";
			this.btnShedule.UseVisualStyleBackColor = true;
			this.btnShedule.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblClock
			// 
			this.lblClock.AutoSize = true;
			this.lblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblClock.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblClock.Location = new System.Drawing.Point(25, 65);
			this.lblClock.Name = "lblClock";
			this.lblClock.Size = new System.Drawing.Size(120, 31);
			this.lblClock.TabIndex = 4;
			this.lblClock.Text = "00:00:00";
			this.lblClock.Visible = false;
			this.lblClock.Click += new System.EventHandler(this.label1_Click);
			// 
			// clock
			// 
			this.clock.Interval = 1000;
			this.clock.Tick += new System.EventHandler(this.clock_Tick);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblDate.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblDate.Location = new System.Drawing.Point(263, 65);
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
			this.label2.Location = new System.Drawing.Point(25, 18);
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
			this.label3.Location = new System.Drawing.Point(273, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 31);
			this.label3.TabIndex = 7;
			this.label3.Text = "Date";
			// 
			// lblTempreture
			// 
			this.lblTempreture.AutoSize = true;
			this.lblTempreture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTempreture.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblTempreture.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblTempreture.Location = new System.Drawing.Point(25, 118);
			this.lblTempreture.Name = "lblTempreture";
			this.lblTempreture.Size = new System.Drawing.Size(154, 31);
			this.lblTempreture.TabIndex = 8;
			this.lblTempreture.Text = "Tempreture";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(61, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 24);
			this.label1.TabIndex = 9;
			this.label1.Text = "Celsius";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(61, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "Fahrenheit";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label5.Location = new System.Drawing.Point(61, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "Condition";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label6.Location = new System.Drawing.Point(61, 270);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Last Update";
			// 
			// lblLastUpdate
			// 
			this.lblLastUpdate.AutoSize = true;
			this.lblLastUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lblLastUpdate.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblLastUpdate.Location = new System.Drawing.Point(205, 270);
			this.lblLastUpdate.Name = "lblLastUpdate";
			this.lblLastUpdate.Size = new System.Drawing.Size(0, 24);
			this.lblLastUpdate.TabIndex = 16;
			// 
			// lblCondition
			// 
			this.lblCondition.AutoSize = true;
			this.lblCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lblCondition.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCondition.Location = new System.Drawing.Point(205, 163);
			this.lblCondition.Name = "lblCondition";
			this.lblCondition.Size = new System.Drawing.Size(0, 24);
			this.lblCondition.TabIndex = 15;
			// 
			// lblFahrenheit
			// 
			this.lblFahrenheit.AutoSize = true;
			this.lblFahrenheit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lblFahrenheit.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblFahrenheit.Location = new System.Drawing.Point(205, 198);
			this.lblFahrenheit.Name = "lblFahrenheit";
			this.lblFahrenheit.Size = new System.Drawing.Size(0, 24);
			this.lblFahrenheit.TabIndex = 14;
			// 
			// lblCelsius
			// 
			this.lblCelsius.AutoSize = true;
			this.lblCelsius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lblCelsius.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCelsius.Location = new System.Drawing.Point(205, 233);
			this.lblCelsius.Name = "lblCelsius";
			this.lblCelsius.Size = new System.Drawing.Size(0, 24);
			this.lblCelsius.TabIndex = 13;
			// 
			// tempretureTimer
			// 
			this.tempretureTimer.Interval = 60000;
			this.tempretureTimer.Tick += new System.EventHandler(this.tempretureTimer_Tick);
			// 
			// imageWeather
			// 
			this.imageWeather.Location = new System.Drawing.Point(350, 50);
			this.imageWeather.Name = "imageWeather";
			this.imageWeather.Size = new System.Drawing.Size(95, 96);
			this.imageWeather.TabIndex = 17;
			this.imageWeather.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label7.Location = new System.Drawing.Point(37, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 24);
			this.label7.TabIndex = 15;
			this.label7.Text = "Condition";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label8.Location = new System.Drawing.Point(37, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 24);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fahrenheit";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label9.Location = new System.Drawing.Point(37, 122);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 24);
			this.label9.TabIndex = 13;
			this.label9.Text = "Celsius";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label10.Location = new System.Drawing.Point(110, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(252, 31);
			this.label10.TabIndex = 12;
			this.label10.Text = "Current Tempreture";
			// 
			// lblCurrntCondition
			// 
			this.lblCurrntCondition.AutoSize = true;
			this.lblCurrntCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurrntCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lblCurrntCondition.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCurrntCondition.Location = new System.Drawing.Point(175, 52);
			this.lblCurrntCondition.Name = "lblCurrntCondition";
			this.lblCurrntCondition.Size = new System.Drawing.Size(0, 24);
			this.lblCurrntCondition.TabIndex = 19;
			// 
			// lblCurrentFahrenheit
			// 
			this.lblCurrentFahrenheit.AutoSize = true;
			this.lblCurrentFahrenheit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurrentFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lblCurrentFahrenheit.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCurrentFahrenheit.Location = new System.Drawing.Point(175, 87);
			this.lblCurrentFahrenheit.Name = "lblCurrentFahrenheit";
			this.lblCurrentFahrenheit.Size = new System.Drawing.Size(0, 24);
			this.lblCurrentFahrenheit.TabIndex = 18;
			// 
			// lblCurrentCelsius
			// 
			this.lblCurrentCelsius.AutoSize = true;
			this.lblCurrentCelsius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurrentCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lblCurrentCelsius.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCurrentCelsius.Location = new System.Drawing.Point(175, 122);
			this.lblCurrentCelsius.Name = "lblCurrentCelsius";
			this.lblCurrentCelsius.Size = new System.Drawing.Size(0, 24);
			this.lblCurrentCelsius.TabIndex = 17;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 491);
			this.Controls.Add(this.lblLastUpdate);
			this.Controls.Add(this.lblCondition);
			this.Controls.Add(this.lblFahrenheit);
			this.Controls.Add(this.lblCelsius);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTempreture);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblClock);
			this.Controls.Add(this.btnShedule);
			this.Controls.Add(this.panelDashbord);
			this.Controls.Add(this.btnWeather);
			this.Controls.Add(this.button1);
			this.Name = "Dashboard";
			this.Text = "TaskSchedule";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panelDashbord.ResumeLayout(false);
			this.panelDashbord.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageWeather)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Panel panelDashbord;
		private System.Windows.Forms.Button btnShedule;
		private System.Windows.Forms.Label lblClock;
		private System.Windows.Forms.Timer clock;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTempreture;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblLastUpdate;
		private System.Windows.Forms.Label lblCondition;
		private System.Windows.Forms.Label lblFahrenheit;
		private System.Windows.Forms.Label lblCelsius;
		private System.Windows.Forms.Timer tempretureTimer;
		private System.Windows.Forms.PictureBox imageWeather;
		private System.Windows.Forms.Label lblCurrntCondition;
		private System.Windows.Forms.Label lblCurrentFahrenheit;
		private System.Windows.Forms.Label lblCurrentCelsius;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
	}
}