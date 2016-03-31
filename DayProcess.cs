using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DayProcess
    {
        Store store = new Store();


        public bool ExitGame;
        public DayProcess()
        {

        }
        public void TitleMenu()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
            Console.WriteLine("Type 1 to begin the game");
            Console.WriteLine("Type 2 to end the game");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            switch (UserInput)
            {
                case 1:

                    Console.WriteLine("The Price for Lemons is: $" + store.LemonPrice + " per bag of lemons");
                    Console.WriteLine("The Price for Sugar is: $" + store.SugarPrice + " per bag of sugar");
                    Console.WriteLine("The Price for Ice is: $" + store.IcePrice + " per bag of ice");
                    Console.WriteLine("The Price for Water is: $" + store.WaterPrice + " per containers of water");
                    Console.WriteLine("The Price for Cups is: $" + store.CupPrice + " per bag of cups");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("[NOTE: it also takes 4 lemons, 3 sugar bags, 2 ice bags, 1 water barrel, and 5 cups to make 20 cups of lemonade]");
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    break;
                case 2:
                    ExitGame = true;
                    Console.WriteLine("shutting down...");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
        public void RunSupplyBuyer()
        {
            LemonadeBusiness lemonadeBusiness = new LemonadeBusiness();
            Player player = new Player();
            while (!ExitGame)
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
                int SupplyInput = Convert.ToInt32(Console.ReadLine());
                if (player.Money < 0)
                {
                    Console.WriteLine("You spent to much, and you might be in debt, fool!");
                    Console.WriteLine("Current Money is : $" + player.Money + ".");
                    Console.ReadLine();
                    break;
                }
                switch (SupplyInput)
                {
                    case 1:
                        store.BuyLemons();


                        break;
                    case 2:
                        store.BuySugar();

                        break;
                    case 3:
                        store.BuyIce();

                        break;
                    case 4:
                        store.BuyWater();

                        break;
                    case 5:
                        store.BuyCups();

                        break;
                    case 6:
                        if (player.LemonsOwned < 4 || player.SugarOwned < 3 || player.IceOwned < 2 || player.WaterOwned < 1 || player.CupsOwned < 5)
                        {
                            Console.WriteLine("you don't have enough supplies to make lemonade.");
                            break;
                        }else 

                        {


                            player.LemonsOwned = player.LemonsOwned - 4;
                            player.SugarOwned = player.SugarOwned - 3;
                            player.IceOwned = player.IceOwned - 2;
                            player.WaterOwned = player.WaterOwned - 1;
                            player.CupsOwned = player.CupsOwned - 5;
                            player.CupsWithLemonade = player.CupsWithLemonade + 40;
                            Console.WriteLine("You've made 40 cups of Lemonade! Nice!");
                        }

                        break;
                    case 7:


                        if (player.CupsWithLemonade > 0)
                        {
                            Console.WriteLine("enter a price to sell your lemonade for..");
                            lemonadeBusiness.ChargePriceOfLemonade = Convert.ToInt32(Console.ReadLine());
                            ExitGame = true;
                            break;

                        }
                        else if (player.CupsWithLemonade == 0)
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


