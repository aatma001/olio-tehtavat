using Microsoft.VisualStudio.TestTools.UnitTesting;
using T36_Ostoskärry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T36_Ostoskärry.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void PrintProductsTest()
        {
            List<Product> products = new List<Product>();

            Product product = new Product("Kalja", 0.66);
            Product product1 = new Product("Juusto", 2.7);
            Product product2 = new Product("Kebab", 3.25);
            Product product3 = new Product("Maito", 1.12);
            Product product4 = new Product("Kinkku", 3.99);

            Assert.AreEqual(0, Program.PrintProducts(products));
            products.Add(product);
            Assert.AreEqual(1, Program.PrintProducts(products));
            products.Add(product1);
            Assert.AreEqual(2, Program.PrintProducts(products));
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            Assert.AreEqual(5, Program.PrintProducts(products));
        }
    }
}