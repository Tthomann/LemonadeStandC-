using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StoreSupplies SuppliesPlayerOwns = new StoreSupplies();
            StoreSupplies Money = new StoreSupplies();
            CurrentWeatherStatus WeatherStatus = new CurrentWeatherStatus();
          
            StoreSupplies playerSupplies = new StoreSupplies();
            PlayerSupplyContainer playerSupplyContainer = new PlayerSupplyContainer();
            Customer customer = new Customer(SuppliesPlayerOwns,playerSupplyContainer, WeatherStatus);
            BasePriceOfSupplies supplyPrice = new BasePriceOfSupplies();
            OptionText optionText = new OptionText(supplyPrice, playerSupplyContainer);
          

            optionText.TitleMenu();
            playerSupplies.RunSupplyBuyer();
           
            customer.playersLemonadeStand.SpawnCustomer();
            Console.ReadLine();
        }
    }
}












