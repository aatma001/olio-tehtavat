
using System;
using System.Linq;

namespace T2_Mäkihyppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int kokonaispisteet = 0;
            int kaikkipisteet = 0;
            int[] pisteet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.WriteLine("Tuomari " + (i + 1)  + " anna tyylipisteet:");
                    string strpisteet = Console.ReadLine();
                    if (Int32.TryParse(strpisteet, out pisteet[i]))
                    {
                        kaikkipisteet = kaikkipisteet + pisteet[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Eipä ollu numero\n");
                        continue;
                    }
                }
            }

            kokonaispisteet = kaikkipisteet - pisteet.Max() - pisteet.Min();
            Console.WriteLine("kaikkien tuomarien pisteet: " + kaikkipisteet);
            Console.WriteLine("lopulliset pisteet: " + kokonaispisteet);
        }
    }
}

