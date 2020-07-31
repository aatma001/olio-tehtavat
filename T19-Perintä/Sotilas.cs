using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_Perintä
{
    class Sotilas : PeliHahmo
    {
        public string Rank { get; set; }

        public Sotilas(string name, int health, string weapon, bool isBad, string rank)
            : base(name, health, isBad, weapon)
        {
            Rank = rank;
        }

        public override string ToString()
        {
            return base.ToString() + " Rank: " + Rank;
        }

        public override string Move()
        {
            return "mars mars";
        }
        public override string Attack()
        {
            return " PUM PUM ";
        }

        public string CallArtillery()
        {
            return " Tykistö kutsuttu";
        }
    }
}

