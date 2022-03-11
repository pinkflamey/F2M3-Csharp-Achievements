using System;

namespace Les_1___Functies
{
    internal class Program
    {

        public string AddTwoWords(string word1, string word2)
        {
            return word1 + " " + word2;
        }
        static void Main(string[] args)
        {
            Program pr = new Program();

            Console.WriteLine("Enter word 1: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter word 2: ");
            string word2 = Console.ReadLine();

            string result = pr.AddTwoWords(word1, word2);

            Console.WriteLine("Result: " + result);

            char[] array = result.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine("Result backwards: " + new string(array));

        }
    }
}
