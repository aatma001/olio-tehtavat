using System;
using System.Collections.Generic;
using System.Linq;

namespace T31_MiniASIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Opiskelija> opiskelijaLista = new List<Opiskelija>();

            opiskelijaLista.Add(new Opiskelija("Hanna", "Husso", "TTV19S1"));
            opiskelijaLista.Add(new Opiskelija("Kirsi", "Kernel", "TTV19S2"));
            opiskelijaLista.Add(new Opiskelija("Masa", "Niemi", "TTV19S3"));
            opiskelijaLista.Add(new Opiskelija("Teppo", "Testaaja", "TTV19SM"));
            opiskelijaLista.Add(new Opiskelija("Allan", "Aalto", "TTV19SMM"));

            GiveAsioNum(opiskelijaLista);
            ShowStudents(opiskelijaLista);
            ShowSortedStudents(opiskelijaLista);

            Console.WriteLine("Anna opiskelijan etunimi: ");
            string etuNimi = Console.ReadLine();
            Console.WriteLine("Anna opiskelijan sukunimi: ");
            string sukuNimi = Console.ReadLine();
            Console.WriteLine("Ryhmä: ");
            string ryhmä = Console.ReadLine();
            Console.WriteLine("AsioId:");
            string asioId = Console.ReadLine();

            if (CheckAsionumber(opiskelijaLista, asioId))
            {
                Console.WriteLine("Opiskelijan lisääminen onnistui\n");
                opiskelijaLista.Add(new Opiskelija(etuNimi, sukuNimi, ryhmä, asioId));
            }
            else
            {
                Console.WriteLine("AsioId on jo käytössä");
            }
            ShowSortedStudents(opiskelijaLista);
        }
        

        static bool CheckAsionumber(List<Opiskelija> opiskelijaLista, string newAsioId)
        {
            bool asioCheck = true;

            foreach (Opiskelija item in opiskelijaLista)
            {
                if(item.AsioId == newAsioId)
                {
                    asioCheck = false;
                }
            }
            return asioCheck;
        }

        static void GiveAsioNum(List<Opiskelija> opiskelijaLista)
        {
            int i = 1;
            foreach(Opiskelija item in opiskelijaLista)
            {
                item.CreateAsioId(i);
                i++;
            }
        }

        static void ShowStudents(List<Opiskelija> opiskelijaLista)
        {
            IEnumerable<Opiskelija> OrderByFirstName = opiskelijaLista.OrderBy(p => p.EtuNimi);

            foreach (Opiskelija item in opiskelijaLista)
            {
                Console.WriteLine(item.EtuNimi + " " + item.SukuNimi + " " + item.Ryhmä
                    + " " + item.AsioId);
            }
            Console.WriteLine();
        }

        static void ShowSortedStudents(List<Opiskelija> opiskelijaLista)
        {
            IEnumerable<Opiskelija> OrderByFirstName = opiskelijaLista.OrderBy(p => p.EtuNimi);

            Console.WriteLine("Opiskelijat aakkosjärjestyksessä;");
            foreach (Opiskelija item in OrderByFirstName)
            {
                Console.WriteLine(item.EtuNimi + " " + item.SukuNimi);
            }
            Console.WriteLine();
        }

        static void DeleteStudent(List<Opiskelija> opiskelijalista ,string etuNimi)
        {
            opiskelijalista.RemoveAll(x => x.EtuNimi == etuNimi);
        }
    }
}
