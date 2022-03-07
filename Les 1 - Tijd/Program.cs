using System;
using System.Threading;

namespace Les_1___Tijd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString("T"));
                Thread.Sleep(1000);

            }

        }
    }
}
