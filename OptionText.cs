using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class OptionText
    {
        OptionText optionText = new OptionText();
        BasePriceOfSupplies SupplyPrices = new BasePriceOfSupplies();
        int UserInput = Convert.ToInt32(Console.ReadLine());
        public bool ExitGame;
        public OptionText()
        {

        }
        public void TitleMenu()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
            Console.WriteLine("Type 1 to begin the game");
            Console.WriteLine("Type 2 to end the game");
            switch (UserInput)
            {

                case 1:
                    optionText.PriceListText();
                    break;
                  

                case 2:
                    ExitGame = true;
                    Console.WriteLine("shutting down...");
                    Environment.Exit(0);
                    break;
            }
        }
        public void PriceListText()
        {
            Console.WriteLine("The Price for Lemons is: " + SupplyPrices.LemonPrice + " per bag of lemons");
            Console.WriteLine("The Price for Sugar is: " + SupplyPrices.SugarPrice + " per bag of sugar");
            Console.WriteLine("The Price for Ice is: " + SupplyPrices.IcePrice + " per bag of ice");
            Console.WriteLine("The Price for Water is: " + SupplyPrices.WaterPrice + " per containers of water");
            Console.WriteLine("The Price for Cups is: " + SupplyPrices.CupPrice + " per bag of cups");
        }
        public void BuyTypeOfSupply()
        {
            Console.WriteLine("Type 1 to by lemons");
            Console.WriteLine("Type 2 to by sugar");
            Console.WriteLine("Type 3 to by ice");
            Console.WriteLine("Type 4 to by water");
        }
      
        public void BuyLemonsText()
        {
            Console.WriteLine("enter the number of lemons you'd like to buy for today");
        }
        public void BuySugarText()
        {
            Console.WriteLine("enter the ammount of sugar you'd like to buy for today");
        }
        public void BuyIceText()
        {
            Console.WriteLine("enter the ammount of ice you'd like to buy for today");
        }
        public void BuyWaterText()
        {
            Console.WriteLine("enter the ammount of water cases you'd like to buy for today");
        }
       
        
    }
}
