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
                    " (enter lopettaa)");

                string nimi = Console.ReadLine();
                if (nimi != "")
                {
                    queue.GoToLine(nimi);
                }
                else
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Jonossa " + queue.CheckLenght() + " asiakasta");
                PrintLine(queue.CashierQueue);
            }

            for(int i = 0; i < queue.Lenght; i++)
            {
                Console.WriteLine(queue.LeaveLine());
            }

        }
        static void PrintLine(Queue<string> cashierQueue)
        {
            foreach(string name in cashierQueue)
            {
                Console.WriteLine(name);
            }
        }
    }
}
