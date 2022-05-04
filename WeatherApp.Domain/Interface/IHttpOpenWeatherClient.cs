using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Domain.Entities;

namespace WeatherApp.Domain.Interface
{
    public interface IHttpOpenWeatherClient
    {
        
            Task<OpenWeather> GetWeatherByCityNameAsync(string city);
        

    }
}
