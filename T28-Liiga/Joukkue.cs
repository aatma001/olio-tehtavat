using System;
using System.Collections.Generic;
using System.Text;

namespace T28_Liiga
{
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }

        public Joukkue(string nimi)
        {
            Nimi = nimi;
            Pelaajat = CreatePlayers(nimi);
        }

        private List<Pelaaja> CreatePlayers(string nimi) 
        {
            List<Pelaaja> pelaajat = new List<Pelaaja>();

            if (nimi == "Kalpa")
            {
                pelaajat.Add(new Pelaaja("Kalle", "Hellgren", "Hyökkääjä", 7));
                pelaajat.Add(new Pelaaja("Alexander", "Ovetskin", "Hyökkääjä", 10));
                pelaajat.Add(new Pelaaja("Steven", "Häkkinen", "Puolustaja", 66));
            }
            else if (nimi == "Jokerit")
            {
                pelaajat.Add(new Pelaaja("Teemu", "Selänne", "Puolustaja", 8));
                pelaajat.Add(new Pelaaja("Matti", "Nykänen", "Hyökkääjä", 5));
            }
            return pelaajat;
        }

        public string ToString()
        {
            return "Joukkue: " + Nimi + " Kotikaupunni: " + Kotikaupunki
                + "\n";
        }
    }
}
