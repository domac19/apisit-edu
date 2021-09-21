using System;
using System.Collections.Generic;
namespace workflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IActivity activity)
        {
            foreach (IWorkflowEngine workflow in activity.GetTasks())
            {
                workflow.Execute();
            }
        }
    }
}
