using Newtonsoft.Json;
using ProjectForPervasive.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ProjectForPervasive.Forms
{
	public partial class Dashboard : Form
	{
		SpeechSynthesizer speech = new SpeechSynthesizer();
		public Dashboard()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form dailyForm = new formDailySchedule();
			dailyForm.ShowDialog();
			dailyForm.Close();
			this.Close();
		}

		private void btnWeather_Click(object sender, EventArgs e)
		{
			//var weatherForcast = GetFromWeb();
			CurrentWeather();
			var weatherForcast = GetFromWebLocal();
			double celsius = weatherForcast.current.temperature;
			double fahrenheit = celsius * 9 / 5 + 32;
			int weatherCode = weatherForcast.current.weather_code;
			string weatherIcon = weatherForcast.current.weather_icons[0];
			var listWeatherCode = WeatherData.WeatherCode();
			var weatherMessage = "";
			foreach (var code in listWeatherCode)
			{
				if (code.Key == weatherCode)
				{
					weatherMessage = code.Value;
				}
			}
			string title = Common.Longspace + "Weather Information";
			string labels = "";
			Label titleLabel = new Label();
			titleLabel.Text = title;
			titleLabel.AutoSize = true;
			titleLabel.Font = new Font("Calibri", 21, FontStyle.Bold);
			titleLabel.Padding = new Padding(5);
			titleLabel.Margin = new Padding(2, 13, 4, 25); 
			panelDashbord.Controls.Add(titleLabel);
			labels = "\n" + Common.Longspace + Common.LineForInformation + "\n" +
					 "Celsius= " + celsius + "\n" +
					 "Fahrenheit= " + fahrenheit + "\n" +
					 "Weather Message= Today is " + weatherMessage + "\n" +
					 "Weather Icon= " + weatherIcon + "\n";
			speech.SpeakAsync("Today is " + weatherMessage + ", please arange your schedule");
			Label description = new Label();
			description.Text = labels;
			description.AutoSize = true;
			description.Font = new Font("Calibri", 17);
			description.Padding = new Padding(15);
			description.Margin = new Padding(2, 25, 0, 0);
			panelDashbord.Controls.Add(description);
		}
		public void GetFromWeb()
		{
			var city = "Addis Ababa";
			string _apiUrl = "http://api.weatherstack.com/current?access_key=65e8dcf103f7ade77fd0f60a930deb14&query=" + city;
			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				var response = client.GetAsync(_apiUrl).Result;
				var result = response.Content.ReadAsStringAsync().Result;
				var weatherForcast = JsonConvert.DeserializeObject<WeatherResponse>(result);
			}
		}
		public WeatherResponse GetFromWebLocal()
		{
			string jsonData = File.ReadAllText(@"WeatherJsonData.json");
			var weatherForcast = JsonConvert.DeserializeObject<WeatherResponse>(jsonData);
			return weatherForcast;
		}
		private void Dashboard_Load(object sender, EventArgs e)
        {
			Label label = new Label();
			lblClock.Enabled = true;
			lblClock.Visible = true;
			lblDate.Visible = true;
			clock.Start();
			tempretureTimer.Start();
			updateWeather();
			//var firstName = user.
			//label.Text = firstName;
			panelDashbord.Controls.Add(label);
		 }
		public async void updateWeather()
		{
			var weatherForcast = GetFromWebLocal();
			double celsius = weatherForcast.current.temperature;
			double fahrenheit = celsius * 9 / 5 + 32;
			int weatherCode = weatherForcast.current.weather_code;
			string weatherIcon = weatherForcast.current.weather_icons[0];
			var listWeatherCode = WeatherData.WeatherCode();
			var weatherMessage = "";
			foreach (var code in listWeatherCode)
			{
				if (code.Key == weatherCode)
				{
					weatherMessage = code.Value;
				}
			}
			lblCelsius.Text = celsius.ToString()+ " °C";
			lblFahrenheit.Text = fahrenheit.ToString()+ " °F";
			lblCondition.Text = weatherMessage;
			lblLastUpdate.Text = DateTime.Now.ToString();
		}
		public async void CurrentWeather()
		{
			var weatherForcast = GetFromWebLocal();
			double celsius = weatherForcast.current.temperature;
			double fahrenheit = celsius * 9 / 5 + 32;
			int weatherCode = weatherForcast.current.weather_code;
			string weatherIcon = weatherForcast.current.weather_icons[0];
			var listWeatherCode = WeatherData.WeatherCode();
			var weatherMessage = "";
			foreach (var code in listWeatherCode)
			{
				if (code.Key == weatherCode)
				{
					weatherMessage = code.Value;
				}
			}
			lblCurrentCelsius.Text = celsius.ToString() + " °C";
			lblCurrentFahrenheit.Text = fahrenheit.ToString() + " °F";
			lblCurrntCondition.Text = weatherMessage;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form dailyForm = new formDailySchedule();
			dailyForm.ShowDialog();
			dailyForm.Close();
			this.Close();
		}

		private void clock_Tick(object sender, EventArgs e)
		{
			lblClock.Text = DateTime.Now.ToString("T");
			lblDate.Text = DateTime.Now.ToString("MMMM d, yyyy");
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void tempretureTimer_Tick(object sender, EventArgs e)
		{
			updateWeather();
		}

		private void panelDashbord_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
