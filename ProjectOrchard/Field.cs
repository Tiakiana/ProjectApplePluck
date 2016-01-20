using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFruit
{
    class Field
    {
        private string id { get; set; }
        private List<Tuple<Utilities.chemicals,DateTime>> usedChemicals { get; set; }
        private Utilities.fruits fruit;
        private List<Batch> batchesHarvested;
        private List<Batch> batchesLeft;

        public Field(string id, Utilities.fruits fruit)
        {
            this.id = id;
            this.fruit = fruit;
            usedChemicals = new List<Tuple<Utilities.chemicals, DateTime>>();
            batchesHarvested = new List<Batch>();
            batchesLeft = new List<Batch>();
        }
        internal void addChemical(Utilities.chemicals usedChemical, DateTime date)
        {
            usedChemicals.Add(new Tuple<Utilities.chemicals,DateTime>(usedChemical, date));
        }
    }
}
