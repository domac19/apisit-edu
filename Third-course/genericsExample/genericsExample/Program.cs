using System;
using System.Collections.Generic;
using System.IO;

namespace genericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var listCity = new GenericList<string>("Zagreb");
            Console.WriteLine(listCity.Get());

            Console.Write("Lista velikih gradova u RH!");
            var bigCity = new City<int, string>("Zagreb",1);
            Console.WriteLine(bigCity.AddId());
            Console.WriteLine(bigCity.AddValue());
        }
    }
}
