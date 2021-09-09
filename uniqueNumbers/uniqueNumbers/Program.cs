using System;
using System.Collections.Generic;

namespace uniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var numberList = new List<string> { };

                Console.WriteLine("Enter number or type QUIT to exit");
                var enterNumber = Console.ReadLine();
                numberList.Add(enterNumber);
                
                if(enterNumber == "QUIT" || enterNumber.Length >= 1)
                {
                    Console.WriteLine(enterNumber);
                    break;
                }
            }
        }
    }
}
