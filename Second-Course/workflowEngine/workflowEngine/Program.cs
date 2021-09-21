using System;

namespace workflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var newFlow = new WorkFlow();
            newFlow.Add(new VideoUpload());
            newFlow.Add(new WebService());
            newFlow.Add(new SendEmail());
            newFlow.Add(new Status());

            var newEngine = new WorkflowEngine();

            newEngine.Run(newFlow);
        }
    }
}
