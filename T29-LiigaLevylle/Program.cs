using System;
using System.IO;

namespace T29_LiigaLevylle
{

    class Program
    {
        static void Main(string[] args)
        {
            Joukkue joukkue = new Joukkue("Kalpa");
            joukkue.Kotikaupunki = "Kuopio";

            Console.WriteLine(joukkue.ToString());
            SaveAndPrintPlayers(joukkue);
        }

        static void SaveAndPrintPlayers(Joukkue joukkue)
        {
            string path = @"c:\Joukkueet\" + joukkue.Nimi + ".csv";
            if (!File.Exists(path))
            {
                Console.WriteLine("Pelaajat:");
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach(Pelaaja item in joukkue.Pelaajat)
                    {
                        Console.WriteLine(item.EtuNimi + " " + item.SukuNimi + " "
                        + item.PeliPaikka + " Pelinumero: " + item.PeliNumero);

                        sw.WriteLine(item.EtuNimi + " " + item.SukuNimi + " "
                        + item.PeliPaikka + " Pelinumero: " + item.PeliNumero);
                    }
                }
                Console.WriteLine("\nTiedosto luotu ja Pelaajat lisätty onnistuneesti");
            }
            else
            {
                Console.WriteLine("Tiedosto on jo olemassa");
            }
        }
    }
}
