using System;

namespace stopWatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isCounting;
        public TimeSpan elapsedTime => (_stopTime - _startTime);

        public void Start()
        {
            if (_isCounting)
            {
                throw new Exception("Can not start stopwatch twice in a row!");
            }
            else
            {
                _isCounting = true;
                _startTime = DateTime.Now;
            }
        }
        public void Stop()
        {
            if (!_isCounting)
            {
                throw new Exception("Can not stop stopwatch twice in a row!");
            }
            else
            {
                _isCounting = false;
                _startTime = DateTime.Now;
            }
        }
    }
}
