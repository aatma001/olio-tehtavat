using System;
using System.Collections.Generic;
using System.Text;

namespace T_20_Nisäkäs
{
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen(int ika, string nimi, int paino, int pituus, string auto)
            : base(ika, nimi, paino, pituus)

        {
            Auto = auto;
        }

        public override string Liiku()
        {
            return "Kävelen";
        }

        public override string ToString()
        {
            return base.ToString()  + "Auto: " + Auto + "\n"
                + Liiku() + "\n";
        }
    }
}
