using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_3___Classes
{
    public class Rekenmachine
    {
        public int AddNumbers(int v1, int v2)
        {
            int answer = v1 + v2;

            return answer;
        }

        public int DivideNumbers(int v1, int v2)
        {
            int answer = v1 / v2;

            return (int)answer;
        }

        public int MultiplyNumbers(int v1, int v2)
        {
            int answer = v1 * v2;

            return answer;
        }
    }
}
