using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CustomerCondition
    {
        public int InterestInBuying;
        public Random thirstLevel = new Random();
        public int Thirst;
        public int ReallyThirsty = 1;
        public int SortOfThirsty = 2;
        public int NotReallyThirsty = 3;
        public CustomerCondition()
        {

        }
    }
}
