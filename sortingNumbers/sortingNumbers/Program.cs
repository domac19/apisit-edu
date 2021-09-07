using System;

namespace sortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayNumbers = new int[5];
            Console.WriteLine("Enter five numbers!");
            int enterNumbers = Convert.ToInt32(Console.ReadLine());
            
            while(arrayNumbers.Length > 1)
            {
                Console.WriteLine("Error! Try again!");                             
            }
        }
    }
}
