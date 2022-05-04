using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Common;
using WeatherApp.Domain.Entities;
using WeatherApp.Domain.Interface;

namespace WeatherApp.Infrastructure.OpenWeatherClient
{
    public class HttpOpenWeatherClient :  IHttpOpenWeatherClient
    {
        
        public DateTime convertToDateTime(long milisegundos)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milisegundos).ToLocalTime();
            return day;

        }

        public string GetImageLocation(Weather w)
        {
            string imageLocation = $@"https://openweathermap.org/img/w/{w.Icon}.png";
            return imageLocation;
        }

        public async Task<OpenWeather> GetWeatherByCityNameAsync(string lat)
        {
            string url = $"{AppSettings.ApiUrl}{lat}&units={AppSettings.units}&lang=sp&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return JsonConvert.DeserializeObject<OpenWeather>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
