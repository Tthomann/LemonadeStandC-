using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public PlayersLemonadeStand playersLemonadeStand;
        StoreSupplies playerSupplies;
        PlayerSupplyContainer playerSupplyContainer;
        CurrentWeatherStatus currentWeatherStatus;
      
        
        public int InterestInBuying;
        public int InterestInBuyingCapacity = 100;
        public int Person = 1;
        public int Thirst;
        public int ReallyThirsty = 1;
        public int SortOfThirsty = 2;
        public int NotReallyThirsty = 3;
 
        public Customer(StoreSupplies SuppliesPlayerOwns, PlayerSupplyContainer playerSupplyContainer, CurrentWeatherStatus WeatherStatus)
        {
            this.playersLemonadeStand = new PlayersLemonadeStand(this);
            
            this.playerSupplyContainer = playerSupplyContainer;
            this.playerSupplies = SuppliesPlayerOwns;
            this.currentWeatherStatus = WeatherStatus;
            WeatherModifier();
            ThirstModifier();
            TemperatureModifier();
            PriceModifier();

        }
   
        public void CustomerBuyLemonade()
        {
            if (InterestInBuying >= InterestInBuyingCapacity)
            {
                playerSupplies.CupsLeft = playerSupplyContainer.CupsWithLemonade - 1;
                playerSupplyContainer.Revenue = playerSupplies.CupsSold * playerSupplies.ChargePriceOfLemonade;
                Console.WriteLine("A customer has bought a cup of lemonade");
                playerSupplyContainer.Money += playerSupplyContainer.Revenue;
               
            }
            else
            {
                Console.WriteLine("A customer wasn't in the mood to buy lemonade");
            }
        }
        public void ThirstModifier()
        {
            Random CustomerRandom = new Random();
            Thirst = CustomerRandom.Next(1, 3);
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
            else
            {
               
            }
        }
        public void WeatherModifier()
        {
            if (currentWeatherStatus.weather == "sunny")
            {
                InterestInBuying += 30;
            }
            else if (currentWeatherStatus.weather == "blazing hot")
            {
                InterestInBuying += 50;
            }
            else if (currentWeatherStatus.weather == "cloudy")
            {
                InterestInBuying -= 10;
            }
            else if (currentWeatherStatus.weather == "rainy")
            {
                InterestInBuying -= 20;
            }
            else
            {

            }
        }
        public void TemperatureModifier()
        {
            if (currentWeatherStatus.temperature > 80)
            {
                InterestInBuying += 30;
            }
            else if (currentWeatherStatus.temperature < 60 && currentWeatherStatus.temperature < 79)
            {
                InterestInBuying += 15;
            }
            else if (currentWeatherStatus.temperature > 30 && currentWeatherStatus.temperature < 78)
            {
                InterestInBuying += 25;
            }
            else if (currentWeatherStatus.temperature <= 29)
            {
                InterestInBuying -= 10;
            }
            else
            {

            }
        }
        public void PriceModifier()
        {
            if (playerSupplies.ChargePriceOfLemonade > 5.00)
            {
                InterestInBuying -= 20;
            }
            else if (playerSupplies.ChargePriceOfLemonade < 5.00)
            {
                InterestInBuying += 15;
            }
        }

    }
}
