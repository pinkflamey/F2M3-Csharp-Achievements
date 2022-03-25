using System;

namespace Les_2___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Manier 1:");
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] / 2) * 2 == array[i])
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.WriteLine("\nManier 2:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
