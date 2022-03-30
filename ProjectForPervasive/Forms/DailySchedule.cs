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
using ProjectForPervasive.Forms;

namespace ProjectForPervasive
{
	public partial class formDailySchedule : Form
	{
		List<DailySchedule> dailySchedules = new List<DailySchedule>();
		List<DailySchedule> dailyScheduled = new List<DailySchedule>();
		Label label = new Label();
		List<Timer> timers = new List<Timer>();
		SpeechSynthesizer speech = new SpeechSynthesizer();
		PromptBuilder promptBuilder = new PromptBuilder();
		SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine();
		Choices choices;
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
				if (timeStartDate.Value < timeEndDate.Value && timeStartDate.Value>=DateTime.Now)
				{
					if (dailySchedules.Count > 0)
					{
						AddSchedule(timeStartDate.Value, timeEndDate.Value);
					}
					else
					{
						dailySchedules.Add(new DailySchedule()
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

		public void AddSchedule(DateTime start, DateTime end)
		{
			var startDate = start.ToString("HH:mm");
			var endDate = end.ToString("HH:mm");
			DateTime lastScheduleEndTime = dailySchedules[dailySchedules.Count() - 1].EndTime;
			if (start >= lastScheduleEndTime)
			{
				dailySchedules.Add(new DailySchedule()
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
				speech.SpeakAsync("Invalid Schedule, you have other schedule.");
				MessageBox.Show("Invalid Schedule, you have other schedule.");
			}
		}
		public void StartAlartingSchedule()
		{
			if (dailySchedules.Count > 0)
			{
				Timer timer = new Timer();
				timer.Interval = 2000;
				timer.Tick += delegate (object sender, EventArgs e) { CheckSchedule(sender, e); };
				timer.Start();
			}
		}
		private void CheckSchedule(object sender, EventArgs e)
		{
			if (dailySchedules.Count > 0)
			{
				var scheduleHourInSecond = dailySchedules[0].StartTime.Hour * 60 * 60;
				var scheduleMinuteInSecond = dailySchedules[0].StartTime.Minute * 60;
				var scheduleInSecond = dailySchedules[0].StartTime.Second;
				var totalScheduleSecond = scheduleHourInSecond + scheduleMinuteInSecond + scheduleInSecond;

				var dateTimeNow = DateTime.Now;
				var dateTimeNowHourInSecond = dateTimeNow.Hour * 60 * 60;
				var dateTimeNowMinuteInSecond = dateTimeNow.Minute * 60;
				var dateTimeNowInSecond = dateTimeNow.Second;
				var totalDateTiemNowScheduleSecond = dateTimeNowHourInSecond + dateTimeNowMinuteInSecond + dateTimeNowInSecond;
				if (totalScheduleSecond <= totalDateTiemNowScheduleSecond)
				{
					speech.SpeakAsync("Its time to " + dailySchedules[0].Title);
					dailyScheduled.Add(dailySchedules[0]);
					dailySchedules.Remove(dailySchedules[0]);
					panelScheduleHeader.Visible = true;
				}
				
			}
		}
		public void StartAlertTime()
		{
			StopAlerttime();
			int i = 0;
			foreach(var daily in dailySchedules)
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
			speech.SpeakAsync("It is the time to " + title);
			MessageBox.Show("It is the time to " + title);
			timers[i-1].Stop();	
		}
        private void btnClose_Click(object sender, EventArgs e)
        {
			this.Close();
		}
		public void displayNewSchedule()
		{

			string labels = "";
				int panelWidth = 494;
				int panelHeight = 300;
				int numberOfShcedule = 0;
				foreach (var dailyschedule in dailySchedules)
				{
				labels = "";
				labels = dailySchedules.Count() > 0 ? Common.Longspace + "Schedule For Today" + "\n" + Common.Line + "\n" : "";
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
			string labels = ""; ;
				int panelWidth = 494;
				int panelHeight = 300;
				int numberOfShcedule = 0;
				foreach (var dailyschedule in dailyScheduled)
				{
					labels = "";
					labels = Common.Longspace + "Schedule For Today" + "\n" + Common.Line + "\n" ;
					numberOfShcedule++;
					panelHeight += 80;
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
			if(dailyScheduled.Count > 0)
			{
				string labels =  "";
				labels = Common.Longspace + "Schedule For Today" + "\n" + Common.Line + "\n";
				int panelWidth = 494;
				int panelHeight = 300;
				int numberOfShcedule = 0;
				foreach (var dailyschedule in dailySchedules)
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
				foreach (var dailyschedule in dailyScheduled)
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

		//private void formDailySchedule_Load(object sender, EventArgs e)
		//{
		//	panelScheduleHeader.Visible = false;
		//	lblWelcome.Text = "Dear " + Login.FullName + ", welcome to task scheduler";

		//}

		private void btnOldSchedule_Click(object sender, EventArgs e)
		{
			displayOldSchedule();
		}

		private void btnAllSchedule_Click(object sender, EventArgs e)
		{
			displayscheduleallSchedule();
		}

        private void label11_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form dashboard = new Dashboard();
			dashboard.ShowDialog();
			dashboard.Close();
			this.Close();
		}
        public void NewscheduleTeller()
        {
            if (dailySchedules.Count > 0)
            {
				var num = 0;
				speech.SpeakAsync("you have" + dailySchedules.Count + "New Schedule");
				foreach (var dailyschedule in dailySchedules)
				{
					num++;
					speech.SpeakAsync("Number" + num + " Title is "+dailyschedule.Title);
					speech.SpeakAsync("Schedule From"+dailyschedule.StartTime+"to"+dailyschedule.EndTime);
				}
			}
	}
		public void PastscheduleTeller()
		{
			if (dailyScheduled.Count > 0)
			{
				var num = 0;
				speech.SpeakAsync("you have" + dailySchedules.Count + "Past Schedule");
				foreach (var dailyschedule in dailyScheduled)
				{
					num++;
					speech.SpeakAsync("Number" + num + " Title is " + dailyschedule.Title);
					speech.SpeakAsync("Schedule From" + dailyschedule.StartTime + "to" + dailyschedule.EndTime);
				}
			}
		}
		public void SpeechRecoginizer()
		{
			choices = new Choices();
			choices.Add(new string[] { 
				"Hello",
				"I am good.",
				"How are you",
				"Thank you",
				"What is the current weather?",
				"What is the current time?",
				"What is the current date?",
				"tell me my new schedule", 
				"tell me my past schedule" ,
				"Back to dashboard",
			});

			Grammar grammar = new Grammar(new GrammarBuilder(choices));
			try
			{
				speechEngine.RequestRecognizerUpdate();
				speechEngine.LoadGrammar(grammar);
				speechEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;
				speechEngine.SetInputToDefaultAudioDevice();
				speechEngine.RecognizeAsync(RecognizeMode.Multiple);
			}
			catch (Exception)
			{

				throw;
			}
		}
		private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			switch (e.Result.Text.ToString())
			{
				case "Hello":
					speech.SpeakAsync("Selam, welcome task schedule communication channel");
					break;
				case "Thank you":
					speech.SpeakAsync("Great! what can I help you?");
					break;
				case "What is the current time?":
					speech.SpeakAsync(DateTime.Now.ToString("t"));
					break;
				case "What is the current date?":
					speech.SpeakAsync(DateTime.Now.ToString("MMMM d, yyyy"));
					break;
				case "Back to dashboard":
					this.Hide();
					Form dashboard = new Dashboard();
					dashboard.ShowDialog();
					dashboard.Close();
					this.Close();
					break;
				case "tell me my new schedule":
					NewscheduleTeller();
					break;
				case "tell me my past schedule":
					PastscheduleTeller();
					break;
			}
		}

  //      private void button1_Click_1(object sender, EventArgs e)
  //      {
			
		//}

        private void button1_Click_2(object sender, EventArgs e)
        {
			SpeechRecoginizer();
		}

        private void formDailySchedule_Load(object sender, EventArgs e)
        {
			panelScheduleHeader.Visible = false;
			lblWelcome.Text = "Dear " + Login.FullName + ", welcome to task scheduler";

		}

        private void panel_Paint(object sender, PaintEventArgs e)
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
