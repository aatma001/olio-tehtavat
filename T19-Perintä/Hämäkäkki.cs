using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_Perintä
{
    class Hämäkäkki : PeliHahmo
    {
        public Hämäkäkki(string name, int health, string weapon, bool isBad)
            : base(name, health, isBad, weapon)
        {

        }

        public override string Attack()
        {
            return " 5 damage given";
        }

        public override string Move()
        {
            return " TSIP TSIP";
        }
    }
}
