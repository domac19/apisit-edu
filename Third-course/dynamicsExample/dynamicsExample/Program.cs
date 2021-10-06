using System;

namespace dynamicsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Domagoj";

            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                name++;
                Console.WriteLine(name);
            }
            catch (Exception error)
            {
                Console.WriteLine("This can not be done becouse name is type string " + error);
            }
            finally
            {
                Console.WriteLine(name);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            name = 1;
            name++;

            if (name > 1)
            {
                Console.WriteLine($"Finnaly error is fixed and I get number: {name}");
            }
        }
    }
}
