using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DaysOfTheWeek
    {
        CurrentWeatherStatus currentWeatherStatus;

        public DaysOfTheWeek(CurrentWeatherStatus weather)
        {
            this.currentWeatherStatus = weather;
        }
        public void Day()
        {
            currentWeatherStatus.RandomWeather();
            currentWeatherStatus.RandomTemperature();
            currentWeatherStatus.WeatherPrediction();
        }
        
    }
}
