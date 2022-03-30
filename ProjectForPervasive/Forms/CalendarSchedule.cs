using ProjectForPervasive.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForPervasive.Forms
{
	public partial class CalendarSchedule : Form
	{
		List<ProjectForPervasive.CalendarSchedule> calenderSchedules = new List<ProjectForPervasive.CalendarSchedule>();
		List<ProjectForPervasive.CalendarSchedule> calenderScheduled = new List<ProjectForPervasive.CalendarSchedule>();
		Label label = new Label();
		List<Timer> timers = new List<Timer>();
		SpeechSynthesizer speech = new SpeechSynthesizer();
		PromptBuilder promptBuilder = new PromptBuilder();
		SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine();
		Choices choices;
		public CalendarSchedule()
		{
			InitializeComponent();
		}

		private void btnClrAdd_Click(object sender, EventArgs e)
		{
			var startDate = clrStartDate.Value.ToString("dd/MM/yyyy");
			var endDate = clrEndDate.Value.ToString("dd/MM/yyyy");
			if (txtClrTitle.Text != "")
			{
				if (clrStartDate.Value < clrEndDate.Value)
				{
					if (calenderSchedules.Count > 0)
					{
						AddSchedule(clrStartDate.Value, clrEndDate.Value);
					}
					else
					{
						calenderSchedules.Add(new ProjectForPervasive.CalendarSchedule()
						{
							StartDateDisplay = startDate,
							EndDateDisplay = endDate,
							StartDate = clrStartDate.Value,
							EndDate = clrEndDate.Value,
							Title = txtClrTitle.Text
						});
						//timers.Add(new Timer());
					}
					txtClrTitle.Text = "";
				}
				else
				{
					speech.SpeakAsync("Invalid Schedule, please review start and end time.");
					MessageBox.Show("Invalid Schedule, please review start and end time.");
				}
			}
			else
			{
				speech.SpeakAsync("Title is required please enter the Title");
				MessageBox.Show("Title is required please enter the Title");
			}
			displayNewSchedule();
			displayscheduleallSchedule();
			StartAlartingSchedule();
		}
		private void CheckSchedule(object sender, EventArgs e)
		{
			if (calenderSchedules.Count > 0)
			{
				var startDate = calenderSchedules[0].StartDate;
				var endDate = calenderSchedules[0].EndDate;
				if (endDate <= startDate)
				{
					speech.SpeakAsync("Its time to " + calenderSchedules[0].Title);
					calenderScheduled.Add(calenderSchedules[0]);
					calenderSchedules.Remove(calenderSchedules[0]);
				}
			}
		}
		public void AddSchedule(DateTime start, DateTime end)
		{
			var startDate = clrStartDate.Value.ToString("dd/mm/yyyy");
			var endDate = clrEndDate.Value.ToString("dd/mm/yyyy");
			DateTime lastScheduleEndTime = calenderSchedules[calenderSchedules.Count() - 1].EndDate;
			if (start >= lastScheduleEndTime)
			{
				calenderSchedules.Add(new ProjectForPervasive.CalendarSchedule()
				{
					StartDateDisplay = startDate,
					EndDateDisplay = endDate,
					StartDate = clrStartDate.Value,
					EndDate = clrEndDate.Value,
					Title = txtClrTitle.Text
				});
				//timers.Add(new Timer());
			}
			else
			{
				speech.SpeakAsync("Invalid Schedule, you have other schedule.");
				MessageBox.Show("Invalid Schedule, you have other schedule.");
			}
		}
		public void StartAlartingSchedule()
		{
			if (calenderSchedules.Count > 0)
			{
				Timer timer = new Timer();
				timer.Interval = 2000;
				timer.Tick += delegate (object sender, EventArgs e) { CheckSchedule(sender, e); };
				timer.Start();
			}
		}
		public void displayNewSchedule()
		{
			if (calenderSchedules.Count > 0)
			{
				string labels = calenderSchedules.Count() > 0 ? Common.Longspace + "Calendar Schedule" + "\n" + Common.Line + "\n" : "";
				int panelWidth = 494;
				int panelHeight = 300;
				int numberOfShcedule = 0;
				panelScheduleHeader.Visible = true;
				foreach (var dailyschedule in calenderSchedules)
				{
					numberOfShcedule++;
					panelHeight += 50;
					labels += numberOfShcedule.ToString() + Common.Shortspace +
							  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
							  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
							  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";
					clrpanel.Size = new Size(panelWidth, panelHeight);
					//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
				}
				label.Text = labels;
				label.AutoSize = true;
				label.Font = new Font("Calibri", 17);
				label.Padding = new Padding(5);
				clrpanel.Controls.Add(label);
			}
		}
		public void displayOldSchedule()
		{
			string labels = calenderSchedules.Count() > 0 ? Common.Longspace + "Calendar Schedule" + "\n" + Common.Line + "\n" : "";
			labels = calenderScheduled.Count > 0 ? labels : "";
			int panelWidth = 494;
			int panelHeight = 300;
			int numberOfShcedule = 0;
			foreach (var dailyschedule in calenderScheduled)
			{
				numberOfShcedule++;
				panelHeight += 50;
				labels += numberOfShcedule.ToString() + Common.Shortspace +
						  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
						  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
						  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";
				clrpanel.Size = new Size(panelWidth, panelHeight);
				//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
			}
			label.Text = labels;
			label.AutoSize = true;
			label.Font = new Font("Calibri", 17);
			label.Padding = new Padding(5);
			clrpanel.Controls.Add(label);
		}
		public void displayscheduleallSchedule()
		{
			string labels = "";

				
				int panelWidth = 494;
				int panelHeight = 300;
				int numberOfShcedule = 0;
				foreach (var dailyschedule in calenderSchedules)
				{
				labels = "";
				labels = calenderSchedules.Count() > 0 ? Common.Longspace + "Calendar Schedule" + "\n" + Common.Line + "\n" : "";

				numberOfShcedule++;
					panelHeight += 50;
					labels += numberOfShcedule.ToString() + Common.Shortspace +
							  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
							  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
							  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";

					clrpanel.Size = new Size(panelWidth, panelHeight);
					//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
				}
				foreach (var dailyschedule in calenderScheduled)
				{
				labels = "";
				numberOfShcedule++;
					panelHeight += 50;
					labels += numberOfShcedule.ToString() + Common.Shortspace +
							  "Title= " + dailyschedule.Title + "\n" + Common.Shortspace +
							  "  Start Date= " + dailyschedule.StartDateDisplay + "\n" + Common.Shortspace +
							  "  End Date= " + dailyschedule.EndDateDisplay + "\n" + Common.Line + "\n";

					clrpanel.Size = new Size(panelWidth, panelHeight);
					//TimerController(dailyschedule.StartTime, dailyschedule.EndTime);				
				}
				label.Text = labels;
				label.AutoSize = true;
				label.Font = new Font("Calibri", 17);
				label.Padding = new Padding(5);
				clrpanel.Controls.Add(label);
		}
		private void WeeklySchedule_Load(object sender, EventArgs e)
		{
			panelScheduleHeader.Visible = false;
			lblWelcome.Text = "Dear " + Login.FullName + ", welcome to calendar scheduler";

		}

		private void btnClrNewSchedule_Click(object sender, EventArgs e)
		{
			displayNewSchedule();

		}

		private void btnClrOldSchedule_Click(object sender, EventArgs e)
		{
			displayOldSchedule();

		}

		private void btnClrAllSchedule_Click(object sender, EventArgs e)
		{
			displayscheduleallSchedule();

		}

		private void clrStartDate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form dashboard = new Dashboard();
			dashboard.ShowDialog();
			dashboard.Close();
			this.Close();
		}

		private void lblWelcome_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form user = new Login();
			user.ShowDialog();
			user.Close();
			this.Close();
		}
	}
}
