using System;

namespace englishWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an English word!");
            char[] englishWord = Console.ReadLine().ToCharArray();

            Console.Write(englishWord.Length);
        }
    }
}
