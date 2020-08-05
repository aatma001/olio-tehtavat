using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22_Rajapinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Hirvi hirvi = new Hirvi(31);
            Laiva laiva = new Laiva();

            Console.WriteLine(hirvi.MakeNoise());

            Console.WriteLine("\nLiikutetaan laivaa");
            Console.WriteLine(laiva.Move());

        }
    }
}
