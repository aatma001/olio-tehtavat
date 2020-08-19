using System;
using System.Collections.Generic;
using System.Text;
namespace T37_Ostokset
{
    class Program
    {
        static void Main(string[] args)
        {
            List<InvoiceItem> items = new List<InvoiceItem>();

            items.Add(new InvoiceItem("Suklaa", 2.40 ,2));
            items.Add(new InvoiceItem("Olut", 1.05, 24));
            items.Add(new InvoiceItem("Leipä", 3.20, 1));

            Invoice invoice = new Invoice("Juhani", items);
            Console.WriteLine(PrintInvoice(invoice));
            Console.WriteLine("Total: " + invoice.ItemsTogether
                + " pieces " + invoice.CountTotal() + "e");
        }

        private static string PrintInvoice(Invoice invoice)
        {
            string toString = "Customer " + invoice.Customer + "'s invoice:\n";
            toString += "=================================\n";

            foreach (InvoiceItem item in invoice.Items)
            {
                toString += item.Name + "\t" + item.Quantity + " pieces "
                    + Math.Round(item.Total, 2) + "e\n";
            }
            toString += "=================================";
            return toString;
        }
    }
}
