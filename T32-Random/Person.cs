using System;
using System.Collections.Generic;
using System.Text;

namespace T32_Random
{
    class Person
    {
        public string EtuNimi { get; set; }
        public string SukuNimi { get; set; }        

        public Person(string etuNimi, string sukuNimi)
        {
            EtuNimi = etuNimi;
            SukuNimi = sukuNimi;
        }
        public string ToString()
        {
            return EtuNimi + " " + SukuNimi;
        }
    }
}
