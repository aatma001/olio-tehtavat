using System;
using System.Collections.Generic;
using System.Text;

namespace T_20_Nisäkäs
{
    class Ihminen : Nisakas
    {
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public string Nimi { get; set;}

        public Ihminen(int ika, string nimi, int paino, int pituus)
            
        {
            Ika = ika;
            Nimi = nimi;
            Paino = paino;
            Pituus = pituus;
        }

        public override string Liiku()
        {
            return "Liikun";
        }

        public void Kasva()
        {
            Ika += 1;
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + "\n" + "Ikä:  " + Ika + "\n"
                + "Paino: " + Paino + "\n" + "Pituus: " + Pituus + "\n"
                 + Liiku() + "\n";
        }



    }

}
