using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22_Rajapinta
{
    class Hirvi : IActions
    {
        public int Age { get; set; }

        public Hirvi(int age)
        {
            Age = age;
        }

        public string Move()
        {
            return "kops kops";
        }

        public string MakeNoise()
        {
            return "Hirvi sanoo MUUU";
        }
    }
}
