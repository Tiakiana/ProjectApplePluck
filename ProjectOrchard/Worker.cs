using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFruit
{
    class Worker
    {
        private string name { get; set; }
        private List<Utilities.experience> experience { get; set; }
        private List<Task> tasks { get; set; }
        private List<Work> workInfo;
        
        public Worker(string name)
        {
            this.name = name;
            experience = new List<Utilities.experience>();
            tasks = new List<Task>();
            workInfo = new List<Work>();
        }
        internal void addExperience(Utilities.experience xp)
        {
            experience.Add(xp);
        }
    }
}
