using System;
using System.Collections.Generic;
using System.Text;

namespace T30_Jääkaappi
{
    class Tuote
    {
        public string Nimi { get; set; }
        public int Määrä { get; set; }

        public Tuote(string nimi, int määrä)
        {
            Nimi = nimi;
            Määrä = määrä;
        }
    }
}
