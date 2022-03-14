using System;

namespace Les_5___Scopes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.testFunction(true, true, 9));
        }

        internal bool testFunction(bool x, bool y, int length)
        {
            bool testBool = false;

            for (int i = 0; i < length; i++)
            {
                if (x && y)
                {
                    testBool = true;
                    x = true;
                }
                else
                {
                    testBool = false;
                    y = false;
                }
            }
            return testBool;
        }
    }
}
