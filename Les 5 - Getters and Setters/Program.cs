using System;
using System.Threading;

namespace Les_5___Getters_and_Setters
{
    internal class Program
    {

        
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Ball ball = new Ball();
            string ballName = ball.GiveBall();
            Console.WriteLine("We have a ball: " + ballName + "!");

            Thread.Sleep(1000);

            Console.WriteLine("\nThis dog is named...");
            string name = Console.ReadLine();

            Thread.Sleep(1000);

            Dog dog = new Dog(name);

            Console.WriteLine("\nWe have a dog, and their name is " + dog.GetName() + "!");

            Thread.Sleep(1000);

            bool throwBall = false;
            Console.WriteLine("\nDo you want to throw " + ballName + "? (y/n)");
            switch (Console.ReadLine())
            {
                case "y": throwBall = true; break;
                default: throwBall = false; break;
            }

            if (throwBall)
            {
                Console.WriteLine("\nFetch the ball, " + dog.GetName() + "!");
                Thread.Sleep(2000);
                Console.WriteLine(dog.FetchBall());
            }

            Console.WriteLine("\nHow hard do you want to pet " + dog.GetName() + "? (0-4)");
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
