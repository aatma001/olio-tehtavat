using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace T26_Auto
{
    class Auto
    {
        private readonly int maxRenkaidenLkm = 8;
        private readonly List<Rengas> renkaat;
        private readonly int renkaidenLkm;

        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public int MaxRenkaidenLkm => maxRenkaidenLkm;
        public List<Rengas> Renkaat => renkaat;
        public int RenkaidenLkm => renkaidenLkm;

        public Auto(string valmistaja, string malli, int _renkaidenLkm, List<Rengas> _renkaat)
        {
            Valmistaja = valmistaja;
            Malli = malli;
            renkaidenLkm = _renkaidenLkm;
            renkaat = _renkaat;
        }

        public Rengas ChooseTires(string valmistaja)
        {
            return Renkaat.FirstOrDefault(name => name.Valmistaja == valmistaja);
        }

        public string ToString()
        {
            return Valmistaja + " " + Malli + " " + RenkaidenLkm + " rengasta\n";
        }
    }
}