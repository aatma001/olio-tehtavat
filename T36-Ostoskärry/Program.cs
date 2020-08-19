using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T36_Ostoskärry
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Kalja", 0.66));
            products.Add(new Product("Juusto", 2.7));
            products.Add(new Product("Kebab", 3.25));

            PrintProducts(products);
        }

        public static int PrintProducts(List<Product> products)
        {
            Console.WriteLine("Your products in shopping cart:");

            foreach(Product item in products)
            {
                Console.WriteLine(item.Nimi + " " + item.Hinta + "e");
            }
            Console.WriteLine("There are " + products.Count + " products in shopping cart");
            return products.Count;
        }
    }
}
