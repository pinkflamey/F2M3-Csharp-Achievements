using System;

namespace Les_2___Variables_en_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intNumber = 1;
            float floatNumber = intNumber;
            Console.WriteLine(floatNumber);

            int intNumber2 = 75;
            char character = (char)intNumber2;
            Console.WriteLine("number is " + intNumber2 + ", character is " + character);
            Console.WriteLine("Het is een letter geworden, omdat character een unicode-character moet geven. De letter " + character + " hoort bij nummer " + intNumber2 + ".");

        }
    }
}
