using System;
using System.Collections.Generic;
namespace listNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var displayNumbers = new List<int> ();

            while (true)
            {
                Console.WriteLine("Write a list of comma separated numbers!");
                int listNumbers = Convert.ToInt32(Console.ReadLine());

                if (displayNumbers.Count == 0 || displayNumbers.Count <= 5)
                {
                    Console.WriteLine("Invalid list!");
                }
                else
                {
                    displayNumbers.Add(listNumbers);
                }
                
            }
        }
    }
}
