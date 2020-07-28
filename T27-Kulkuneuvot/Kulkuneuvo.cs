using System;
using System.Collections.Generic;
using System.Text;

namespace T27_Kulkuneuvot
{
    class Kulkuneuvo
    {

        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public int RenkaidenLkm { get; set; }
        
        public List<Rengas> Renkaat = new List<Rengas>();

        public Kulkuneuvo(string valmistaja, string malli, int renkaidenLkm)
        {
            Valmistaja = valmistaja;
            Malli = malli;
            RenkaidenLkm = renkaidenLkm;
        }

        public void AddTyre(Rengas rengas)
        {
            for (int i = 0; i < RenkaidenLkm; i++)

            {
                Renkaat.Add(rengas);
            }   
        }
    }
}
