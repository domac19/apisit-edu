using System;

namespace counterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;

            for (int i = 1; i <= length; i++)
            {
                if (i % 3 == 0)
                {
                    length++;
                }
                Console.WriteLine(length);
            }
        }
    }
}
