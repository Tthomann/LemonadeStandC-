using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadePrice
    {
        double LemonadePriceInput = Convert.ToInt32(Console.ReadLine());
        double ChargePriceOfLemonade;
        public LemonadePrice()
        {

        }
        public double SetLemonPrice()
        {
            ChargePriceOfLemonade = LemonadePriceInput;
            return ChargePriceOfLemonade;
        }
    }
}
