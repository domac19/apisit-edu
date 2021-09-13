using System;

namespace validationExcercies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number between 1 and 10.");
            int userNumber = Int32.Parse(Console.ReadLine());
            int convertInput = userNumber;
            
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
