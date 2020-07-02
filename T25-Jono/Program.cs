using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace T25_Jono
{
    class Program
    {
        static void Main(string[] args)
        {
            KassaJono queue = new KassaJono(new Queue<string>());
            while (true)
            {
                Console.WriteLine("Anna jonoon tulevan asiakkaan nimi," +
                    " käsittele asiakas painamalla p");

                string nimi = Console.ReadLine();
                if (nimi != "" && nimi != "p")
                {
                    queue.GoToLine(nimi);
                }
                else if(nimi == "p")
                {
                    Console.WriteLine(queue.LeaveLine());
                    
                }
                else
                {
                    Console.WriteLine("Kauppa kiinni, menkää kotionne");
                    break;
                }
                
                Console.WriteLine("Asiakkaita jonossa: " + queue.CheckLenght());
                CheckLine(queue.CashierQueue);
                Console.WriteLine();
            }

            static void CheckLine(Queue<string> cashierQueue)
            {
                foreach (string name in cashierQueue)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
