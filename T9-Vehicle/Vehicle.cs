using System;
using System.Collections.Generic;
using System.Text;

namespace T9_Vehicle
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public Vehicle()
        {

        }


        public string ShowInfo()
        {
            return "Brand: " + Brand + " Model: " + Model;
        }

        public override string ToString()
        {
            return "Brand: " + Brand + " Model: " + Model + " Speed: " + Speed + " Tryres: " + Tyres;
        }
    }   

}
