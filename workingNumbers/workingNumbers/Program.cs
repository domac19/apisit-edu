using System;

namespace workingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers to compare them");
            int firstCompare = Convert.ToInt32(Console.ReadLine());
            int secondCompare = Convert.ToInt32(Console.ReadLine());

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
