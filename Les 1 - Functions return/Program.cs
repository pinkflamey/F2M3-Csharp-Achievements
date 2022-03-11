using System;
using System.Threading;

namespace Les_1___Functions_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string myName(string name)
            {
                return "\nYour name is " + name + "!";
            }
            string randomNumber()
            {
                Random r = new Random();
                int rInt = r.Next(1, 20);
                return rInt.ToString();
            }

            Console.WriteLine("Enter your name:");
            string enteredName = Console.ReadLine();
            Console.WriteLine(myName(enteredName));
            
            Thread.Sleep(1000);

            Console.WriteLine("Random number 1-20: " + randomNumber());
            Console.WriteLine("Random number 1-20: " + randomNumber());
            Console.WriteLine("Random number 1-20: " + randomNumber());

            Thread.Sleep(1000);

        }
    }
}
