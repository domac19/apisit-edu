using System;

namespace delegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var someBuildings = new Buildings();
            Buildings.Building building = someBuildings.Add;
            someBuildings.Add(building);
        }
    }
}
