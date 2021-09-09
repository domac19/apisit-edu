using System;
using System.Collections.Generic;

namespace englishWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalVolwes = 0;
            
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Please enter a word in English!");
            string sentence = Console.ReadLine().ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    totalVolwes++;
                }
            }
            Console.WriteLine(totalVolwes);
        }
    }
}
