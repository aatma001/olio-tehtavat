using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace T17_Radio
{
    class Sähkölaite
    {
        public bool IsOn { get; set; }
        public float Power { get; set;}
        

    public Sähkölaite()
        {
            IsOn = false;
            Power = 500;
        }

        public string IsOnOff()
        {
            if(IsOn)
            {
                return "Turning device on \n";
            }
            else
            {
                return "Device is off";
            }
        }
   
   
    }
}
