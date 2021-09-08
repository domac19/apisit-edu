using System;

namespace hyphenExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter few numbers separated by hyphen: ");
            string[] enterNumbers = Console.ReadLine().Split('-');
            int[] numbersArray = Array.ConvertAll(enterNumbers, int.Parse);
            
            bool checkResult = true;

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] + 1 == numbersArray[i - 1] || numbersArray[i] - 1 == numbersArray[i - 1] && checkResult == true)
                {  
                    Console.Write("Consecutive");
                }
                else
                {   
                    checkResult = false;
                    Console.WriteLine("Not Consecutive");
                }
            }
        }
    }
}
