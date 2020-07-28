using System;
using System.Collections.Generic;
using System.Text;

namespace T29_LiigaLevylle
{
    class Pelaaja
    {
        public string EtuNimi { get; set; }
        public string SukuNimi { get; set; }
        public string PeliPaikka { get; set; }
        public int PeliNumero { get; set; }

        public Pelaaja(string etuNimi, string sukuNimi, string peliPaikka,
            int peliNumero)
        {
            EtuNimi = etuNimi;
            SukuNimi = sukuNimi;
            PeliPaikka = peliPaikka;
            PeliNumero = peliNumero;
        }
    }
}
