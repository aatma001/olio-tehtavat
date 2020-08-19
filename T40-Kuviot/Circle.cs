using System;
using System.Collections.Generic;
using System.Text;

namespace T40_Kuviot
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Nimi = "Circle";
            Radius = radius;
        }

        public override double CountArea()
        {
            return Math.Round(Radius * Math.PI, 2);
        }

        public override double CountCircumference()
        {
            return Math.Round(2 * Radius * Math.PI, 2);
        }
        public override string ToString()
        {
            return Nimi + " Radius: " + Radius.ToString();
        }
    }
}
