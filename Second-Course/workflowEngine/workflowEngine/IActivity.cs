using System;
using System.Collections.Generic;
namespace workflowEngine
{
    public interface IActivity
    {
        void Add(IWorkflowEngine workflowEngine);
        IEnumerable<IWorkflowEngine> GetTasks();
    }
}
