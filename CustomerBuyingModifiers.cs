using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomerBuyingModifiers
    {
        CurrentWeatherStatus weatherStatus = new CurrentWeatherStatus();
        CustomerCondition customerCondition = new CustomerCondition();
        public CustomerBuyingModifiers()
        {

        }
        public void ThirstModifier()
        {
          customerCondition.Thirst = customerCondition.thirstLevel.Next(1, 3);
            if (customerCondition.Thirst == customerCondition.ReallyThirsty)
            {
                customerCondition.InterestInBuying += 40;
            }
            else if (customerCondition.Thirst == customerCondition.SortOfThirsty)
            {
                customerCondition.InterestInBuying += 20;
            }
            else if (customerCondition.Thirst == customerCondition.NotReallyThirsty)
            {
                customerCondition.InterestInBuying += 10;
            }
        }
        public void WeatherModifier()
        {
            if(weatherStatus.weather == "sunny")
            {
                customerCondition.InterestInBuying += 30;
            }else if(weatherStatus.weather == "blazing hot")
            {
                customerCondition.InterestInBuying += 50;
            }else if (weatherStatus.weather == "cloudy")
            {
                customerCondition.InterestInBuying -= 10;
            }else if (weatherStatus.weather == "rainy")
            {
                customerCondition.InterestInBuying -= 20;
            }
        }
        public void TemperatureModifier()
        {
            if(weatherStatus.temperature > 80)
            {
                customerCondition.InterestInBuying += 30;
            }else if(weatherStatus.temperature < 60 && weatherStatus.temperature < 79)
            {
                customerCondition.InterestInBuying += 15;
            }else if(weatherStatus.temperature > 30 && weatherStatus.temperature < 78)
            {
                customerCondition.InterestInBuying += 25;
            }else if(weatherStatus.temperature <= 29)
            {
                customerCondition.InterestInBuying -= 10;
            }
        }
         
    }
}
    


 