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
        int BuyingInput = Convert.ToInt32(Console.ReadLine());
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
            if (basePriceOfSupplies.Money < basePriceOfSupplies.LemonPrice)
            {
                Console.WriteLine("you don't have enough money to purchase lemons!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (LemonPrice * BuyingInput);
                AmountOfSupplies.LemonsOwned += (Lemon * BuyingInput);
            }
            return Money;
        }
        public double BuySugar()
        {
            if (basePriceOfSupplies.Money < basePriceOfSupplies.SugarPrice)
            {
                Console.WriteLine("you don't have enough money to purchase sugar!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (SugarPrice * BuyingInput);
                AmountOfSupplies.SugarOwned += (Sugar * BuyingInput);
            }
            return Money;
        }
        public double BuyIce()
        {
            if (basePriceOfSupplies.Money < basePriceOfSupplies.IcePrice)
            {
                Console.WriteLine("you don't have enough money to purchase ice!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (IcePrice * BuyingInput);
                AmountOfSupplies.IceOwned += (Ice * BuyingInput);
            }
            return Money;
        }
        public double BuyWater()
        {
            if (basePriceOfSupplies.Money < basePriceOfSupplies.WaterPrice)
            {
                Console.WriteLine("you don't have enough money to purchase water!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (WaterPrice * BuyingInput);
                AmountOfSupplies.WaterOwned += (Water * BuyingInput);
            }
            return Money;
        }
        public double BuyCups()
        {
            if (basePriceOfSupplies.Money < basePriceOfSupplies.CupPrice)
            {
                Console.WriteLine("you don't have enough money to purchase cups!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (CupPrice * BuyingInput);
                AmountOfSupplies.CupsOwned += (Cup * BuyingInput);
            }
            return Money;
        }
    }
}

