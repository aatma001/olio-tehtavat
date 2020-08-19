using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace T39_Kalat
{
    class KalaRekisteri
    {
        public List<Kalastaja> Kalastajat { get; set; }
        
        public KalaRekisteri(List<Kalastaja> kalastajat)
        {
            Kalastajat = kalastajat;
        }

        public string PrintFishes()
        {
            string kalat = "";
            foreach(Kalastaja item in Kalastajat)
            {
                kalat += "Kalastaja: " + item.Nimi + " nro: " + item.PuhelinNumero
                     + "\n" + "Kalat: \n";

                foreach(Kala kala in item.Kalat)
                {
                    kalat += kala.Laji + " " + kala.Pituus + "cm " + kala.Paino
                        + "kg\n" + "Paikka: " + kala.KalaPaikka.Paikka + " Sijainti: " + kala.KalaPaikka.Sijainti
                        + "\n\n";
                }
            }
            return kalat;
        }

        public List<Kala> SortFishes()
        {
            List<Kala> kalat = new List<Kala>();
            foreach(Kalastaja item in Kalastajat)
            {
                foreach (Kala kala in item.Kalat)
                {
                    kalat.Add(kala);
                }
            }
            var sortedList = kalat.OrderBy(a => a.Paino).ToList();
            sortedList.Reverse();
            return sortedList;
        }
    }
}
