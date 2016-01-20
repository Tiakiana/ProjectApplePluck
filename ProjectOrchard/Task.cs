using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFruit
{
    class Task
    {
        private string worker { get; set; }
        private Utilities.tasks task { get; set; }
        private string description { get; set; }
        public Task(string worker, Utilities.tasks task, string description)
        {
            this.worker = worker;
            this.task = task;
            this.description = description;
        }
    }
}
