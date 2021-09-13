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
                int parsingNumber;
                Int32.TryParse(enterInput, out parsingNumber);
                numberList.Add(parsingNumber);
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
