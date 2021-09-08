using System;

namespace hyphenExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkResult = true;

            Console.Write("Enter few numbers separated by hyphen: ");
            string[] enterNumbers = Console.ReadLine().Split('-');
            int[] numbersArray = Array.ConvertAll(enterNumbers, int.Parse);

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] + 1 == numbersArray[i - 1] || numbersArray[i] - 1 == numbersArray[i - 1] && checkResult == true)
                {  
                    checkResult = true;
                }
                else
                {   
                    checkResult = false;
                }
            }
            if (checkResult)
            {
                Console.WriteLine("The Numbers are consecutive");
            }
            else
            {
                Console.WriteLine("They are not consecutive");
            }
        }
    }
}
