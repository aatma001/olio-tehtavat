using System;
using System.Collections.Generic;
using System.Text;

namespace T39_Kalat
{
    class Kalastaja
    {
        private List<Kala> kalat = new List<Kala>();

        public string Nimi { get; set; }
        public string PuhelinNumero { get; set; }
        public KalaPaikka KalaPaikka { get; set; }

        public List<Kala> Kalat
        {
            get
            {
                return kalat;
            }
        }

        public Kalastaja(string nimi, string puhelinNumero)
        {
            Nimi = nimi;
            PuhelinNumero = puhelinNumero;
        }

        public string CatchFish(string laji, double pituus, double paino, KalaPaikka kalaPaikka, Kalastaja kalastaja)
        {
            kalat.Add(new Kala(laji, pituus, paino, kalaPaikka, kalastaja));
            return "Fisher: " + Nimi + " got a new fish:\n" + "Laji: " + laji + " " + pituus 
                + " " + paino + "\nPaikka:" + kalaPaikka.Paikka + "\nsijainti: " + kalaPaikka.Sijainti
                + "\n"; 
        }
        public string ToString()
        {
            return "A new fisherman added to Fish-register:\n" + Nimi + " "
                + PuhelinNumero + "\n";
        }
    }
}
