using System;
using System.Collections.Generic;
using System.Text;

namespace T29_LiigaLevylle
{
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }

        public Joukkue(string nimi)
        {
            Nimi = nimi;
            Pelaajat = CreatePlayers();
        }

        private List<Pelaaja> CreatePlayers()
        {
            List<Pelaaja> Pelaajat = new List<Pelaaja>();

            Pelaajat.Add(new Pelaaja("Kalle", "Hellgren", "Hyökkääjä", 7));
            Pelaajat.Add(new Pelaaja("Alexander", "Ovetskin", "Hyökkääjä", 10));
            Pelaajat.Add(new Pelaaja("Teemu", "Selänne", "Puolustaja", 8));
            Pelaajat.Add(new Pelaaja("Matti", "Nykänen", "Hyökkääjä", 5));
            return Pelaajat;
        }

        public string ToString()
        {
            return "Joukkue: " + Nimi + " Kotikaupunni: " + Kotikaupunki
                + "\n";
        }
    }

    
}
