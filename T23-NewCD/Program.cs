using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace T23_NewCD
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Biisi> songList = new List<Biisi>();
            songList.Add(new Biisi("Juodaan kaljaa ", 3.53));
            songList.Add(new Biisi("Tippa tappaa ", 7.24));
            songList.Add(new Biisi("Juodaan kaljaa ", 2.33));
            songList.Add(new Biisi("Joulupukin muori ", 3.54));
            songList.Add(new Biisi("Master of puppets ", 6.54));
            songList.Add(new Biisi("Symphony of destruction ", 5.54));

            CD cd = new CD("Eino-papan parhaat", "Eikka", songList);

            var timeSpan = TimeSpan.FromMinutes(cd.CalculateLenght());
            int seconds = timeSpan.Seconds;
            int minutes = timeSpan.Minutes;

            Console.WriteLine(cd.ToString());
            Console.WriteLine("Total lenght: " + minutes + "min " + seconds + "sec");
            Console.WriteLine();
            Console.WriteLine(cd.GetCount() + " songs");


            Console.WriteLine(cd.ToString());
            foreach (var item in cd.BiisiLista)
            {
                Console.WriteLine(item.Name + item.Duration);
            }
        }
    }
}
