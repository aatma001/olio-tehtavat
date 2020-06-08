using System;
using System.Collections.Generic;
using System.Text;

namespace T16_Vehicle
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int MakeYear { get; set; }
        public string Colour { get; set; }

        public Vehicle(string _name, string _model, int _makeYear, string _colour)
        {
            Name = _name;
            Model = _model;
            MakeYear = _makeYear;
            Colour = _colour;
        }

        public virtual string ShowVehicle()
        {
            return "Name :" + Name + "Model: " + Model + "Made in :" + MakeYear + "Colour: " + Colour;
                
        }
    }

}
