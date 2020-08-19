using System;
using System.Collections.Generic;
using System.Text;

namespace T40_Kuviot
{
    public abstract class Shape
    {
        public string Nimi { get; set;}

        public abstract double CountArea();

        public abstract double CountCircumference();

        public abstract string ToString();
    }
}
