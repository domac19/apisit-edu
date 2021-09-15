using System;
using System.Threading;

namespace stopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.elapsedTime;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
            timeSpan.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
