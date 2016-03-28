using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class MakeLemonade
    {
        PlayerSupplyContainer SupplyInventory = new PlayerSupplyContainer();
        BasePriceOfSupplies InventoryCalculation = new BasePriceOfSupplies();
        public bool CanMakeLemonade;
        public MakeLemonade()
        {

        }

        public void CreateLemonade()
        {
            if(SupplyInventory.LemonsOwned < 4)
            {
                Console.WriteLine("you don't have enough lemons to make any lemonade!");
                CanMakeLemonade = false;
            }
            if (SupplyInventory.SugarOwned < 3)
            {
                Console.WriteLine("you don't have enough lemons to make any lemonade!");
                CanMakeLemonade = false;
            }
            if (SupplyInventory.IceOwned < 2)
            {
                Console.WriteLine("you don't have enough lemons to make any lemonade!");
                CanMakeLemonade = false;
            }
            if (SupplyInventory.WaterOwned < 1)
            {
                Console.WriteLine("you don't have enough lemons to make any lemonade!");
                CanMakeLemonade = false;
            }
            if (SupplyInventory.CupsOwned < 5)
            {
                Console.WriteLine("you don't have enough lemons to make any lemonade!");
                CanMakeLemonade = false;
            }
            else
            {
                CanMakeLemonade = true;
                LemonadeCalculateInventory();
            }

        }

        public void LemonadeCalculateInventory()
        {
            SupplyInventory.LemonsOwned = SupplyInventory.LemonsOwned - 4;
            SupplyInventory.SugarOwned = SupplyInventory.SugarOwned - 3;
            SupplyInventory.IceOwned = SupplyInventory.IceOwned - 2;
            SupplyInventory.WaterOwned = SupplyInventory.WaterOwned - 1;
            SupplyInventory.CupsOwned = SupplyInventory.CupsOwned - 5;
            InventoryCalculation.Money = InventoryCalculation.Money - (InventoryCalculation.LemonPrice + InventoryCalculation.IcePrice + InventoryCalculation.SugarPrice + InventoryCalculation.WaterPrice + InventoryCalculation.CupPrice);
            SupplyInventory.LemonadePitchers = SupplyInventory.LemonadePitchers + 2;
            Console.WriteLine("You've made 2 pitchers of Lemonade! Nice!");
        }
    }
}
