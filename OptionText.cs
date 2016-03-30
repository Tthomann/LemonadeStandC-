using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class OptionText
    {
        BasePriceOfSupplies SupplyPrices;

        PlayerSupplyContainer playerSupplies;
        int UserInput;
     
        public bool ExitGame;
        public OptionText(BasePriceOfSupplies supplyPrice, PlayerSupplyContainer suppliesOwned)
        {
            this.SupplyPrices = supplyPrice;
            this.playerSupplies = suppliesOwned;
        }
        public void TitleMenu()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
            Console.WriteLine("Type 1 to begin the game");
            Console.WriteLine("Type 2 to end the game");
            UserInput = Convert.ToInt32(Console.ReadLine());
           
             switch (UserInput)
                {
                   case 1:

                    Console.WriteLine("The Price for Lemons is: $" + SupplyPrices.LemonPrice + " per bag of lemons");
                    Console.WriteLine("The Price for Sugar is: $" + SupplyPrices.SugarPrice + " per bag of sugar");
                    Console.WriteLine("The Price for Ice is: $" + SupplyPrices.IcePrice + " per bag of ice");
                    Console.WriteLine("The Price for Water is: $" + SupplyPrices.WaterPrice + " per containers of water");
                    Console.WriteLine("The Price for Cups is: $" + SupplyPrices.CupPrice + " per bag of cups");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("[NOTE: it also takes 4 lemons, 3 sugar bags, 2 ice bags, 1 water barrel, and 5 cups to make 20 cups of lemonade]");
                    break;
                   case 2:
                        ExitGame = true;
                        Console.WriteLine("shutting down...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
        }

       
  
    }
}


