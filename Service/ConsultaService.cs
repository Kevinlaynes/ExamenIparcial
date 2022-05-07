
using AppCore.Iservices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Service
{
    public class ConsultaService : IService
    {

        private IConsulta service;
        public ConsultaService(IConsulta service)
        {
            this.service = service;
        }
        public DateTime convertToDateTime(long milisegundos)
        {
            return service.convertToDateTime(milisegundos);
        }

        public string GetImageLocation(wheather w)
        {
            return service.GetImageLocation(w);
        }

        

        public Root GetWeather(string ciudad)
        {
            return service.GetWeather(ciudad);
        }

        public Task<WheaterData.ForeCastInfo> GetWeatherForeCast(double Lat, double Lot, long dt)
        {
            return service.GetWeathGetWeatherForeCast(Lat, Lot, dt);
        }

        //public DateTime convertToDateTime(long milisegundos)
        //{

        //        return service.convertToDateTime(milisegundos);

        //}

        //public string GetImageLocation(wheather w)
        //{
        //    return service.GetImageLocation(w);
        //}

        //public Root GetWeather(string ciudad)
        //{
        //    return service.GetWeather(ciudad);
        //}






        //public ConsultaService(IConsulta service)
        //{
        //    this.service = service;
        //}
        //public DateTime convertToDateTime(long milisegundos)
        //{
        //    return service.convertToDateTime(milisegundos);
        //}

        //public string GetImageLocation(wheather w)
        //{
        //    return service.GetImageLocation(w);
        //}

        //public Root GetWeather(string ciudad)
        //{
        //    return service.GetWeather(ciudad);
        //}
    }
}
