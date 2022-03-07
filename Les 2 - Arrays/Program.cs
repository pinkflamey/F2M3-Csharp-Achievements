using System;

namespace Les_2___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers1 = { 10, 20, 30, 40, 50, 60 };

            Console.WriteLine("-----");
            Console.WriteLine("Starting array:");

            foreach (int i in numbers1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----");

            int arrayLength = numbers1.Length;
            Console.WriteLine("Array length is " + arrayLength);
            Console.WriteLine("-----");

            int[] numbers2 = new int[6];
            int counter = 0;

            for (int i = arrayLength - 1; i >= 0; i--)
            {

                numbers2[counter] = numbers1[i];
                counter++;

                Console.WriteLine("Given array 2 section " + counter + " the content of array 1 section " + i + ": " + numbers1[i]);
            }

            Console.WriteLine("-----");
            Console.WriteLine("Array backwards:");
            
            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----");


        }
    }
}
