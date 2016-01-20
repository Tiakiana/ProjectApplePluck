using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrchard
{
    class Sale
    {
        public string Type { get; set; }

        public decimal Kg { get; set; }

        public decimal Price { get; set; }

        public string Location { get; set; }

        public DateTime SaleDate { get; set; }

        public Sale()
        {

        }

        public Sale(string type, decimal kg, decimal price, string location, DateTime date)
        {
            this.Type = type;
            this.Kg = kg;
            this.Price = price;
            this.Location = location;
            this.SaleDate = date;
        }
    }
}
