using System;

namespace validationExcercies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number between 1 and 10.");
            var userNumber = Console.ReadLine();
            int parseNumber; 
            Int32.TryParse(userNumber, out parseNumber);            
            int convertInput = parseNumber;
            
            if (convertInput >= 1 && convertInput <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
