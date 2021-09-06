using System;

namespace factoricalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int factNumber = 1;
            Console.Write(" Hello! Please enter any Number: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numberInput; i++)
            {
                factNumber = factNumber * i;
            }
            Console.Write("Factorial of !" + numberInput + " = " + factNumber);
        }
    }
}
