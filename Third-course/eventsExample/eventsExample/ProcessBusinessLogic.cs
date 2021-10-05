using System;
using System.Collections.Generic;

namespace eventsExample
{
    public class ProcessBusinessLogic
    {
        private string _text;
        private List<int> _numbers = new List<int>();  
        
        public delegate void Notify();

        public event Notify ProcessCompleted; 

        public void StartProcess()
        {
            if (String.IsNullOrEmpty(_text))
            {
                Console.WriteLine("Process Started!");
            }
            OnProcessCompleted();

            _numbers.Add(1);
            _numbers.Add(0);
            _numbers.Add(1);

            Console.Write("This is the output: ");
            foreach (var item in _numbers)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
