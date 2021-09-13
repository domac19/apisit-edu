using System;
using System.Collections.Generic;

namespace sortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNumbers = new List<int>();

            while (listNumbers.Count < 5)
            {
                Console.WriteLine("Enter five numbers!");
                var enterNumbers = Console.ReadLine();
                int parseNumbers;
                Int32.TryParse(enterNumbers, out parseNumbers);

                if (listNumbers.Contains(parseNumbers))
                {
                    Console.WriteLine(enterNumbers);
                    continue;
                }
                listNumbers.Add(parseNumbers);
            }
            listNumbers.Sort();

            foreach (var enterNumbers in listNumbers)
            {
                Console.WriteLine(enterNumbers);
            }
        }
    }
}
