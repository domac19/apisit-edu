using System;

namespace askQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number or ok to exit");

            string enterNumber = Convert.ToString(Console.ReadLine());

            while (enterNumber =="")
            {
                Console.WriteLine("Please enter number or ok to exit");
                if (enterNumber == "1")
                {
                    break;
                }
            }
        }
    }
}
