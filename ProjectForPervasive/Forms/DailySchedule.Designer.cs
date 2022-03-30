
namespace ProjectForPervasive
{
    partial class formDailySchedule
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.timeStartDate = new System.Windows.Forms.DateTimePicker();
			this.panel = new System.Windows.Forms.Panel();
			this.timeEndDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelScheduleHeader = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnNewSchedule = new System.Windows.Forms.Button();
			this.btnAllSchedule = new System.Windows.Forms.Button();
			this.btnOldSchedule = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panelScheduleHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnAdd.Location = new System.Drawing.Point(645, 228);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(89, 38);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txtTitle.Location = new System.Drawing.Point(226, 79);
			this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(510, 37);
			this.txtTitle.TabIndex = 1;
			// 
			// timeStartDate
			// 
			this.timeStartDate.AllowDrop = true;
			this.timeStartDate.CustomFormat = "HH:mm";
			this.timeStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.timeStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.timeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeStartDate.Location = new System.Drawing.Point(226, 128);
			this.timeStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.timeStartDate.MaxDate = new System.DateTime(2022, 3, 15, 15, 31, 12, 88);
			this.timeStartDate.MinDate = new System.DateTime(2022, 3, 14, 15, 31, 12, 88);
			this.timeStartDate.Name = "timeStartDate";
			this.timeStartDate.Size = new System.Drawing.Size(510, 35);
			this.timeStartDate.TabIndex = 2;
			// 
			// panel
			// 
			this.panel.Location = new System.Drawing.Point(52, 342);
			this.panel.Margin = new System.Windows.Forms.Padding(2);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(682, 187);
			this.panel.TabIndex = 3;
			this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			// 
			// timeEndDate
			// 
			this.timeEndDate.CustomFormat = "HH:mm";
			this.timeEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.timeEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.timeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeEndDate.Location = new System.Drawing.Point(226, 176);
			this.timeEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.timeEndDate.MaxDate = new System.DateTime(2022, 3, 15, 15, 31, 12, 88);
			this.timeEndDate.MinDate = this.timeStartDate.Value;
			this.timeEndDate.Name = "timeEndDate";
			this.timeEndDate.Size = new System.Drawing.Size(510, 35);
			this.timeEndDate.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(117, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Sart Time";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(114, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(117, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "End Time";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnClose.Location = new System.Drawing.Point(532, 228);
			this.btnClose.Margin = new System.Windows.Forms.Padding(2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(87, 38);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panelScheduleHeader
			// 
			this.panelScheduleHeader.Controls.Add(this.button1);
			this.panelScheduleHeader.Controls.Add(this.btnNewSchedule);
			this.panelScheduleHeader.Controls.Add(this.btnAllSchedule);
			this.panelScheduleHeader.Controls.Add(this.btnOldSchedule);
			this.panelScheduleHeader.Location = new System.Drawing.Point(52, 286);
			this.panelScheduleHeader.Name = "panelScheduleHeader";
			this.panelScheduleHeader.Size = new System.Drawing.Size(680, 51);
			this.panelScheduleHeader.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.button1.Location = new System.Drawing.Point(472, -2);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(208, 55);
			this.button1.TabIndex = 12;
			this.button1.Text = "Voic Communication";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_2);
			// 
			// btnNewSchedule
			// 
			this.btnNewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnNewSchedule.Location = new System.Drawing.Point(2, 3);
			this.btnNewSchedule.Margin = new System.Windows.Forms.Padding(2);
			this.btnNewSchedule.Name = "btnNewSchedule";
			this.btnNewSchedule.Size = new System.Drawing.Size(153, 50);
			this.btnNewSchedule.TabIndex = 9;
			this.btnNewSchedule.Text = "New Schedule";
			this.btnNewSchedule.UseVisualStyleBackColor = true;
			this.btnNewSchedule.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAllSchedule
			// 
			this.btnAllSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnAllSchedule.Location = new System.Drawing.Point(315, 2);
			this.btnAllSchedule.Margin = new System.Windows.Forms.Padding(2);
			this.btnAllSchedule.Name = "btnAllSchedule";
			this.btnAllSchedule.Size = new System.Drawing.Size(138, 51);
			this.btnAllSchedule.TabIndex = 11;
			this.btnAllSchedule.Text = "All Schedule";
			this.btnAllSchedule.UseVisualStyleBackColor = true;
			this.btnAllSchedule.Click += new System.EventHandler(this.btnAllSchedule_Click);
			// 
			// btnOldSchedule
			// 
			this.btnOldSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnOldSchedule.Location = new System.Drawing.Point(159, 3);
			this.btnOldSchedule.Margin = new System.Windows.Forms.Padding(2);
			this.btnOldSchedule.Name = "btnOldSchedule";
			this.btnOldSchedule.Size = new System.Drawing.Size(142, 51);
			this.btnOldSchedule.TabIndex = 10;
			this.btnOldSchedule.Text = "Old Schedule";
			this.btnOldSchedule.UseVisualStyleBackColor = true;
			this.btnOldSchedule.Click += new System.EventHandler(this.btnOldSchedule_Click);
			// 
			// label11
			// 
			this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
			this.label11.Location = new System.Drawing.Point(-2, -1);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(57, 44);
			this.label11.TabIndex = 18;
			this.label11.Text = "←";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblWelcome.Location = new System.Drawing.Point(153, -1);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(126, 31);
			this.lblWelcome.TabIndex = 19;
			this.lblWelcome.Text = "Welcome";
			this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
			this.label4.Location = new System.Drawing.Point(701, 4);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 26);
			this.label4.TabIndex = 20;
			this.label4.Text = "Log out";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// formDailySchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(823, 526);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.panelScheduleHeader);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.timeEndDate);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.timeStartDate);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.btnAdd);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "formDailySchedule";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.formDailySchedule_Load);
			this.panelScheduleHeader.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker timeStartDate;
        private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.DateTimePicker timeEndDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panelScheduleHeader;
		private System.Windows.Forms.Button btnAllSchedule;
		private System.Windows.Forms.Button btnOldSchedule;
		private System.Windows.Forms.Button btnNewSchedule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label label4;
	}
}

