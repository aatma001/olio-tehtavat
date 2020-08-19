using System;
using System.Collections.Generic;

namespace T30_Jääkaappi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuote> tuotteet = new List<Tuote>();

            tuotteet.Add(new Tuote("Jogurtti", 3));
            tuotteet.Add(new Tuote("Maito", 1));
            tuotteet.Add(new Tuote("Kurkku", 2));
            tuotteet.Add(new Tuote("Tomaatti", 4));

            Jääkaappi jääkaappi = new Jääkaappi("BOSCH", "200W", tuotteet);

            Console.WriteLine("Jääkaappi: " + jääkaappi.ToString());
            Console.WriteLine("Jääkaapin sisältö:");

            foreach(Tuote item in jääkaappi.Tuotteet)
            {
                Console.WriteLine(item.Nimi + " Määrä: " + item.Määrä);
            }

        }
    }
}
