using System;

namespace validationExcercies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number between 1 and 10.");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            var convertInput = Convert.ToInt32(userNumber);
            
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
