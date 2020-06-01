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
        const int maxTemperature = 120;
        const int maxMoisture = 100;
        public bool isOn;
        private int temperature;
        private int moisture;
        private int newTemperature;
        private int newMoisture;
        public Kiuas(int _temperature, int _moisture)
        {
            temperature = _temperature;
            moisture = _moisture;
        }
         public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Sauna is on.");

        }
        public void TurnOff()
        {
            Console.WriteLine("Sauna is off");
            isOn = false;
        }

        public void ChangeTemperature()
        {
            while (true)
            {
                Console.WriteLine("Give new temperature");
                newTemperature = int.Parse(Console.ReadLine());
                if (newTemperature <= maxTemperature)
                {
                    Console.WriteLine("Temperature changed.\n");
                    temperature = newTemperature;
                    break;
                }
                else
                {
                    Console.WriteLine("Give value between 0-120");
                    continue;
                }
            }
        }
        public void ChangeMoisture()
        {
            while (true)
            {
                Console.WriteLine("Give new moisture");
                newMoisture = int.Parse(Console.ReadLine());
                if (newMoisture <= maxMoisture)
                {
                    Console.WriteLine("Moisture changed\n");
                    moisture = newMoisture;
                    break;
                }
                else
                {
                    Console.WriteLine("give value between 0-100");
                    continue;
                }
            }
        }
        public void CheckStatus()
        {
            Console.WriteLine("Temperature: {0} Moisture: {1}", temperature, moisture);
        }
    }
}

