using System;
using System.Collections.Generic;
using System.Text;

namespace T_20_Nisäkäs
{
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(int ika, string nimi, int paino, int pituus, string vaippa)
           : base(ika, nimi, paino, pituus)
        {
            Vaippa = vaippa;
        }


        public override string Liiku()
        {
            return "Konttaan";
        }

        public override string ToString()
        {
            return base.ToString() + "Vaippa: " + Vaippa + "\n"
                + Liiku() + "\n";
        }
    }
}
