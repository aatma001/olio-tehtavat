using System;
using System.Collections.Generic;
using System.Text;

namespace T39_Kalat
{
    class KalaPaikka
    {
        public string Paikka { get; set; }
        public string Sijainti { get; set; }

        public KalaPaikka(string nimi, string paikka)
        {
            Paikka = nimi;
            Sijainti = paikka;
        }
    }
}
