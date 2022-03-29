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
using System.Windows.Threading;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace ProjectForPervasive
{
	public partial class formDailySchedule : Form
	{
		List<DayilySchedule> dayilySchedules = new List<DayilySchedule>();
		List<DayilySchedule> dayilyScheduled = new List<DayilySchedule>();
		Label label = new Label();
		List<Timer> timers = new List<Timer>();
		SpeechSynthesizer Speech = new SpeechSynthesizer();
		public formDailySchedule()
		{
			InitializeComponent();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var startDate = timeStartDate.Value.ToString("HH:mm");
			var endDate = timeEndDate.Value.ToString("HH:mm");	
			if (txtTitle.Text != "")
			{
				if (timeStartDate.Value < timeEndDate.Value)
				{
					if (dayilySchedules.Count > 0)
					{
						AddSchedule(timeStartDate.Value, timeEndDate.Value);
					}
					else
					{
						dayilySchedules.Add(new DayilySchedule()
						{						
							StartDateDisplay = startDate,
							EndDateDisplay = endDate,
							StartTime = timeStartDate.Value,
							EndTime = timeEndDate.Value,
							Title = txtTitle.Text
						}) ;
						//timers.Add(new Timer());
					}
					txtTitle.Text = "";
				}
				else
				{
					Speech.SpeakAsync("Invalid Schedule, please review start and end time.");
					MessageBox.Show("Invalid Schedule, please review start and end time.");
				}
			}
			else
			{
				Speech.SpeakAsync("Title is required please enter the Tilte");
				MessageBox.Show("Title is required please enter the Tilte");
			}
			displayscheduleallSchedule();
			StartAlartingSchedule();
			
		}

		public void AddSchedule(DateTime start, DateTime end)
		{
			var startDate = start.ToString("HH:mm");
			var endDate = end.ToString("HH:mm");
			DateTime lastScheduleEndTime = dayilySchedules[dayilySchedules.Count() - 1].EndTime;
			if (start >= lastScheduleEndTime)
			{
				dayilySchedules.Add(new DayilySchedule()
				{
					StartDateDisplay = startDate,
					EndDateDisplay = endDate,
					StartTime = timeStartDate.Value,
					EndTime = timeEndDate.Value,
					Title = txtTitle.Text
				});
				//timers.Add(new Timer());
			}
			else
			{
				Speech.SpeakAsync("Invalid Schedule, you have other schedule.");
				MessageBox.Show("Invalid Schedule, you have other schedule.");
			}
		}
		public void StartAlartingSchedule()
		{
			if (dayilySchedules.Count > 0)
			{
				Timer timer = new Timer();
				timer.Interval = 2000;
				timer.Tick += delegate (object sender, EventArgs e) { CheckSchedule(sender, e); };
				timer.Start();
			}
		}
		private void CheckSchedule(object sender, EventArgs e)
		{
			if (dayilySchedules.Count > 0)
			{
				var scheduleHourInSecond = dayilySchedules[0].StartTime.Hour * 60 * 60;
				var scheduleMinuteInSecond = dayilySchedules[0].StartTime.Minute * 60;
				var scheduleInSecond = dayilySchedules[0].StartTime.Second;
				var totalScheduleSecond = scheduleHourInSecond + scheduleMinuteInSecond + scheduleInSecond;

				var dateTimeNow = DateTime.Now;
				var dateTimeNowHourInSecond = dateTimeNow.Hour * 60 * 60;
				var dateTimeNowMinuteInSecond = dateTimeNow.Minute * 60;
				var dateTimeNowInSecond = dateTimeNow.Second;
				var totalDateTiemNowScheduleSecond = dateTimeNowHourInSecond + dateTimeNowMinuteInSecond + dateTimeNowInSecond;
				if (totalScheduleSecond <= totalDateTiemNowScheduleSecond)
				{
					Speech.SpeakAsync("Its time to " + dayilySchedules[0].Title);
					dayilyScheduled.Add(dayilySchedules[0]);
					dayilySchedules.Remove(dayilySchedules[0]);
				}
				
			}
		}
		private void dateTime_ValueChanged(object sender, EventArgs e)
		{
			timeStartDate.MinDate = DateTime.Now;
			timeStartDate.MaxDate = DateTime.Now.AddDays(1);
		}
		public void StartAlertTime()
		{
			StopAlerttime();
			int i = 0;
			foreach(var daily in dayilySchedules)
            {
				var dateTimeNow = DateTime.Parse(DateTime.Now.ToString());
				var startDateInSecond = DateTime.Parse(daily.StartTime.ToString());
				var timeDifference = startDateInSecond.Subtract(dateTimeNow);
				var hour = timeDifference.Hours * 60 * 60;
				var minute = timeDifference.Minutes * 60;
				var second = timeDifference.Seconds;
				var totalSecond = hour + minute + second;

				timers[i].Interval = totalSecond*1000;
				timers[i].Tick +=  delegate (object sender, EventArgs e) { timer_Tick(sender, e, daily.Title,i); };
				timers[i].Start();
				i++;
			}

		}
		public void StopAlerttime()
        {
			foreach (var timer in timers)
			{
				timer.Stop();
				timer.Dispose();
				timer.Enabled = false;
			}
		}
		private void timer_Tick(object sender, EventArgs e, string title, int i)
		{
			Speech.SpeakAsync("It is the time to " + title);
			MessageBox.Show("It is the time to " + title);
			timers[i-1].Stop();	
		}
        private void btnClose_Click(object sender, EventArgs e)
        {
			StartAlertTime();
		}
		private void timeStartDate_ValueChanged(object sender, EventArgs e)
		{
			timeStartDate.MinDate = DateTime.Now;
		}
		public void displayNewSchedule()
		{
			string labels = dayilySchedules.Count() > 0 ? Common.Longspace + "Schedule For Today" + "\n" + Common.Line + "\n" : "";
			int panelWidth = 494;
			int panelHeight = 300;
			int numberOfShcedule = 0;
			foreach (var dailyschedule in dayilySchedules)
			{
				numberOfShcedule++;
				panelHeight += 50;
				labels += numberOfShcedule.ToString() + Common.Shortspace +
						  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
						  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
						  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";
				panel.Size = new Size(panelWidth, panelHeight);
				//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
			}
			label.Text = labels;
			label.AutoSize = true;
			label.Font = new Font("Calibri", 17);
			label.Padding = new Padding(5);
			panel.Controls.Add(label);
		}
		public void displayOldSchedule()
		{
			string labels = dayilySchedules.Count() > 0 ? Common.Longspace + "Schedule For Today" + "\n" + Common.Line + "\n" : "";
			int panelWidth = 494;
			int panelHeight = 300;
			int numberOfShcedule = 0;
			foreach (var dailyschedule in dayilyScheduled)
			{
				numberOfShcedule++;
				panelHeight += 50;
				labels += numberOfShcedule.ToString() + Common.Shortspace +
						  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
						  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
						  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";
				panel.Size = new Size(panelWidth, panelHeight);
				//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
			}
			label.Text = labels;
			label.AutoSize = true;
			label.Font = new Font("Calibri", 17);
			label.Padding = new Padding(5);
			panel.Controls.Add(label);
		}
		public void displayscheduleallSchedule()
		{
			if(dayilyScheduled.Count > 0|| dayilyScheduled.Count>0)
			{
				panelScheduleHeader.Visible = true;
				string labels = dayilySchedules.Count() > 0 ? Common.Longspace + "Schedule For Today" + "\n" + Common.Line + "\n" : "";
				int panelWidth = 494;
				int panelHeight = 300;
				int numberOfShcedule = 0;
				foreach (var dailyschedule in dayilySchedules)
				{
					numberOfShcedule++;
					panelHeight += 50;
					labels += numberOfShcedule.ToString() + Common.Shortspace +
							  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
							  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
							  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";

					panel.Size = new Size(panelWidth, panelHeight);
					//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
				}
				foreach (var dailyschedule in dayilyScheduled)
				{
					numberOfShcedule++;
					panelHeight += 50;
					labels += numberOfShcedule.ToString() + Common.Shortspace +
							  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
							  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
							  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";

					panel.Size = new Size(panelWidth, panelHeight);
					//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
				}
				label.Text = labels;
				label.AutoSize = true;
				label.Font = new Font("Calibri", 17);
				label.Padding = new Padding(5);
				panel.Controls.Add(label);
			}
				
		}
		private void button1_Click(object sender, EventArgs e)
		{
			displayNewSchedule();
		}

		private void formDailySchedule_Load(object sender, EventArgs e)
		{
			panelScheduleHeader.Visible = false;
		}

		private void btnOldSchedule_Click(object sender, EventArgs e)
		{
			displayOldSchedule();
		}

		private void btnAllSchedule_Click(object sender, EventArgs e)
		{
			displayscheduleallSchedule();
		}
	}
}
