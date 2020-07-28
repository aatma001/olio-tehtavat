using System;
using System.Collections.Generic;
using System.Text;

namespace T26_Auto
{
    class Rengas
    {

        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string Koko { get; set; }

        public Rengas(string valmistaja, string malli, string koko)
        {
            Valmistaja = valmistaja;
            Malli = malli;
            Koko = koko;
        }
    }
}
