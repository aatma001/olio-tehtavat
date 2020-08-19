using System;
using System.Collections.Generic;
using System.Text;

namespace T37_Ostokset
{
    class Invoice
    {
        public string Customer { get; set; }
        public int ItemsCount { get; private set; }
        public int ItemsTogether { get; private set; }
        public List<InvoiceItem> Items { get; set; }

        public Invoice(string customer, List<InvoiceItem> items)
        {
            Customer = customer;
            Items = items;
            ItemsTogether = CountItems();
        }

        public double CountTotal()
        {
            double totalSum = 0;

            foreach(InvoiceItem item in Items)
            {
                totalSum += item.Total;
                
            }
            return Math.Round(totalSum, 2);
        }
        public int CountItems()
        {
            int itemsTogether = 0;
            foreach (InvoiceItem item in Items)
            {
                itemsTogether += item.Quantity;
            }
            return itemsTogether;
        }
    }
}
