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
	public partial class WeatherForcast : Form
	{
		SpeechSynthesizer speech = new SpeechSynthesizer();
		public WeatherForcast()
		{
			InitializeComponent();
		}
		private  void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is my Description", "Test Title");
			//var weatherForcast = GetFromWeb();
			var weatherForcast = GetFromWebLocal();
			double celsius = weatherForcast.current.temperature;
			double fahrenheit = celsius * 9 / 5 + 32;
			int weatherCode = weatherForcast.current.weather_code;
			string weatherIcon=weatherForcast.current.weather_icons[0];
			var listWeatherCode = WeatherData.WeatherCode();
			var weatherMessage = "";
			foreach (var code in listWeatherCode)
			{
				if(code.Key == weatherCode)
				{
					weatherMessage=code.Value;
				}
			}
			string title =Common.Longspace+ "Weather Information" ;
			string labels = "";
			Label titleLabel = new Label();
			titleLabel.Text = title;
			titleLabel.AutoSize = true;
			titleLabel.Font = new Font("Calibri", 21,FontStyle.Bold);
			titleLabel.Padding = new Padding(5);
			titleLabel.Margin = new Padding(2,13,4,25);
			weatherPanel.Controls.Add(titleLabel);
			labels ="\n"+Common.Longspace+Common.LineForInformation+"\n"+
				     "Celsius= " + celsius + "\n"  +
					 "Fahrenheit= " + fahrenheit + "\n" +
					 "Weather Message= Today is " + weatherMessage + "\n"+
					 "Weather Icon= " + weatherIcon + "\n";
			speech.SpeakAsync("Today is "+ weatherMessage+ ", please arange your schedule");
			Label description = new Label();
			description.Text = labels;
			description.AutoSize = true;
			description.Font = new Font("Calibri", 17);
			description.Padding = new Padding(15);
			description.Margin = new Padding(2,25,0,0);
			weatherPanel.Controls.Add(description);
		}
		public void GetFromWeb()
		{
			var city = City.Text;
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
	}
}
