using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T36_Ostoskärry
{
    public class Product
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public Product(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }


    }
}
