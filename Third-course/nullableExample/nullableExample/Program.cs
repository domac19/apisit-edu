using System;

namespace nullableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number or press enter!");
            var checkNull = new CheckNullable();
            checkNull.AddSomething(0);
        }
    }
}
