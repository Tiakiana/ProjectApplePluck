using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrchard
{
    class Sale
    {
        private string Type { get; }
        private decimal Kg { get; }
        private decimal Price { get; }
        private string Location { get; }
        private DateTime Date { get; }

        public Sale(string type, decimal kg, decimal price, string location, DateTime date)
        {
            Type = type;
            Kg = kg;
            Price = price;
            Location = location;
            Date = date;
        }
    }
}