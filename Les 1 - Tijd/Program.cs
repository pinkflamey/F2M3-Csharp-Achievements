using System;
using System.Threading;

namespace Les_1___Tijd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            int colorCounter = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString("T"));
                Thread.Sleep(1000);

                counter++;

                if (counter == 10)
                {
                    colorCounter++;

                    if (colorCounter == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (colorCounter == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (colorCounter == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (colorCounter == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else if (colorCounter == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        colorCounter = 0;
                    }

                    counter = 0;
                }

            }

        }
    }
}
