using System;
using Microsoft.VisualBasic.CompilerServices;

namespace T40_Kuviot
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();

            shapes.ShapeList.Add(new Rectangle(12, 15));
            shapes.ShapeList.Add(new Rectangle(4, 3));
            shapes.ShapeList.Add(new Rectangle(6, 6));
            shapes.ShapeList.Add(new Circle(2));
            shapes.ShapeList.Add(new Circle(1));
            shapes.ShapeList.Add(new Circle(3));

            
            foreach(Shape item in shapes.ShapeList)
            {
                Console.WriteLine(item.ToString() + " Area: " +  item.CountArea() 
                    + " Circumference: " + item.CountCircumference());
            }





        }
    }
}
