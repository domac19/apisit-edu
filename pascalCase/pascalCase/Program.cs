using System;

namespace pascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter few words separated by space!");
            char [] enterWords = Console.ReadLine().ToCharArray();
            enterWords[0] = char.ToUpper(enterWords[0]);
            
            Console.WriteLine(enterWords);
        }
    }
}
