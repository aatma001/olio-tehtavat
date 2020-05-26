using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Nimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            List<string> nimiLista = new List<string>();
            int monta = 0;
            Console.WriteLine("Anna henkilöiden nimet. Tyhjä syöte lopettaa.");
            while (true)
            {
                Console.WriteLine("Anna nimi: ");
                string nimi = Console.ReadLine();
                if (nimi != "")
                {
                    nimiLista.Add(nimi);

                }
                else
                {
                    break;
                }
                monta = monta + 1;
            }
            nimiLista.Sort();
            Console.WriteLine(monta + " nimeä annettiin.");
            foreach (string nimi in nimiLista)
            {
                Console.WriteLine(nimi);
            }
            
        }
    }
}