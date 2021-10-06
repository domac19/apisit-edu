using System;

namespace nullableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of nullable!");
            var checkNull = new CheckNullable();
            
            if (checkNull.Maxnum == null)
            {
                Console.WriteLine("Threre is no number inside this number");
            }
        }
    }
}
