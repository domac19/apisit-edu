using System;

namespace stopWatch
{
    public class Stopwatch
    {
        public DateTime startTime;
        public DateTime stopTime;
        public bool isCounting;
        public TimeSpan elapsedTime => (stopTime - startTime);

        public void Start()
        {
            if (isCounting)
            {
                throw new Exception("Can not start stopwatch twice in a row!");
            }
            else
            {
                isCounting = true;
                startTime = DateTime.Now;
            }
        }
        public void Stop()
        {
            if (!isCounting)
            {
                throw new Exception("Can not start stopwatch twice in a row!");
            }
            else
            {
                isCounting = false;
                startTime = DateTime.Now;
            }
        }
    }
}
