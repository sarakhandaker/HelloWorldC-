using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public interface IActivity
    {
        void Execute();
    }

    public interface IWorkFlow
    {
        void AddActivity(IActivity activity);
        void RemoveActivity(IActivity activity);
        IEnumerable<IActivity> GetTasks();
    }

    public class WorkFlow : IWorkFlow
    {
        private List<IActivity> _workFlowList { get;}

        public WorkFlow()
        {
            this._workFlowList = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            _workFlowList.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            _workFlowList.Remove(activity);
        }

        public IEnumerable<IActivity> GetTasks()
        {
            return _workFlowList;
        }
    }

    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is Uploading");
        }
    }

    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email is Sending");
        }
    }

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (IActivity activity in workFlow.GetTasks())
                {
                activity.Execute();
            }

        }
    }
}