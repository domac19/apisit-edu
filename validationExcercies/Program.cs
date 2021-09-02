using System;

namespace validationExcercies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number between 1 and 10.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10)
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
