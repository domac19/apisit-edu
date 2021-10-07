using System;

namespace delegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var welcomeMessage = new Welcome();
            Buildings.Building building = welcomeMessage.AddWelcome;
            building += welcomeMessage.Name;
            welcomeMessage.AddWelcome(building);
            welcomeMessage.Name(building);
            
            var someBuildings = new Buildings();
            Buildings.Building buildingAdd = someBuildings.Add;
            someBuildings.Add(buildingAdd);
        }
    }
}
