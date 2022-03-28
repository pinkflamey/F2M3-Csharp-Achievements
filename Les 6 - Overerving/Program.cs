using System;
using System.Threading;

namespace Les_6___Overerving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();

            Console.WriteLine(horse + ": " + horse.PrintHunger());
            Thread.Sleep(1000);

            horse.Feed(5);
            Console.WriteLine(horse + ": " + horse.PrintHunger());
        }
    }
}
