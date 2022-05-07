using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Iservices
{
   public interface IService
    {

        Task<WheaterData.ForeCastInfo> GetWeatherForeCast(double Lat, double Lot, long dt);
        Root GetWeather(string ciudad);
        string GetImageLocation(wheather w);

        DateTime convertToDateTime(long milisegundos);

    }
}
