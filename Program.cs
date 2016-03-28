using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionText Text = new OptionText();
            PlayerBuySupplies BuyingSupplies = new PlayerBuySupplies();
            //below this
            Text.TitleMenu();
            Text.BuyTypeOfSupply();
            
        }
    }
}
