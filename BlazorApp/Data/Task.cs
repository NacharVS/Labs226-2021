using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Task
    {
        private bool _inProgress;
        private bool _isDone;
        public string Name;

        public bool InProgress
        {
            get { return _inProgress; }
            set { _inProgress = value; }
        }

        public bool IsDone
        {
            get { return _inProgress; }
            set { _inProgress = value; }
        }


    }
}
