using System;
namespace workflowEngine
{
    public class VideoUpload : IWorkflowEngine
    {
        public void Execute()
        {
            Console.WriteLine("Upload video!");
        }

    }
}
