using System;

namespace speedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dear User! Please enter speed limit of your camera!");

            int speedCamera = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter speed of your car!");

            int carSpeed = Convert.ToInt32(Console.ReadLine());

            int speedLimit = 10;
            int determitPoints = 12;

            if(speedCamera < speedLimit)
            {
                Console.WriteLine("Ok!");
            }
            else if(speedCamera > speedLimit)
            {
                Console.WriteLine("For every 5km/hr above the speed limit, 1 demerit points");
            }
            else if(speedCamera > determitPoints )
            {
                Console.WriteLine("License Suspended");
            }
            
        }
    }
}
