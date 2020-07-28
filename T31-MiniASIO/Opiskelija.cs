using System;
using System.Collections.Generic;
using System.Text;

namespace T31_MiniASIO
{
    class Opiskelija
    {
        public string EtuNimi { get; set; }
        public string SukuNimi { get; set; }
        public string AsioId { get; set; }
        public string Ryhmä { get; set; }
        
        public Opiskelija(string etuNimi, string sukuNimi, string ryhmä)
        {
            EtuNimi = etuNimi;
            SukuNimi = sukuNimi;
            Ryhmä = ryhmä;
        }

        public Opiskelija(string etuNimi, string sukuNimi, string ryhmä, string asioId)
        {
            EtuNimi = etuNimi;
            SukuNimi = sukuNimi;
            Ryhmä = ryhmä;
            AsioId = asioId;
        }

        public void CreateAsioId(int number)
        {
            string asioNumber = "00";
            char firstLetter = EtuNimi[0];
            char secondLetter = SukuNimi[0];
            AsioId = firstLetter.ToString() + secondLetter.ToString() + asioNumber + number;

        }

    }   
}
