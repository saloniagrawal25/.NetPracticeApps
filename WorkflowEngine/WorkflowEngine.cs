using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public readonly List<IActivity> _activityList;

        public WorkflowEngine()
        {
            _activityList = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            _activityList.Add(activity);
        }
        public void Run()
        {
            if(_activityList.Count>0)
            {
                foreach(var activity in _activityList)
                {
                    activity.Execute();
                }
            }
        }
    }
}
