using System;
using System.Collections.Generic;
using System.Text;

namespace T16_Vehicle
{
    public class Boat : Vehicle
    {
        public string Type { get; set; }
        public int Seats { get; set; }

        public Boat(string _name, string _model, int _makeYear, string _colour, string _type, int _seats)
           : base(_name, _model, _makeYear, _colour)
        {
            Type = _type;
            Seats = _seats;

        }
        public override string ShowVehicle()
        {
            return "Name :" + Name + " Model: " + Model + " Made in :" + MakeYear + " Colour: " + Colour
                + " Type: " + Type + " No of seats: " + Seats;
        }
    }   
}
