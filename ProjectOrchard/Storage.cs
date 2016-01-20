
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace persistance
{
    class Storage
    {
        private List<Domain.Purchases> purchases;
        private List<Domain.Field> fields;
        private List<Domain.Batch> batches;
        private List<Domain.Workers> workers;
        private List<Domain.Sale> sales;

        internal List<Purchases> Purchases
        {
            get
            {
                return purchases;
            }
        }

        internal List<Field> Fields
        {
            get
            {
                return fields;
            }
        }

        internal List<Batch> Batches
        {
            get
            {
                return batches;
            }
        }

        internal List<Workers> Workers
        {
            get
            {
                return workers;
            }
        }

        internal List<Sale> Sales
        {
            get
            {
                return sales;
            }
        }

        public Storage()
        {
            purchases = new List<Domain.Purchases>();
            fields = new List<Domain.Field>();
            batches = new List<Domain.Batch>();
            workers = new List<Domain.Workers>();
            sales = new List<Domain.Sale>();
        }
        internal bool addPurchase(Domain.Purchases dp)
        {
            bool result = false;
            if (!purchases.Contains(dp))
            {
                purchases.Add(dp);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        internal bool addField(Domain.Field df)
        {
            bool result = false;
            if (!fields.Contains(df))
            {
                fields.Add(df);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        internal bool addBatch(Domain.Batch db)
        {
            bool result = false;
            if (!batches.Contains(db))
            {
                batches.Add(db);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        internal bool addWorker(Domain.Workers dw)
        {
            bool result = false;
            if (!workers.Contains(dw))
            {
                workers.Add(dw);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
