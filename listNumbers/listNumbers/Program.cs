using System;
using System.Collections.Generic;
namespace listNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] numbersArray;
                Console.WriteLine("Write a list of comma separated numbers!");
                var addNumbers = Console.ReadLine();
                numbersArray = addNumbers.Split(',');

                if (addNumbers == "" || numbersArray.Length < 5)
                {
                    Console.WriteLine("Invalid list!");
                }
               else 
                {
                    Console.WriteLine(addNumbers);
                    Console.WriteLine("Three smallest numbers");
                    for (var i = 0; i < 3; i++)
                    {
                        Console.WriteLine(addNumbers[i]);
                    }
                    break;
                }
            }
        }
    }
}
