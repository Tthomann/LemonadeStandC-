using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Program
    {
        static void Main(string[] args)
        {

    
            DayProcess dayProcess = new DayProcess();
            Weather weather = new Weather();
        
            dayProcess.TitleMenu();
            weather.RandomWeather();
            weather.RandomTemperature();
            weather.WeatherPrediction();
            dayProcess.RunSupplyBuyer();
            


            Console.ReadLine();
        }
    }
}












