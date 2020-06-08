using System;

namespace T16_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle bike1 = new Bike("Helkama", "Jopo", 1999, "White", false, "");
            Console.WriteLine("Bike info:");
            Console.WriteLine(bike1.ShowVehicle());

            Vehicle bike2 = new Bike("Tunturi", "Supersport", 2014, "Green", true, "Shimano");
            Console.WriteLine("Bike 2 info:");
            Console.WriteLine(bike2.ShowVehicle());

            Vehicle boat1 = new Boat("Yamaha", "Buster", 2000, "Black", "Motorboat", 4);
            Console.WriteLine("Boat info");
            Console.WriteLine(boat1.ShowVehicle());

            Vehicle boat2 = new Boat("Ahti", "Top class", 2018, "Yellow", "Rowingboat", 3);
            Console.WriteLine("Boat 2 info");
            Console.WriteLine(boat2.ShowVehicle());
        }
    }
}
