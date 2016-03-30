using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class PlayersLemonadeStand
    {
      
        Customer customers;
        public PlayersLemonadeStand(Customer CustomerAtLemonadeStand)
        {
            this.customers = CustomerAtLemonadeStand;
        }
        public void SpawnCustomer()
        {
            List<int> AllCustomers = new List<int>();
            Random CustomerRandom = new Random();
            for (int i = 0; i < CustomerRandom.Next(20, 50); i++)
            {
                AllCustomers.Add(i);
            }
            foreach (int customer in AllCustomers)
            {
            customers.CustomerBuyLemonade();
            Console.WriteLine(customers.InterestInBuying);
                Console.WriteLine();
            }
        }
    }
}


