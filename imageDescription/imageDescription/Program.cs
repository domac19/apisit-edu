using System;

namespace imageDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter width and height of your image!");

            int imageWidth = Convert.ToInt32(Console.ReadLine());
            int imageHeight = Convert.ToInt32(Console.ReadLine());

            if (imageWidth > imageHeight)
            {
                Console.WriteLine("Your picture is landscape!");
            }
            else
            {
                Console.WriteLine("Your picture is portrait!");
            }
        }
    }
}
