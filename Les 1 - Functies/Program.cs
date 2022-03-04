using System;

namespace Les_1___Functies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string AddTwoWords(string word1, string word2)
            {
                return word1 + " " + word2;
            }

            Console.WriteLine("Enter word 1: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter word 2: ");
            string word2 = Console.ReadLine();

            Console.WriteLine("Result: " + AddTwoWords(word1, word2));

        }
    }
}
