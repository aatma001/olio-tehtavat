using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_Perintä
{
    class PeliHahmo
    {
        public string Name { get; set; }
        public bool IsBad { get; set; }
        public int Health { get; set; }
        public string Weapon { get; set; }

        public PeliHahmo(string name, int health, bool isBad, string weapon)
        {
            Name = name;
            Health = health;
            IsBad = isBad;
            Weapon = weapon;
        }

        public string CheckBad()
        {
            if (IsBad)
            {
                return "Villain ";
            }
            else
            {
                return "Hero ";
            }
        }

        public virtual string Move()
        {
            return "Liikun";
        }

        public virtual string Attack()
        {
            return "Hyökkäys";
        }
        public override string ToString()
        {
            return CheckBad() + Name + " "  + Health + "hp "
                + "Weapon: " + Weapon;
        }
    }
}