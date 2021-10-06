using System;
using System.Linq;

namespace linqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is list of cars listed by Name");
            var newCars = new Cars().GetCarInfos();
            var carInfo = newCars.Where(b => b.Value >200000).OrderBy(b => b.Name);

            foreach (var car in carInfo)
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
