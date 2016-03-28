using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class OptionText
    {
        BasePriceOfSupplies SupplyPrices = new BasePriceOfSupplies();
        PlayerBuySupplies buySupplies = new PlayerBuySupplies();
        int UserInput;
        public bool NotEnoughMoney;
        public bool ExitGame;
        public OptionText()
        {

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
                        PriceListText();
                        break;
                   case 2:
                        ExitGame = true;
                        Console.WriteLine("shutting down...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
        }
        public void PriceListText()
        {
            Console.WriteLine("The Price for Lemons is: $" + SupplyPrices.LemonPrice + " per bag of lemons");
            Console.WriteLine("The Price for Sugar is: $" + SupplyPrices.SugarPrice + " per bag of sugar");
            Console.WriteLine("The Price for Ice is: $" + SupplyPrices.IcePrice + " per bag of ice");
            Console.WriteLine("The Price for Water is: $" + SupplyPrices.WaterPrice + " per containers of water");
            Console.WriteLine("The Price for Cups is: $" + SupplyPrices.CupPrice + " per bag of cups");
            
        }
        public void BuyTypeOfSupply()
        {
            while (NotEnoughMoney == false) {
            Console.WriteLine("----------------------");
            Console.WriteLine("Type 1 to by lemons");
            Console.WriteLine("Type 2 to by sugar");
            Console.WriteLine("Type 3 to by ice");
            Console.WriteLine("Type 4 to by water");
            Console.WriteLine("----------------------");
            UserInput = Convert.ToInt32(Console.ReadLine());
                if(buySupplies.Money < 0)
                {
                    NotEnoughMoney = true;
                    Console.WriteLine("You spent to much, and you might be in debt, fool!");
                    Console.WriteLine("Current Money is : $" + buySupplies.Money + ".");
                    Console.ReadLine();
                    break;
                }
                switch (UserInput)
                {
                    case 1:
                        buySupplies.BuyLemons();
                        
                        break;
                    case 2:
                        buySupplies.BuySugar();
                        
                        break;
                    case 3:
                        buySupplies.BuyIce();
                        
                        break;
                    case 4:
                        buySupplies.BuyWater();
                      
                        break;

                }

            }
           
        }
    }
}

