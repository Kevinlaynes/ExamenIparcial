using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.OpenWeatherClient;

namespace WeatherApp.Presentacion
{
    public partial class Form1 : Form
    {
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public OpenWeather openWeather;
        //public WeatherRepository repository;

       


        public Form1()
        {


            httpOpenWeatherClient = new HttpOpenWeatherClient();
            //repository = new WeatherRepository();




            //cities = httpOpenWeatherClient.Deserializarjson(Properties.Settings.)
            //comboBox1.Items.AddRange(httpOpenWeatherClient.Deserializarjson().GetValues(typeof(Ciudades)).Cast<object>().ToArray());
            InitializeComponent();
        }

       


        public async Task Request()
        {


            openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync(textBox1.Text);



        }

        public void AñadirDatos(WeatherPanel weatherPanel)

        {
            //repository.Add(openWeather);
            weatherPanel.lblCity.Text = openWeather.Name;

            weatherPanel.lblTemperature.Text = openWeather.Main.Temp.ToString() + "°C"; ;
            weatherPanel.lblWeather.Text = openWeather.Weather[0].Main.ToString();
            // pictureBox1.ImageLocation = service.GetImageLocation(infoClima.weather[0]);
            weatherPanel.pictureBox1.ImageLocation = httpOpenWeatherClient.GetImageLocation(openWeather.Weather[0]);
            weatherPanel.d1.lblDetail.Text = "Temperatura maxima";
            weatherPanel.d1.lblDetailValue.Text = openWeather.Main.Temp_max.ToString() + "°C";
            weatherPanel.d2.lblDetail.Text = "Temperatura minima";
            weatherPanel.d2.lblDetailValue.Text = openWeather.Main.Temp_min.ToString() + "°C";
            weatherPanel.d3.lblDetail.Text = "Humedad";
            weatherPanel.d3.lblDetailValue.Text = openWeather.Main.Humidity.ToString();
            weatherPanel.d4.lblDetail.Text = "Pais";
            weatherPanel.d4.lblDetailValue.Text = openWeather.Sys.Country.ToString();
            weatherPanel.d5.lblDetail.Text = "Presion";
            weatherPanel.d5.lblDetailValue.Text = openWeather.Main.Pressure.ToString();
            weatherPanel.d6.lblDetail.Text = "Velocidad viento";
            weatherPanel.d6.lblDetailValue.Text = openWeather.Wind.Speed.ToString() + "km/h";
            weatherPanel.d7.lblDetail.Text = "Amanecer";
            weatherPanel.d7.lblDetailValue.Text = httpOpenWeatherClient.convertToDateTime(openWeather.Sys.Sunrise).ToShortTimeString();
            weatherPanel.d8.lblDetail.Text = "Atardecer";
            weatherPanel.d8.lblDetailValue.Text = httpOpenWeatherClient.convertToDateTime(openWeather.Sys.Sunset).ToShortTimeString();

            //

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {



            //using (StreamReader u = File.OpenText(@"C:\Users\soportetec\Source\Repos\WeatherConcurrencyApp\WeatherConcurrencyApp\Properties\NiCiudades.json"))
            //{


            //    string T = u.ReadToEnd();
            //    List<Ciudades> obj = new List<Ciudades>();

            //    obj = JsonConvert.DeserializeObject<List<Ciudades>>(T);


            //    foreach (Ciudades X in obj)
            //    {

            //        comboBox1.Items.Add(X.City);


            //    }


            //}



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(Request).Wait();

                if (openWeather == null || textBox1 == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }

                WeatherPanel weatherPanel = new WeatherPanel();
                AñadirDatos(weatherPanel);

                flpContent.Controls.Add(weatherPanel);
            }
            catch (Exception)
            {

            }
        }
    }
}
