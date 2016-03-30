using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand 
{
    public class StoreSupplies : PlayerSupplyContainer
    {
        BasePriceOfSupplies basePriceOfSupplies = new BasePriceOfSupplies();
        

       
        
        public bool PlayerCanBuy;
        public bool doneBuying;
        public int BuyingInput;
        public double ChargePriceOfLemonade;
        int Lemon = 1;
        int Sugar = 1;
        int Ice = 1;
        int Water = 1;
        int Cup = 1;
        public int CupsLeft;
        public int CupsSold = 1;
        
       
        public StoreSupplies()
        {

      
        }
        public double BuyLemons()
        {
            Console.WriteLine("enter the number of lemons you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (Money < basePriceOfSupplies.LemonPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase lemons, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (basePriceOfSupplies.LemonPrice * BuyingInput);
                LemonsOwned += (Lemon * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + basePriceOfSupplies.LemonPrice * BuyingInput + " on lemons");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + LemonsOwned + " lemons");
                Console.WriteLine("you now have " + SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + IceOwned + " ice bags");
                Console.WriteLine("you now have " + WaterOwned + " water barrels");
                Console.WriteLine("you now have " + CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + Money + " remaining");
                Console.WriteLine("--------------------------------");
               
            }
            return Money;
        }
        public double BuySugar()
        {
            Console.WriteLine("enter the amount of sugar you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (Money < basePriceOfSupplies.SugarPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase sugar, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                
                PlayerCanBuy = true;
                Money = Money - (basePriceOfSupplies.SugarPrice * BuyingInput);
                SugarOwned += (Sugar * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + basePriceOfSupplies.SugarPrice * BuyingInput + " on sugar");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + LemonsOwned + " lemons");
                Console.WriteLine("you now have " + SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + IceOwned + " ice bags");
                Console.WriteLine("you now have " + WaterOwned + " water barrels");
                Console.WriteLine("you now have " + CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + Money + " remaining");
                Console.WriteLine("--------------------------------");
            }
           
            return Money;
        }
        public double BuyIce()
        {
            Console.WriteLine("enter the amount of ice you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (Money < basePriceOfSupplies.IcePrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase ice, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (basePriceOfSupplies.IcePrice * BuyingInput);
                IceOwned += (Ice * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + basePriceOfSupplies.LemonPrice * BuyingInput + " on lemons");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + LemonsOwned + " lemons");
                Console.WriteLine("you now have " + SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + IceOwned + " ice bags");
                Console.WriteLine("you now have " + WaterOwned + " water barrels");
                Console.WriteLine("you now have " + CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + Money + " remaining");
                Console.WriteLine("--------------------------------");
              
            }
            return Money;
        }
        public double BuyWater()
        {
            Console.WriteLine("enter the amount of water you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (Money < basePriceOfSupplies.WaterPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase water, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (basePriceOfSupplies.WaterPrice * BuyingInput);
                WaterOwned += (Water * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + basePriceOfSupplies.WaterPrice * BuyingInput + " on water");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + LemonsOwned + " lemons");
                Console.WriteLine("you now have " + SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + IceOwned + " ice bags");
                Console.WriteLine("you now have " + WaterOwned + " water barrels");
                Console.WriteLine("you now have " + CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + Money + " remaining");
                Console.WriteLine("--------------------------------");
         
            }
            return Money;
        }
        public double BuyCups()
        {
            Console.WriteLine("enter the number of cups you'd like to buy for today");
            BuyingInput = Convert.ToInt32(Console.ReadLine());
            if (Money < basePriceOfSupplies.CupPrice * BuyingInput)
            {
                Console.WriteLine("you don't have enough money to purchase cups, or you've entered a number quantity too large to purchase currently!");
                PlayerCanBuy = false;
            }
            else
            {
                PlayerCanBuy = true;
                Money = Money - (basePriceOfSupplies.CupPrice * BuyingInput);
                CupsOwned += (Cup * BuyingInput);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You just spent $" + basePriceOfSupplies.CupPrice * BuyingInput + " on cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("you now have " + LemonsOwned + " lemons");
                Console.WriteLine("you now have " + SugarOwned + " sugar bags");
                Console.WriteLine("you now have " + IceOwned + " ice bags");
                Console.WriteLine("you now have " + WaterOwned + " water barrels");
                Console.WriteLine("you now have " + CupsOwned + " cups");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("You have $" + Money + " remaining");
                Console.WriteLine("--------------------------------");
          
            }
            return Money;
        }
        public void RunSupplyBuyer()
        {
            while (!doneBuying)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Type 1 to by lemons");
                Console.WriteLine("Type 2 to by sugar");
                Console.WriteLine("Type 3 to by ice");
                Console.WriteLine("Type 4 to by water");
                Console.WriteLine("Type 5 to by cups");
                Console.WriteLine("When you are finished buying supplies, press 6 to create the lemonade.");
                Console.WriteLine("Press 7 to set a price for your lemonade.");
                Console.WriteLine("----------------------");
                BuyingInput = Convert.ToInt32(Console.ReadLine());
                if (Money < 0)
                {
                    Console.WriteLine("You spent to much, and you might be in debt, fool!");
                    Console.WriteLine("Current Money is : $" + Money + ".");
                    Console.ReadLine();
                    break;
                }
                switch (BuyingInput)
                {
                    case 1:
                        BuyLemons();


                        break;
                    case 2:
                        BuySugar();

                        break;
                    case 3:
                        BuyIce();

                        break;
                    case 4:
                        BuyWater();

                        break;
                    case 5:
                        BuyCups();

                        break;
                    case 6:
                        if (LemonsOwned < 4 || SugarOwned < 3 || IceOwned < 2 || WaterOwned < 1 || CupsOwned < 5)
                        {
                            Console.WriteLine("you don't have enough supplies to make lemonade.");
                            break;
                        }
                        
                        {

                           
                            LemonsOwned = LemonsOwned - 4;
                            SugarOwned = SugarOwned - 3;
                            IceOwned = IceOwned - 2;
                            WaterOwned = WaterOwned - 1;
                            CupsOwned = CupsOwned - 5;
                            CupsWithLemonade = CupsWithLemonade + 100;
                            Console.WriteLine("You've made 100 cups of Lemonade! Nice!");
                        }
                        
                        break;
                    case 7:
                       
        
                        if (CupsWithLemonade > 0)
                        {
                            Console.WriteLine("enter a price to sell your lemonade for..");
                            ChargePriceOfLemonade = Convert.ToInt32(Console.ReadLine());
                            doneBuying = true;
                            break;
                            
                        }
                        else if (CupsWithLemonade == 0)
                        {
                            Console.WriteLine("you don't have any lemonade made to sell today.");
                            Console.ReadLine();
                            Environment.Exit(1);
                            break;
                        }
                        break;
        


    }

            }

        }
    }
}

