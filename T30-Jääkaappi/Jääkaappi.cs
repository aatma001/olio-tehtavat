using System;
using System.Collections.Generic;
using System.Text;

namespace T30_Jääkaappi
{
    class Jääkaappi
    {
        public string Merkki { get; set; }
        public string Teho { get; set; }
        public List<Tuote> Tuotteet { get; set; }

        public Jääkaappi(string merkki, string teho, List<Tuote> tuotteet)
        {
            Merkki = merkki;
            Teho = teho;
            Tuotteet = tuotteet;
        }
        public string ToString()
        {
            return "Merkki: " + Merkki + " Teho: " + Teho;
        }
    }
}
