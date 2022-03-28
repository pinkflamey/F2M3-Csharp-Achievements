using System;
using System.Threading;

namespace Les_5___Getters_and_Setters
{
    internal class Program
    {

        
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Dog dog = new Dog();
            Console.WriteLine("\nWe have a dog, " + dog + "!");

            Thread.Sleep(1000);

            bool throwBall = false;
            Console.WriteLine("\nDo you want to throw a ball? (y/n)");
            switch (Console.ReadLine())
            {
                case "y": throwBall = true; break;
                default: throwBall = false; break;
            }

            if (throwBall)
            {
                Console.WriteLine("\nFetch the ball!");
                Thread.Sleep(2000);
                Console.WriteLine(dog.FetchBall(new Ball()));
                Ball ball = dog.PickUpBall();
                Console.WriteLine(ball);
            }

            Console.WriteLine("\nHow hard do you want to pet the doggo? (0-4)");
            string intensityString = Console.ReadLine();
            int intensity;
            try
            {
                Int32.TryParse(intensityString, out intensity);
            }
            catch
            {
                Console.WriteLine("You didn't enter a number, so we defaulted to 0.");
                intensity = 0;
            }
            Console.WriteLine(dog.Pet(intensity));
        }
    }
}
