using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Weather
    {
        public int num;
        public string weather;
        public int temperature;
        Random DecideWeather = new Random();
        public Weather()
        {


        }
        public string RandomWeather()
        {
            num = DecideWeather.Next(1, 5);

            if (num == 1)
            {
                weather = "sunny";
            }
            else if (num == 2)
            {
                weather = "rainy";
            }
            else if (num == 3)
            {
                weather = "cloudy";
            }
            else if (num == 4)
            {
                weather = "blazing hot";
            }
            Console.WriteLine("The weather today is : " + weather);
            return weather;
        }
        public int RandomTemperature()
        {
            temperature = DecideWeather.Next(1, 100);
            Console.WriteLine("The temperature today is : " + temperature);
            return temperature;
        }

        public void WeatherPrediction()
        {
            Console.WriteLine("The prediction for weather tomorrow is : " + weather);

        }
    }
}
