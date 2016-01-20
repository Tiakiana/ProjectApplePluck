using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrchard
{
    class SaleController
    {
        private List<Sale> sales = new List<Sale> { };

        public SaleController()
        {

        }

        public bool CreateSale(string type, decimal price, decimal kg, string location)
        {
            // Create Sale object
            Sale item = new Sale(type, kg, price, location, DateTime.Now);


            return true;
        }

        public void CreateSale(string type, decimal price, decimal kg, string location, DateTime date)
        {

        }

        public void UpdateSale()
        {

        }

        public void DeleteSale()
        {

        }

        public List<Sale> LookBetweenDates(DateTime startdate, DateTime enddate)
        {
            return new List<Sale> { };
        }
    }
}
