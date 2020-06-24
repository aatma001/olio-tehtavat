using System;
using System.Collections.Generic;
using System.Text;

namespace T23_NewCD
{
    public class Biisi
    {
        public string Name { get; set; }
        public double Duration { get; set; }

        public Biisi(string name, double duration)
        {
            Name = name;
            Duration = duration;
        }
    }
}
