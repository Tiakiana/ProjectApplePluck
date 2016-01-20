using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFruit
{
    class Sale
    {
        private int revenue { get; set; }
        private Utilities.sale name { get; set; }
        private List<Batch> batch { get; set; }
        private DateTime orderedDate { get; set; }
        private DateTime deliveredDate { get; set; }
        public Sale(int revenue, Utilities.sale name, List<Batch> batch, DateTime orderedDate)
        {
            this.revenue = revenue;
            this.name = name;
            this.batch = batch;
            this.orderedDate = orderedDate;
        }
    }
}
