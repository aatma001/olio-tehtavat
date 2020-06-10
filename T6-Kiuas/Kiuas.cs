using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Kiuas
{
    class Kiuas
    {
        private const int maxMoisture = 100;
        private const int maxTemperature = 120;
        public int Temperature{ get; set; }
        public int Moisture{ get; set; }
        public bool IsOn { get; set; }

        public Kiuas (int _temperature, int _moisture, bool _isOn)
        { 
            Temperature = _temperature;
            Moisture = _moisture;
            IsOn = _isOn;
        }

        public string IsOnOff ()
        {
            if (IsOn)
            {
                return "sauna is on.";
            }
            else
            {
                return "sauna is off";
            }
        }

        public string CheckStatus ()
        {
            return "Temperature: " + Temperature.ToString() + " Moisture: " + Moisture.ToString() + "\n";
        }

        public bool ChangeTemperature (int newTemperature)
        {
            if (newTemperature <= maxTemperature)
            {
                Temperature = newTemperature;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeMoisture (int newMoisture)
        {
            if (newMoisture <= maxMoisture)
            {
                Moisture = newMoisture;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

