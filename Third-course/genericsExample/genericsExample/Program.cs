using System;
using System.Collections.Generic;
using System.IO;

namespace genericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var listCity = new GenericList<string>("There is list of five big cities in Croatia!");
            Console.WriteLine(listCity.Get());

            var bigCity = new City<int, string>();
            Console.Write(bigCity.AddId(1));
            Console.WriteLine(bigCity.AddValue(" Zagreb"));

            Console.Write(bigCity.AddId(2));
            Console.WriteLine(bigCity.AddValue(" Rijeka"));

            Console.Write(bigCity.AddId(3));
            Console.WriteLine(bigCity.AddValue(" Split"));

            Console.Write(bigCity.AddId(4));
            Console.WriteLine(bigCity.AddValue(" Varaždin"));

            Console.Write(bigCity.AddId(5));
            Console.WriteLine(bigCity.AddValue(" Osijek"));
        }
    }
}
