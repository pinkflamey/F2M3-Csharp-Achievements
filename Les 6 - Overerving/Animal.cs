using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_6___Overerving
{
    internal class Animal
    {
        protected int hunger = 100;

        public void Feed()
        {
            hunger--;
        }

        public string PrintHunger() => $"My hunger is now {hunger}";
    }
}
