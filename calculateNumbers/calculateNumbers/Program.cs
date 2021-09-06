using System;

namespace calculateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterSomething = 0;
            
            while(enterSomething == 0)
            {
                Console.WriteLine("Enter a number or ok to exit!");
                var writeData = Console.ReadLine();

                if (Convert.ToInt32(writeData) > 0)
                {
                    break;
                }
            }
        }
    }
}
