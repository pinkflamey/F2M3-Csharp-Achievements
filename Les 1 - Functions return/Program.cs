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

            Console.WriteLine("Enter your name:");
            string enteredName = Console.ReadLine();
            Console.WriteLine(myName(enteredName));
            
            Thread.Sleep(1500);

        }
    }
}
