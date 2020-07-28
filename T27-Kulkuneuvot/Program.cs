using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace T27_Kulkuneuvot
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo audi = new Kulkuneuvo("Audi", "A3", 4);
            Kulkuneuvo honda = new Kulkuneuvo("honda", "Civic", 4);
            Kulkuneuvo pv = new Kulkuneuvo("Suzuki", "Pv", 2);

            Rengas rengas1 = new Rengas("Hancook", "Pirate", "180/55R16");
            Rengas rengas2 = new Rengas("Michelin", "Pilot", "200/60R18");
            Rengas rengas3 = new Rengas("Heidenau", "Sport", "13/3,5");

            audi.AddTyre(rengas1);
            honda.AddTyre(rengas2);
            pv.AddTyre(rengas3);

            ShowTyresAdded(audi);
            PrintTyres(audi);

            ShowTyresAdded(honda);
            PrintTyres(honda);

            ShowTyresAdded(pv);
            PrintTyres(pv);

        }

        static void PrintTyres(Kulkuneuvo kulkuneuvo)
        {
            Console.WriteLine("Vehicle Name: " + kulkuneuvo.Valmistaja
                    + " " + "Model: " + kulkuneuvo.Malli + "\nTyres:");

            foreach (Rengas item in kulkuneuvo.Renkaat)
            {
                Console.WriteLine(item.Valmistaja + " " + item.Malli
                    + " " + item.Koko);
            }
            Console.WriteLine();
        }

        static void ShowTyresAdded(Kulkuneuvo kulkuneuvo)
        {
            Console.WriteLine("Created a new vehicle " + kulkuneuvo.Valmistaja
                    + " " + kulkuneuvo.Malli);

            foreach(Rengas item in kulkuneuvo.Renkaat)
            {
                Console.WriteLine("Tyre " + item.Valmistaja + " added to "
                    + kulkuneuvo.Valmistaja);
            }
            Console.WriteLine();
        }
        
    }
}
