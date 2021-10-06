using System;

namespace dynamicsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name to see if you can use ++ operator to type string!");
            var dynamicName = new Dynamic();
            dynamicName.TryThis();
            dynamicName.OrThis();
        }
    }
}
