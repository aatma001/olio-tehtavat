using System;
using System.Collections.Generic;
using System.Text;

namespace T40_Kuviot
{
    class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public Rectangle(double widht, double height)
        {
            Nimi = "Rectangle";
            Widht = widht;
            Height = height;
        }
        public override double CountArea()
        {
            return Math.Round((Widht * Height), 2);
        }
        public override double CountCircumference()
        {
            return Math.Round(2 * Widht + 2 * Height, 2);
        }
        public override string ToString()
        {
            return Nimi + " Widht: " + Widht.ToString() + " Height: " + Height.ToString(); 
        }
    }
}
