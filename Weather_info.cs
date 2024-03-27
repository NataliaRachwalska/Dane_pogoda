using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dane_pogoda
{
    public class Weather_info
    {
        public class weather
        {

            public double id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }
        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }

            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double KelvinToCelsius(double kelvin)
            {
                return Math.Round(kelvin - 273.15, 1); ;
            }
        }
        public class root {
         public List<weather> weather { get; set; }
            public main main { get; set; }
            public override string ToString()
            {
                return $"ID: {weather[0].id}\n" +
                    $"Weather: {weather[0].main}\n" +
                    $"Description: {weather[0].description}\n" +
                    $"Temperature: {main.temp}\n" +
                    $"Feels like: {main.feels_like}\n" +
                    $"Max temperature: {main.temp_max}\n" +
                    $"Min temperature: {main.temp_min}\n" +
                    $"Pressure: {main.pressure}\n" +
                    $"Humidity: {main.humidity}\n";
            }

    }
}

    
}
