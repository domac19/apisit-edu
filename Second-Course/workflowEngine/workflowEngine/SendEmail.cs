using System;
namespace workflowEngine
{
    public class SendEmail : IWorkflowEngine
    {
        public void Execute()
        {
            Console.WriteLine("My mail is: licitar.domagoj@gmail.com");
        }
    }
}
