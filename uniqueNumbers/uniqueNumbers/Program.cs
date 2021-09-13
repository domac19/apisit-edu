using System;
using System.Collections.Generic;

namespace uniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int> { };
            while (true)
            {
                Console.WriteLine("Enter number or type QUIT to exit");
                var enterInput = Console.ReadLine();
                
                if(enterInput.ToLower() == "quit")
                {
                    break;
                }
                numberList.Add(Int32.Parse(enterInput));
            }

            var uniqueNumbers = new List<int> { };
            foreach (var number in numberList)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniqueNumbers)
                Console.WriteLine(number);
        }
    }
}
