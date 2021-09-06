using System;

namespace seriesNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter series of numbers and separate it by comma!");
            var seriesNumbers = Console.ReadLine();

            for (int i = 0; i < seriesNumbers.Length; i++)
            {
                Console.WriteLine(seriesNumbers);
            }

        }
    }
}
