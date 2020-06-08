using System;
using System.Collections.Generic;
using System.Text;

namespace T16_Vehicle
{
    public class Bike : Vehicle
    {
        public bool HasGears { get; set; }
        public string GearModel { get; set; }

        public Bike(string _name, string _model, int _makeYear, string _colour, bool _hasGears, string _gearmodel)
            : base(_name, _model, _makeYear, _colour)
        {
            
            HasGears = _hasGears;
            GearModel = _gearmodel;
            

        }
        private string CheckGears()
        {
            if (HasGears)
            {
                return " Gear type: " + GearModel;
            }
            else
            {
                return " Bike doesn't have gears";
            }
        }

        public override string ShowVehicle()
        {
            return "Name :" + Name + " Model: " + Model + " Made in :" + MakeYear + " Colour: " + Colour
                + CheckGears();
        }
    }

}
