using System;

namespace WorkflowEngine
{
    public class Activity1 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Performing Activity 1");
        }
    }
}
