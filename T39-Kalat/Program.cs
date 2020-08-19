using System;
using System.Collections.Generic;

namespace T39_Kalat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kalastaja> kalastajat = new List<Kalastaja>();

            Kalastaja kalastaja = new Kalastaja("Jukka Jalonen", "040066632");
            Console.WriteLine(kalastaja.ToString());

            Console.WriteLine(kalastaja.CatchFish("Hauki", 42.5, 2, new KalaPaikka("OnkLampi", "Turkia"), kalastaja));
            Console.WriteLine(kalastaja.CatchFish("Siika", 50, 3.24, new KalaPaikka("Siikajoki", "Turku"), kalastaja));

            Kalastaja kalastaja1 = new Kalastaja("Jouko Kinnunen", "050443288");
            Console.WriteLine(kalastaja1.ToString());

            Console.WriteLine(kalastaja1.CatchFish("Lohi", 85, 5.43, new KalaPaikka("Urpojoki", "Tampere"), kalastaja1));
            Console.WriteLine(kalastaja1.CatchFish("Silakka", 20, 0.24, new KalaPaikka("Käyrälampi", "Helsinki"), kalastaja1));

            kalastajat.Add(kalastaja);
            kalastajat.Add(kalastaja1);

            KalaRekisteri rekisteri = new KalaRekisteri(kalastajat);

            Console.WriteLine("######Kaikki rekisterin kalat:########\n");
            Console.WriteLine(rekisteri.PrintFishes());

            Console.WriteLine("Kalat painavimmasta kevyimpään:");
            PrintSortedFishes(rekisteri);
        }
        static void PrintSortedFishes(KalaRekisteri rekisteri)
        {
            foreach(Kala kala in rekisteri.SortFishes())
            {
                    Console.WriteLine(kala.Laji + " " + kala.Paino + "kg " + kala.Pituus
                        + "\nPaikka: " + kala.KalaPaikka.Paikka + "\nSijainti: " 
                        + kala.KalaPaikka.Sijainti + "\nKalastaja: " + kala.Kalastaja.Nimi +"\n");
                
            }
        }
    }
}
