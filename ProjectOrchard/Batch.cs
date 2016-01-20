using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFruit
{
    class Batch
    {
        private int kg { get; set; }
        private int pickingDate { get; set; }
        private int deliveryDate { get; set; }
        private string description { get; set; }
        private Utilities.fruits fruit { get; set; }
        private Utilities.fruitNames name { get; set; }
        private List<Treatment> treatments { get; set; }
        public Batch(int kg, int pickingDate, int deliveryDate, string description, Utilities.fruits fruit, Utilities.fruitNames name, List<Treatment> treatments)
        {
            this.kg = kg;
            this.pickingDate = pickingDate;
            this.deliveryDate = deliveryDate;
            this.description = description;
            this.fruit = fruit;
            this.name = name;
            this.treatments = treatments;
        }
    }
}
