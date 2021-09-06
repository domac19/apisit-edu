using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secret number 5");
            
            Random randomNumbers = new Random();
            int guessNumber = randomNumbers.Next(1, 11);

            int userNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < guessNumber; i++)
            {
                Console.WriteLine(guessNumber);
            }
            Console.WriteLine("Wrong number!");
        }
    }
}
