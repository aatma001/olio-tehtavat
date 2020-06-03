using System;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;

namespace T6_Kiuas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            bool on = true;
            bool ison = true;

            Kiuas kiuas = new Kiuas(AskTemperature(), AskMoisture(), true);
            kiuas.IsOnOff();
            Console.WriteLine(kiuas.CheckStatus());

            while (on)
            {
                Console.WriteLine("Adjust temperature with 1, moisture with 2, and turn the sauna off with 3");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        while (true)
                        {
                            if (kiuas.ChangeTemperature(AskTemperature()))
                            {
                                Console.WriteLine("Temperature changed");
                                Console.WriteLine(kiuas.CheckStatus());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Too hot or too cold");
                                continue;
                            }
                        }
                        break;

                    case 2:
                        while (true)
                        {
                            if (kiuas.ChangeMoisture(AskMoisture()))
                            {
                                Console.WriteLine("Moisture changed");
                                Console.WriteLine(kiuas.CheckStatus());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Give value between 0-100");
                                continue;
                            }
                        }
                        break;

                    case 3:
                        on = false;
                        kiuas.isOn = false;
                        break;

                    default:
                        Console.WriteLine("Give value between 1-3");
                        break;  
                }
            }
            Console.WriteLine(kiuas.IsOnOff());
        }

                static int AskTemperature ()
            {
                Console.WriteLine("Set temperature of the sauna");
                int temperature = int.Parse(Console.ReadLine());
                return temperature;
            }
            static int AskMoisture ()
            {
                Console.WriteLine("Set moisture of the sauna");
                int moisture = int.Parse(Console.ReadLine());
                return moisture;
            }
    }
}


