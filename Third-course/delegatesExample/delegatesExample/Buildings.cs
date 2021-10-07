using System;

namespace delegatesExample
{
    public class Buildings
    {
        public delegate void Building(Building building);

        public void Add(Building building)
        {
            var testBuilding = (building == null) ? "This building does not exist!" : "New building added!";
            Console.WriteLine(testBuilding);
        }
    }
}
