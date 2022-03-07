using System;

namespace Les_2___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 0, 2, 4, 6, 8, 10 };

            Console.WriteLine("Manier 1:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\nManier 2:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
