using System;

namespace T9_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle moped = new Vehicle();
            moped.Brand = "Suzuki";
            moped.Model = "PV";
            moped.Tyres = 2;
            moped.Speed = 45;

            Vehicle car = new Vehicle();
            car.Brand = "Honda";
            car.Model = "Civic";
            car.Tyres = 4;
            car.Speed = 180;

            Console.WriteLine("Moped:\n " + moped.ShowInfo());
            Console.WriteLine("Car:\n " + car.ShowInfo());
            Console.WriteLine("");
            Console.WriteLine("Moped:\n" + moped.ToString());
            Console.WriteLine("Car:\n " + car.ToString());
        }
    }
}
