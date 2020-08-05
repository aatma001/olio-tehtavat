using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22_Rajapinta
{
    class Laiva : IActions
    {
        public Laiva()
        {

        }

        public string Move()
        {
            return "LITS LÄTS";
        }

        public string MakeNoise()
        {
            return "Laiva sanoo TUUT!!!1";
        }
    }
}
