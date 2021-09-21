using System;
namespace workflowEngine
{
    public class Status : IWorkflowEngine
    {
        public void Execute()
        {
            Console.WriteLine("Processing...");
        }
    }
}
