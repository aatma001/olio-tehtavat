using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace T26_Auto
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Rengas> rengasLista = new List<Rengas>();

            rengasLista.Add(new Rengas("Pirelli", "Scorpion", "200/16R14"));
            rengasLista.Add(new Rengas("Nokia", "Hakkapeliitta", "295/50R18"));
            rengasLista.Add(new Rengas("Yokohama", "Saigon", "185/75R14"));

            Auto toyota = new Auto("Toyota", "Corolla", 4, rengasLista);
            Auto mazda = new Auto("Mazda", "Rx7", 6, rengasLista);
            Auto bmw = new Auto("Bmw", "M3", 4, rengasLista);
            

            PrintCarInfo(toyota, "Pirelli");
            PrintCarInfo(mazda, "Nokia");
            PrintCarInfo(bmw, "Yokohama");

        }
        static void PrintCarInfo(Auto auto, string rengasValmistaja)
        {
            Console.WriteLine(auto.ToString() + "{0} " + "{1} " + "{2}" + "\n",
                auto.ChooseTires(rengasValmistaja).Valmistaja,
                auto.ChooseTires(rengasValmistaja).Malli,
                auto.ChooseTires(rengasValmistaja).Koko);       
        }
    }
}
