using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_Perintä
{
    class Samurai : PeliHahmo
    {
        public Samurai(string name, int health, string weapon, bool isBad)
            : base(name, health, isBad, weapon)
        {

        }

        public override string Attack()
        {
            return "BONZAII ";
        }

        public override string Move()
        {
            return " äänetön liike";
        }


    }
}
