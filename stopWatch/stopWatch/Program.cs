using System;

namespace stopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            Console.WriteLine("To start StopWatch you need to hit Enter and to stop hit Esc button, for quit press q !");
            while (true)
            {
                ConsoleKeyInfo keyPress = Console.ReadKey();

                if (keyPress.Key == ConsoleKey.Q)
                {
                    return;
                }
                else if (keyPress.Key == ConsoleKey.Escape)
                {
                    stopWatch.Stop();
                    Console.WriteLine($" Elapsed Time: {stopWatch.elapsedTime}");
                }
                else if (keyPress.Key == ConsoleKey.Enter)
                {
                    stopWatch.Start();
                    System.Console.WriteLine("Stopwatch start counting.");
                }
            }
        }
    }
}
