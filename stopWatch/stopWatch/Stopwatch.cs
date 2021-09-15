using System;

namespace stopWatch
{
    public class Stopwatch
    {
        public DateTime startTime { get; set; }
        public DateTime stopTime { get; set; }
        public TimeSpan elapsedTime { get; }

        public void Start()
        {
            var startTime = DateTime.Now;
        }
        public void Stop()
        {
            var stopTime = DateTime.Now;
        }
    }
}
