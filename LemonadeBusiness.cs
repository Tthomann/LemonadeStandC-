using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class LemonadeBusiness
    {


        public double ChargePriceOfLemonade;
        public int CupsSold = 1;
        public LemonadeBusiness()
        {

        }

        public void CustomerBuyLemonade()
        {
            CustomerInfluence customerInfluence = new CustomerInfluence();
            Player playerInventory = new Player();
            if (customerInfluence.InterestInBuying >= customerInfluence.InterestInBuyingCapacity)
            {
                playerInventory.CupsLeft = playerInventory.CupsWithLemonade - 1;
                playerInventory.Revenue = CupsSold * ChargePriceOfLemonade;
                Console.WriteLine("A customer has bought a cup of lemonade");
                playerInventory.Money += playerInventory.Revenue;

            }
            else

            {
                Console.WriteLine("A customer wasn't in the mood to buy lemonade");
            }
        }
    }
}
