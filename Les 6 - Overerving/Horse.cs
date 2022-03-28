using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_6___Overerving
{
    internal class Horse : Animal
    {
        public void Feed(int hungerMinus)
        {
            hunger = hunger - hungerMinus;
        }
    }
}
