using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        Player player = new Player();
        public bool PlayerCanBuy = true;
        int Lemon = 1;
        int Sugar = 1;
        int Ice = 1;
        int Water = 1;
        int Cup = 1;
        public double LemonPrice = 2.50;
        public double SugarPrice = 2.00;
        public double IcePrice = 1.00;
        public double WaterPrice = .50;
        public double CupPrice = 1.00;
        public int BuyingInput = Convert.ToInt32(Console.ReadLine());
        public Store()
        {

        }
        public double BuyLemons()
        {
            Console.WriteLine("enter the number of lemons you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (player.Money < LemonPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough player.Money to purchase lemons, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                player.Money = player.Money - (LemonPrice * BuyingInput);
                player.LemonsOwned += (Lemon * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + LemonPrice * BuyingInput + " on lemons");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + player.LemonsOwned + " lemons");
                Console.WriteLine("you now have " + player.SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + player.IceOwned + " ice bags");
                Console.WriteLine("you now have " + player.WaterOwned + " water barrels");
                Console.WriteLine("you now have " + player.CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + player.Money + " remaining");
                Console.WriteLine("--------------------------------");

            }
            return player.Money;
        }
        public double BuySugar()
        {
            Console.WriteLine("enter the amount of sugar you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (player.Money < SugarPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough player.Money to purchase sugar, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {

                PlayerCanBuy = true;
                player.Money = player.Money - (SugarPrice * BuyingInput);
                player.SugarOwned += (Sugar * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + SugarPrice * BuyingInput + " on sugar");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + player.LemonsOwned + " lemons");
                Console.WriteLine("you now have " + player.SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + player.IceOwned + " ice bags");
                Console.WriteLine("you now have " + player.WaterOwned + " water barrels");
                Console.WriteLine("you now have " + player.CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + player.Money + " remaining");
                Console.WriteLine("--------------------------------");
            }

            return player.Money;
        }
        public double BuyIce()
        {
            Console.WriteLine("enter the amount of ice you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (player.Money < IcePrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough player.Money to purchase ice, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                player.Money = player.Money - (IcePrice * BuyingInput);
                player.IceOwned += (Ice * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + LemonPrice * BuyingInput + " on lemons");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + player.LemonsOwned + " lemons");
                Console.WriteLine("you now have " + player.SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + player.IceOwned + " ice bags");
                Console.WriteLine("you now have " + player.WaterOwned + " water barrels");
                Console.WriteLine("you now have " + player.CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + player.Money + " remaining");
                Console.WriteLine("--------------------------------");

            }
            return player.Money;
        }
        public double BuyWater()
        {
            Console.WriteLine("enter the amount of water you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (player.Money < WaterPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough player.Money to purchase water, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                player.Money = player.Money - (WaterPrice * BuyingInput);
                player.WaterOwned += (Water * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + WaterPrice * BuyingInput + " on water");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + player.LemonsOwned + " lemons");
                Console.WriteLine("you now have " + player.SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + player.IceOwned + " ice bags");
                Console.WriteLine("you now have " + player.WaterOwned + " water barrels");
                Console.WriteLine("you now have " + player.CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + player.Money + " remaining");
                Console.WriteLine("--------------------------------");

            }
            return player.Money;
        }
        public double BuyCups()
        {
            Console.WriteLine("enter the number of cups you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (player.Money < CupPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough player.Money to purchase cups, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                player.Money = player.Money - (CupPrice * BuyingInput);
                player.CupsOwned += (Cup * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + CupPrice * BuyingInput + " on cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + player.LemonsOwned + " lemons");
                Console.WriteLine("you now have " + player.SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + player.IceOwned + " ice bags");
                Console.WriteLine("you now have " + player.WaterOwned + " water barrels");
                Console.WriteLine("you now have " + player.CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + player.Money + " remaining");
                Console.WriteLine("--------------------------------");

            }
            return player.Money;
        }
    }
}
