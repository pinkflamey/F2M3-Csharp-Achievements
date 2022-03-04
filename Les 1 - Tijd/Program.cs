using System;

namespace Les_1___Tijd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(dateTime.ToString("T"));

            Console.WriteLine("\nDe maand is " + dateTime.Month + ".");
            Console.WriteLine("Het is dag " + dateTime.Day + ".");
            Console.WriteLine("Het uur is " + dateTime.Hour + ".");
            Console.WriteLine("Dit uur zijn er " + dateTime.Minute + " minuten geweest.");
            Console.WriteLine("Deze minuut zijn er " + dateTime.Second + " seconden geweest.");

        }
    }
}
