using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPervasive.Model
{
	public static class WeatherData
	{
		public static Dictionary<int,string> WeatherCode()
		{
			Dictionary<int, string> weatherCodes = new Dictionary<int, string>();
			weatherCodes.Add(116, "Partly cloudy");
			weatherCodes.Add(119, "Cloudy");
			weatherCodes.Add(122, "Overcast");
			weatherCodes.Add(143, "Mist");
			weatherCodes.Add(176, "Patchy rain possible");
			weatherCodes.Add(179, "Patchy snow possible	");
			weatherCodes.Add(185, "Patchy freezing drizzle possible");
			weatherCodes.Add(200, "Thundery outbreaks possible");
			weatherCodes.Add(227, "Blowing snow");
			weatherCodes.Add(230, "Blizzard");
			weatherCodes.Add(248, "Fog");
			weatherCodes.Add(260, "Freezing fog");
			weatherCodes.Add(263, "Patchy light drizzle");
			weatherCodes.Add(266, "Light drizzle");
			weatherCodes.Add(281, "Freezing drizzle");
			weatherCodes.Add(284, "Heavy freezing drizzle");
			weatherCodes.Add(293, "Patchy light rain");
			weatherCodes.Add(296, "Light rain");
			weatherCodes.Add(299, "Moderate rain at times");
			weatherCodes.Add(302, "Moderate rain");
			weatherCodes.Add(305, "Heavy rain at times");
			weatherCodes.Add(308, "Heavy rain");
			weatherCodes.Add(311, "Light freezing rain");
			return weatherCodes;
		}
	}
}
