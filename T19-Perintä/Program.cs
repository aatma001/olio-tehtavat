using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_Perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            Sotilas sotilas = new Sotilas("Jukka", 100, "M16", false, "Kersantti");
            Samurai samurai = new Samurai("Pekka", 200, "Katana", false);
            Hämäkäkki hämäkäkki = new Hämäkäkki("Juho", 30, "Hampaat", true);

            Console.WriteLine(samurai.ToString());
            Console.WriteLine(sotilas.ToString());
            Console.WriteLine(hämäkäkki.ToString());

            Console.WriteLine("\nSotilaan toiminnot:");
            Console.WriteLine(sotilas.Move() + sotilas.Attack() + sotilas.CallArtillery());
            
        }
    }
}
