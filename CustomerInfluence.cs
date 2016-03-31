using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CustomerInfluence : Weather
    {

        LemonadeBusiness lemonadeBusiness = new LemonadeBusiness();
        Random CustomerRandom = new Random();
        public int InterestInBuying;
        public int InterestInBuyingCapacity;
        public int Thirst;
        public int ReallyThirsty = 1;
        public int SortOfThirsty = 2;
        public int NotReallyThirsty = 3;
        public CustomerInfluence()
        {

        }
        public void WeatherModifier()
        {
            if (weather == "sunny")
            {
                InterestInBuying += 30;
            }
            else if (weather == "blazing hot")
            {
                InterestInBuying += 50;
            }
            else if (weather == "cloudy")
            {
                InterestInBuying -= 10;
            }
            else if (weather == "rainy")
            {
                InterestInBuying -= 20;
            }

        }
        public void TemperatureModifier()
        {
            temperature = CustomerRandom.Next(1, 100);
            if (temperature > 80)
            {
                InterestInBuying += 30;
            }
            else if (temperature > 60 && temperature <= 79)
            {
                InterestInBuying += 15;
            }
            else if (temperature > 30 && temperature <= 78)
            {
                InterestInBuying += 25;
            }
            else if (temperature <= 29)
            {
                InterestInBuying -= 10;
            }

        }
        public void ThirstModifier()
        {


            Thirst = CustomerRandom.Next(0, 4);
            if (Thirst == ReallyThirsty)
            {
                InterestInBuying += 30;

            }
            else if (Thirst == SortOfThirsty)
            {
                InterestInBuying += 20;

            }
            else if (Thirst == NotReallyThirsty)
            {
                InterestInBuying -= 20;

            }

        }
        public void PriceModifier()
        {
            if (lemonadeBusiness.ChargePriceOfLemonade > 5.00)
            {
                InterestInBuying -= 20;
            }
            else if (lemonadeBusiness.ChargePriceOfLemonade < 5.00)
            {
                InterestInBuying += 15;
            }
        }
    }
}
