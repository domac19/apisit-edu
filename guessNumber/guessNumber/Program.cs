using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secret number 5");
            
            Random randomNumbers = new Random();
            int guessNumber = randomNumbers.Next(1, 10);

            for (int i = 1; i <= 4; i++)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == guessNumber)
                {
                    Console.WriteLine("You won!");
                }
                else if( userNumber != guessNumber)
                {
                    Console.WriteLine("You lost!");
                }
            }
        }
    }
}
