using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace T23_NewCD
{
    class CD
    {
        public string Album { get; set; }
        public string Artist { get; set; }
        public double TotalDuration { get; private set; }
        public List<Biisi> BiisiLista { get; set; }
        

        public CD(string album, string artist, List<Biisi> biisilista)
        {
            Album = album;
            Artist = artist;
            BiisiLista = biisilista;
        }

        public int GetCount()
        {
            return BiisiLista.Count;
        }

        public double CalculateLenght()
        {
            foreach (Biisi biisi in BiisiLista)
            {
                TotalDuration = TotalDuration + biisi.Duration;

            }
            return TotalDuration;
        }

        public string ToString()
        {
            return "Artist: " + Artist + " Album: " + Album;
        }


    }
}
