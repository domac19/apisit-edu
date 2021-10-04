using System;
using System.Collections.Generic;
using System.IO;

namespace genericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var listCity = new GenericList<string>("Zagreb, Split, Rijeka, Varaždin");
            Console.WriteLine(listCity.Get());

            Console.WriteLine("Lista od 5 velikih gradova u RH!");
            var bigCity = new City<int, string>();
            Console.WriteLine(bigCity.AddId(1));
            Console.WriteLine(bigCity.AddValue("Zagreb"));

            Console.WriteLine(bigCity.AddId(2));
            Console.WriteLine(bigCity.AddValue("Rijeka"));

            Console.WriteLine(bigCity.AddId(3));
            Console.WriteLine(bigCity.AddValue("Split"));

            Console.WriteLine(bigCity.AddId(4));
            Console.WriteLine(bigCity.AddValue("Varaždin"));

            Console.WriteLine(bigCity.AddId(5));
            Console.WriteLine(bigCity.AddValue("Osijek"));
        }
    }
}
