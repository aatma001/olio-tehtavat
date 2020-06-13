using System;
using System.Collections.Generic;
using System.Text;

namespace T17_Radio
{
    class Radio : Sähkölaite
    {
        const int maxVolume = 9;
        const int minVolume = 0;
        const double maxFrequency = 2600.0;
        const double minFrequency = 2000.0;

        private double frequency;
        private int volume;

       
        public double Frequency
        {
            get { return frequency; }
            set
            {
                if ((value > minFrequency) && (value < maxFrequency))
                {
                    frequency = value;
                }
            }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                if ((value > minVolume) && (value < maxVolume))
                {
                    volume = value;
                }
            }
        }

        public Radio()
            
        {
            volume = 0;
            frequency = 2000.0;
        }

        public string ToString()
        {
            if (IsOn)
            {
                return "Frequency: " + Frequency + " Volume: " + volume + " power: " + Power
                    + "w"  + "\n";
            }
            else
            {
                return IsOnOff();
            }
        }

       

    }
}
