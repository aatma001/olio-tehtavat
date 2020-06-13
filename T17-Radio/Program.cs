using System;

namespace T17_Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Radio radio = new Radio();
            Console.WriteLine(radio.ToString());

            Console.WriteLine("Turn radio on with pressing any key");
            Console.ReadKey();
            radio.IsOn = true;
            Console.WriteLine(radio.IsOnOff());
            Console.WriteLine(radio.ToString());
 
            while (radio.IsOn)
            { 
                Console.WriteLine("Adjust volume with 1, frequency with 2 and turn off with 3");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        radio.Volume = AskNewVolume();
                        Console.WriteLine(radio.ToString());
                        break;

                    case 2:
                        radio.Frequency = AskNewFrequency();
                        Console.WriteLine(radio.ToString());
                        break;

                    case 3:
                        radio.IsOn = false;
                        Console.WriteLine(radio.ToString());
                        break;
                }
            }
            
        }

        static int AskNewVolume()
        {
            Console.WriteLine("Give a value between (0-9)");
            return int.Parse(Console.ReadLine());
        }

        static double AskNewFrequency()
        {
            Console.WriteLine("Give a value between (2000,0-2600,0)");
            return double.Parse(Console.ReadLine());
        }

        
        

    }
}
