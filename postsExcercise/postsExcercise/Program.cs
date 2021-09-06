using System;
using System.Collections.Generic;

namespace postsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter different names or press Enter and exit! ");

                var inputText = Console.ReadLine();
                if (inputText == "")
                {
                    break;
                }
            }
        }
    }
}
