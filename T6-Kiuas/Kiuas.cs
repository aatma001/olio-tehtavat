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
        public int temperature{ get; set; }
        public int moisture{ get; set; }
        public bool isOn { get; set; }

        public Kiuas (int _temperature, int _moisture, bool _isOn)
        {
            temperature = _temperature;
            moisture = _moisture;
            isOn = _isOn;
        }

        public string IsOnOff ()
        {
            if (isOn)
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
            return "Temperature: " + temperature.ToString() + " Moisture: " + moisture.ToString() + "\n";
        }

        public bool ChangeTemperature (int newTemperature)
        {
            if (newTemperature <= maxTemperature)
            {
                temperature = newTemperature;
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
                moisture = newMoisture;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

