namespace ProjectForPervasive.Forms
{
	partial class WeatherForcast
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
			this.button1 = new System.Windows.Forms.Button();
			this.City = new System.Windows.Forms.TextBox();
			this.weatherPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.button1.Location = new System.Drawing.Point(323, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "ADD";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// City
			// 
			this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.City.Location = new System.Drawing.Point(49, 27);
			this.City.Name = "City";
			this.City.Size = new System.Drawing.Size(242, 31);
			this.City.TabIndex = 1;
			// 
			// weatherPanel
			// 
			this.weatherPanel.Location = new System.Drawing.Point(49, 190);
			this.weatherPanel.Name = "weatherPanel";
			this.weatherPanel.Size = new System.Drawing.Size(626, 224);
			this.weatherPanel.TabIndex = 2;
			// 
			// WeatherForcast
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 450);
			this.Controls.Add(this.weatherPanel);
			this.Controls.Add(this.City);
			this.Controls.Add(this.button1);
			this.Name = "WeatherForcast";
			this.Text = "WeatherForcast";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox City;
		private System.Windows.Forms.Panel weatherPanel;
	}
}