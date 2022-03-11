using System;
using System.Threading;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string helloWorld = "Hello World!";

            foreach (char c in helloWorld)
            {
                Console.Write(c);
                Thread.Sleep(300);
            }

            Console.ReadLine();
        }
    }
}
