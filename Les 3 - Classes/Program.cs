using System;

namespace Les_3___Classes
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Rekenmachine calc = new Rekenmachine();

            Console.WriteLine("Hello World!");
            Console.Write("Choose one:\n==========\n1. +\n2. *\n3. /\nOption (1, 2, 3): ");

            string choice = Console.ReadLine();

            

            switch (choice)
            {
                case "1":
                    Console.Write("Number 1: ");
                    string addInN1 = Console.ReadLine();
                    Console.Write("Number 2: ");
                    string addInN2 = Console.ReadLine();

                    int addN1;
                    int addN2;

                    try
                    {
                        Int32.TryParse(addInN1, out addN1);
                        Int32.TryParse(addInN2, out addN2);
                        Console.WriteLine("Result: " + calc.AddNumbers(addN1, addN2));
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Please enter full numbers.");
                        break;
                    }

                    break;

                case "2":
                    Console.Write("Number 1: ");
                    string mulInN1 = Console.ReadLine();
                    Console.Write("Number 2: ");
                    string mulInN2 = Console.ReadLine();

                    int mulN1;
                    int mulN2;

                    try
                    {
                        Int32.TryParse(mulInN1, out mulN1);
                        Int32.TryParse(mulInN2, out mulN2);
                        Console.WriteLine("Result: " + calc.MultiplyNumbers(mulN1, mulN2));
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Please enter full numbers.");
                        break;
                    }

                    break;

                case "3":
                    Console.Write("Number 1: ");
                    string divInN1 = Console.ReadLine();
                    Console.Write("Number 2: ");
                    string divInN2 = Console.ReadLine();

                    int divN1;
                    int divN2;

                    try
                    {
                        Int32.TryParse(divInN1, out divN1);
                        Int32.TryParse(divInN2, out divN2);

                        Console.WriteLine("Result: " + calc.DivideNumbers(divN1, divN2));
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Please enter full numbers.");
                        break;
                    }

                    break;

                default:
                    Console.WriteLine("Please enter 1, 2, 3.");

                    break;
            }
        }
    }

    

}
