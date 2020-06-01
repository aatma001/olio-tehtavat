using System;

namespace T6_Kiuas
{
    class Program
    {

        static void Main(string[] args)
        {
            bool on = true;
            Console.WriteLine("Set temperature of the sauna");
            int temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("Set moisture of the sauna");
            int moisture = int.Parse(Console.ReadLine());

            Kiuas kiuas = new Kiuas(temperature, moisture);
            kiuas.TurnOn();
            kiuas.CheckStatus();


            while (on)
            {
                Console.WriteLine("Adjust temperature with 1, moisture with 2, and turn the sauna off with 3");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        kiuas.ChangeTemperature();
                        kiuas.CheckStatus();
                        break;

                    case 2:
                        kiuas.ChangeMoisture();
                        kiuas.CheckStatus();
                        break;

                    case 3:
                        kiuas.TurnOff();
                        on = false;
                        break;
                } 
            }
        }   
    }
}
