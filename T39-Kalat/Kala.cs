using System;
using System.Collections.Generic;
using System.Text;

namespace T39_Kalat
{
    class Kala
    {
        public string Laji { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }
        public KalaPaikka KalaPaikka { get; set; }
        public Kalastaja Kalastaja { get; set; }

        public Kala(string laji, double pituus, double paino, KalaPaikka kalaPaikka, Kalastaja kalastaja)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
            KalaPaikka = kalaPaikka;
            Kalastaja = kalastaja;
        }
    }
}
