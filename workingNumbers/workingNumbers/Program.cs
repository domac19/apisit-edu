using System;

namespace workingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers to compare them");
            var firstCompare = Convert.ToInt32(Console.ReadLine());
            var secondCompare = Convert.ToInt32(Console.ReadLine());

            if (firstCompare < secondCompare)
            {
                Console.WriteLine("Second number is bigger");
            }
            else
            {
                Console.WriteLine("First number is bigger");
            }
        }
    }
}
