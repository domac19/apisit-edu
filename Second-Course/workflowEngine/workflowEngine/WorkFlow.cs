using System;
using System.Collections.Generic;
namespace workflowEngine
{
    public class WorkFlow : IActivity
    {
        private readonly List<IWorkflowEngine> _workflowEngines = new List<IWorkflowEngine>();
        public void Add(IWorkflowEngine workflowEngine)
        {
            _workflowEngines.Add(workflowEngine);
        }
        public IEnumerable<IWorkflowEngine> GetTasks()
        {
            return _workflowEngines;
        }
    }
}
