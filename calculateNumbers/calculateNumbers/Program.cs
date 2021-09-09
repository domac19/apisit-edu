using System;

namespace calculateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a number or ok to exit!");
                var writeData = Console.ReadLine();

                if (writeData == "ok")
                {
                    break;
                }
                
                var inputNumber = Convert.ToInt32(writeData);
                if (inputNumber >= 0)
                {
                    break;
                }
            }
        }
    }
}
