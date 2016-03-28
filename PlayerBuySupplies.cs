using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand 
{
    public class PlayerBuySupplies : BasePriceOfSupplies
    {
        PlayerSupplyContainer AmountOfSupplies = new PlayerSupplyContainer();
        BasePriceOfSupplies basePriceOfSupplies = new BasePriceOfSupplies();
        public bool PlayerCanBuy;
        public int BuyingInput;
        int Lemon = 1;
        int Sugar = 1;
        int Ice = 1;
        int Water = 1;
        int Cup = 1;
       
        public PlayerBuySupplies()
        {

        }
        public double BuyLemons()
        {
            Console.WriteLine("enter the number of lemons you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (basePriceOfSupplies.Money < basePriceOfSupplies.LemonPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase lemons!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (LemonPrice * BuyingInput);
                AmountOfSupplies.LemonsOwned += (Lemon * BuyingInput);
                Console.WriteLine("You just spent $" + LemonPrice * BuyingInput + " on lemons");
                Console.WriteLine("you now have " + AmountOfSupplies.LemonsOwned + " lemons");
                Console.WriteLine("You have $" + Money + " remaining");
            }
            return Money;
        }
        public double BuySugar()
        {
            Console.WriteLine("enter the amount of sugar you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (basePriceOfSupplies.Money < basePriceOfSupplies.SugarPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase sugar!");
                PlayerCanBuy = false;
            }
            else
            {
                
                PlayerCanBuy = true;
                Money = Money - (SugarPrice * BuyingInput);
                AmountOfSupplies.SugarOwned += (Sugar * BuyingInput);
                Console.WriteLine("You just spent $" + SugarPrice * BuyingInput + " on sugar");
                Console.WriteLine("you now have " + AmountOfSupplies.SugarOwned + " sugar");
                Console.WriteLine("You have $" + Money + " remaining");
            }
           
            return Money;
        }
        public double BuyIce()
        {
            Console.WriteLine("enter the amount of ice you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (basePriceOfSupplies.Money < basePriceOfSupplies.IcePrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase ice!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (IcePrice * BuyingInput);
                AmountOfSupplies.IceOwned += (Ice * BuyingInput);
                Console.WriteLine("You just spent $" + LemonPrice * BuyingInput + " on lemons");
                Console.WriteLine("you now have " + AmountOfSupplies.LemonsOwned + " lemons");
                Console.WriteLine("You have $" + Money + " remaining");
            }
            return Money;
        }
        public double BuyWater()
        {
            Console.WriteLine("enter the amount of water you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (basePriceOfSupplies.Money < basePriceOfSupplies.WaterPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase water!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (WaterPrice * BuyingInput);
                AmountOfSupplies.WaterOwned += (Water * BuyingInput);
                Console.WriteLine("You just spent $" + WaterPrice * BuyingInput + " on water");
                Console.WriteLine("you now have " + AmountOfSupplies.WaterOwned + " barrels of water");
                Console.WriteLine("You have $" + Money + " remaining");
            }
            return Money;
        }
        public double BuyCups()
        {
            Console.WriteLine("enter the number of cups you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (basePriceOfSupplies.Money < basePriceOfSupplies.CupPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase cups!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (CupPrice * BuyingInput);
                AmountOfSupplies.CupsOwned += (Cup * BuyingInput);
                Console.WriteLine("You just spent $" + CupPrice * BuyingInput + " on cups");
                Console.WriteLine("you now have " + AmountOfSupplies.LemonsOwned + " bags of cups");
                Console.WriteLine("You have $" + Money + " remaining");
            }
            return Money;
        }
    }
}

