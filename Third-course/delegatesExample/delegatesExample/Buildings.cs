using System;

namespace delegatesExample
{
    public class Buildings
    {
        public delegate void Building(Building building);

        public void Add(Building building)
        {
            if (building == null)
            {
                Console.WriteLine("This building does not exist!");
            }
            else
            {
                Console.WriteLine("New building added!");
            }
        }
    }
}
