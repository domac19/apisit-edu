using System;

namespace calculateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool textEnter = true;

            while(textEnter)
            {
                Console.WriteLine("Enter a number or ok to exit!");
                var writeData = Console.ReadLine();
                if(writeData == "ok" || writeData == "5")
                {
                    break;
                }
            }
        }
    }
}
