using System;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Globalization;

namespace MonitorPhotoApp
{
    public class LocaleData
    {
        public string _City { get; private set; }
		public string _Country { get; private set; }
		public string _Lat { get; private set; }
		public string _Lon { get; private set; }
		public string _WeatherDescription { get; private set; }
		public string _Humidity { get; private set; }
		public string _TempFeelsLike { get; private set; }
		public string _Temp { get; private set; }
		public string _TempMax { get; private set; }
		public string _TempMin { get; private set; }
		public string _flagIconUrl { get; private set; }

		public string _IP { get; private set; }

		public int _Timezone { get; private set; }


		public string _CountryDisplayName { get; private set; }
		public string _Currency { get; private set; }
		public string _CurrencySymbol { get; private set; }

		public string _localTime { get; private set; }

		public void FillWeatherProperties()
        {
			
			GetWeather(GetLocation(GetIPAddress()));
        }
		public bool FillWeatherProperties(string ip)
		{
           
				return GetWeather(GetLocation(ip));
			
		}

		private bool GetWeather(string city)
		{
			if (city == null) return false;
			//Assign API KEY which received from OPENWEATHERMAP.ORG  
			string appId = "68224e5e5f7d7f5cddbe9f980e9f164e";

			//API path with CITY parameter and appId.  
			Log.AddToLog("Retrieving weather data..");
			string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", city, appId);
            try
            {
				using (WebClient client = new WebClient())
				{
					string json = client.DownloadString(url);
					//Converting to OBJECT from JSON string.  
					RootObject weatherInfo = (new JavaScriptSerializer()).Deserialize<RootObject>(json);

					// Populate properties
					this._Country = weatherInfo.Sys.Country;
					RegionInfo countryProperties = new RegionInfo(this._Country);
					this._CountryDisplayName = countryProperties.DisplayName;
					this._Currency = countryProperties.CurrencyEnglishName;
					this._CurrencySymbol = countryProperties.CurrencySymbol;
					this._flagIconUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", this._Country.ToLower());
					this._City = weatherInfo.Name;
					this._Lat = Convert.ToString(weatherInfo.Coord.Lat);
					this._Lon = Convert.ToString(weatherInfo.Coord.Lon);
					this._WeatherDescription = weatherInfo.Weather[0].Description;
					this._Humidity = Convert.ToString(weatherInfo.Main.Humidity);
					this._Temp = Convert.ToString(weatherInfo.Main.Temp);
					this._TempFeelsLike = Convert.ToString(weatherInfo.Main.Feels_like);
					this._TempMax = Convert.ToString(weatherInfo.Main.Temp_max);
					this._TempMin = Convert.ToString(weatherInfo.Main.Temp_min);
					this._Timezone = weatherInfo.Timezone;
		

				}
				Log.AddToLog("Done");
				return true;
			}
            catch (Exception)
            {
				return false;
            }
			
		}
		private string GetIPAddress()
		{
			Log.AddToLog("Retrievning ip..");

			String address = "";
			WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
			using (WebResponse response = request.GetResponse())
			using (StreamReader stream = new StreamReader(response.GetResponseStream()))
			{
				address = stream.ReadToEnd();
			}

			// Extract IP manually from string
			int first = address.IndexOf("Address: ") + 9;
			int last = address.LastIndexOf("</body>");
			address = address.Substring(first, last - first);

			// Store IP
			this._IP = address;

			Log.AddToLog("Ip = " + address);
			return address;
		}

		private string GetLocation(string ip)
		{
			Log.AddToLog("Retrievning Location..");
			var res = "";
			try
			{
				WebRequest request = WebRequest.Create("http://ipinfo.io/" + ip);
			
				using (WebResponse response = request.GetResponse())
				using (StreamReader stream = new StreamReader(response.GetResponseStream()))
				{
					string line;
					while ((line = stream.ReadLine()) != null)
					{
						res += line;
					}
				}
	
				string city = (new JavaScriptSerializer()).Deserialize<Location>(res).City;
				Log.AddToLog("Location = " + city);
				return city;
			}
			catch (Exception e)
			{
				/*if (e.Status == WebExceptionStatus.Timeout)
				{
					// Handle timeout exception
					return "";
				}*/
				throw;
			}
			

		}

        internal string getLocalTime()
        {

			return DateTime.UtcNow.AddSeconds(_Timezone).ToString();
		}
    }
}
