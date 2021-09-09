using System;

namespace reverseName
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name here!");
            string enterName = Console.ReadLine();

            char[] arrayNames = enterName.ToCharArray();
            Array.Reverse(arrayNames);

            Console.WriteLine(arrayNames);

        }
    }
}
