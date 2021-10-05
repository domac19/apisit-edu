using System;

namespace eventsExample
{
    class Program
    {  
        static void Main()
        {
                var businessLogic = new ProcessBusinessLogic();
                businessLogic.ProcessCompleted += bl_ProcessCompleted; 
                businessLogic.StartProcess();
        }
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
