using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {

        public bool PriceSet = true;
        public double Money = 80.00;
        public double Revenue;
        public int LemonsOwned = 0;
        public int SugarOwned = 0;
        public int IceOwned = 0;
        public int WaterOwned = 0;
        public int CupsOwned = 0;
        public int CupsLeft;
        public int CupsWithLemonade = 0;
        public Player()
        {

        }
        public void SetLemonadePrice()
        {
            LemonadeBusiness lemonadeBusiness = new LemonadeBusiness();
            if (CupsWithLemonade > 0)
            {
                Console.WriteLine("enter a price to sell your lemonade for..");
                lemonadeBusiness.ChargePriceOfLemonade = Convert.ToInt32(Console.ReadLine());
                PriceSet = true;
            }
            else if (CupsWithLemonade == 0)
            {
                Console.WriteLine("you don't have any lemonade made to sell today.");
                Console.ReadLine();
                Environment.Exit(1);
                PriceSet = false;
            }
        }

    }
}
