using System;

namespace lambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            var evenNumbers = new int[5] {1,2,3,4,5 };
            Console.WriteLine("This is a list of 5 even numbers!");
            
            foreach (var item in evenNumbers)
            {
                Func<int, int> num = number => number * item;
                Console.WriteLine(num(2));
            }
            var helloMessage = new Message();
            helloMessage.AddMessage();
        }
    }
}
