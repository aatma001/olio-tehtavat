using System;
using System.Collections.Generic;
using System.Text;

namespace T37_Ostokset
{
    class InvoiceItem
    {
        private readonly double total;

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total
        {
            get
            {
                return Price * Quantity;
            }
        }

        public InvoiceItem(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
