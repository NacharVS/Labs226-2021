using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class TaskListItem
    {
        private bool _inProgress;
        private bool _isDone;
        private string _name;

        public TaskListItem(string Name)
        {
            this.Name = Name;
           
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool InProgress
        {
            get { return _inProgress; }
            set { _inProgress = value; }
        }

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
    }
}
