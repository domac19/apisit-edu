using System;
namespace workflowEngine
{
    public class WebService : IWorkflowEngine
    {
        public void Execute()
        {
            Console.WriteLine("Web service start!");
        }
    }
}
