using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFruit
{
    class Treatment
    {
        private Utilities.treatments treatmentDescription { get; set; }
        private Utilities.chemicals chemical { get; set; }
        private int dosage { get; set; }

        public Treatment(Utilities.treatments treatmentDescription, Utilities.chemicals chemical, int dosage)
        {
            this.treatmentDescription = treatmentDescription;
            this.chemical = chemical;
            this.dosage = dosage;
        }
    }
}
