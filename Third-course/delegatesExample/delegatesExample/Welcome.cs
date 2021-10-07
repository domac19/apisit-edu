using System;
namespace delegatesExample
{
    public class Welcome
    {
        public void AddWelcome(Buildings.Building building)
        {
            Console.WriteLine("Welcome to my city!");
        }
        public void Name(Buildings.Building building)
        {
            Console.WriteLine("My name is Domagoj Licitar");
        }
    }
}
