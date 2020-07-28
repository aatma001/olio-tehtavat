using System;
using System.Data;

namespace T28_Liiga
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue joukkue = new Joukkue("Kalpa");
            joukkue.Kotikaupunki = "Kuopio";

            Console.WriteLine(joukkue.ToString());
            Console.WriteLine("Pelaajat:");
            PrintPlayers(joukkue);
        }

        static void PrintPlayers(Joukkue joukkue)
        {
            foreach(Pelaaja item in joukkue.Pelaajat)
            {
                Console.WriteLine(item.EtuNimi + " " + item.SukuNimi + " "
                    + item.PeliPaikka + " Pelinumero: " + item.PeliNumero);
            }
        }
    }
}
