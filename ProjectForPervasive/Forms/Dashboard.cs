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
using System.Speech.Recognition;

namespace ProjectForPervasive.Forms
{
    public partial class Dashboard : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        PromptBuilder promptBuilder = new PromptBuilder();
        SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine();
        Choices choices;
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
            this.Hide();
            Form weahter = new WeatherForcast();
            weahter.ShowDialog();
            weahter.Close();
            this.Close();
        }
        public void GetFromWeb()
        {
            var city = Login.City;
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
            lblWelcome.Text = "Dear " + Login.FullName + ", welcome to dashboard!";
            lblClock.Enabled = true;
            lblClock.Visible = true;
            lblDate.Visible = true;
            //panelDashbord.Visible = false;
            clock.Start();
            tempretureTimer.Start();
            updateWeather();
            //var firstName = user.
            //label.Text = firstName;
            //panelDashbord.Controls.Add(label);
        }
        public void updateWeather()
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
            //lblCelsius.Text = celsius.ToString()+ " °C";
            //lblFahrenheit.Text = fahrenheit.ToString()+ " °F";
            //lblCondition.Text = weatherMessage;
            //lblLastUpdate.Text = DateTime.Now.ToString();
        }
        public void CurrentWeather()
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
            //lblCurrentCelsius.Text = celsius.ToString() + " °C";
            //lblCurrentFahrenheit.Text = fahrenheit.ToString() + " °F";
            //lblCurrntCondition.Text = weatherMessage;
        }
        public void WeatherInformation()
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
            string title = Common.Longspace + "Weather Information";
            string labels = "";
            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Calibri", 21, FontStyle.Bold);
            titleLabel.Padding = new Padding(5);
            titleLabel.Margin = new Padding(2, 13, 4, 25);
            //panelDashbord.Controls.Add(titleLabel);
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
            //panelDashbord.Controls.Add(description);
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
        private void tempretureTimer_Tick(object sender, EventArgs e)
        {
            updateWeather();
        }
        private void panelDashbord_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form user = new Login();
            user.ShowDialog();
            user.Close();
            this.Close();
        }
        public void SpeechRecoginizer()
        {
            choices = new Choices();
            choices.Add(new string[] {
                "Hello",
                "I good.",
                "Thank you",
                "What is the current weather?",
                "What is the current time?",
                "What is the current date?",
                "Open task scheduler", 
                "Open task",
                "Open weather",
                "Back to dashboard",
                "Hide it" });
            Grammar grammar = new Grammar(new GrammarBuilder(choices));
            try
            {
                speechEngine.RequestRecognizerUpdate();
                speechEngine.LoadGrammar(grammar);
                speechEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;
                speechEngine.SetInputToDefaultAudioDevice();
                speechEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured while" + ex.ToString());
            }
        }
        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "Hello":
                    speech.SpeakAsync("Selam, welcome to communication channel on dashboard");
                    break;
                case "Thank you":
                    speech.SpeakAsync("Great! what can I help you?");
                    break;
                case "What is the current weather?":
                    currentWeatherWithVoice();
                    break;
                case "What is the current time?":
                    speech.SpeakAsync(DateTime.Now.ToString("t"));
                    break;
                case "What is the current date?":
                    speech.SpeakAsync(DateTime.Now.ToString("MMMM d, yyyy"));
                    break;
                case "Open task scheduler":
                    this.Hide();
                    Form dailyForm = new formDailySchedule();
                    dailyForm.ShowDialog();
                    dailyForm.Close();
                    this.Close();
                    break; 
                case "Open task":
                    this.Hide();
                    Form schedule = new formDailySchedule();
                    schedule.ShowDialog();
                    schedule.Close();
                    this.Close();
                    break;  
                case "Open weather":
                    this.Hide();
                    Form weather = new WeatherForcast();
                    weather.ShowDialog();
                    weather.Close();
                    this.Close();
                    break; 
                case "Back to dashboard":
                    this.Hide();
                    Form dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    dashboard.Close();
                    this.Close();
                    break;
            }
        }
        public void currentWeatherWithVoice()
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
            speech.SpeakAsync("The current tempreture is " + celsius.ToString() + " °C" + " or " + fahrenheit.ToString() + " °F");
            speech.SpeakAsync("and the current weather condition is " + weatherMessage + ". Therefore, you can arange your daily schedule base on this information.");
        }
        public void currentTempreture()
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
            speech.SpeakAsync("The current tempreture is " + celsius.ToString() + " °C" + " or " + fahrenheit.ToString() + " °F");
        }
        public void currentWeather()
        {
            var weatherForcast = GetFromWebLocal();
            int weatherCode = weatherForcast.current.weather_code;
            var listWeatherCode = WeatherData.WeatherCode();
            foreach (var code in listWeatherCode)
            {
                if (code.Key == weatherCode)
                {
                    speech.SpeakAsync("The current weather is " + code.Value);
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            SpeechRecoginizer();
        }

		private void button3_Click(object sender, EventArgs e)
		{
            this.Hide();
            Form calendar = new CalendarSchedule();
            calendar.ShowDialog();
            calendar.Close();
            this.Close();
        }
	}
}
