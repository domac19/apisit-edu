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
                var enterNumbers = Convert.ToInt32(Console.ReadLine());
                if (listNumbers.Contains(enterNumbers))
                {
                    Console.WriteLine(enterNumbers);
                    break;
                }
                listNumbers.Add(enterNumbers);
            }
            listNumbers.Sort();
        }
    }
}
