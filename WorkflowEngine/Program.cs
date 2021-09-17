using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.AddActivity(new Activity1());
            workflowEngine.AddActivity(new Activity2());
            workflowEngine.Run();
        }
    }
}
