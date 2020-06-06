using System;
using System.Threading.Channels;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading;

namespace T8_Televisio
{
    class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television(10, 1, true);
            Console.WriteLine(television.CheckStatus());
            bool on = true;

            while (on)
            {
                Console.WriteLine("Change channel with 1. Adjust volume with 2. Turn off with 3");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        television.ChangeChannel(AskChannel());
                        Console.WriteLine(television.CheckStatus());
                        break;
                        

                    case 2:
                        television.ChangeVolume(AskVolume());
                        Console.WriteLine(television.CheckStatus());
                        break;
                        

                    case 3:
                        on = false;
                        television.IsOn = false;
                        break;
                }

            }
            Console.WriteLine(television.IsOnOff());
            Console.ReadKey();
        }

        static int AskChannel ()
        {
            Console.WriteLine("Set a new channel");
            int channel = int.Parse(Console.ReadLine());
            return channel;
        }
        static int AskVolume ()
        {
            Console.WriteLine("Set a new volume");
            int volume = int.Parse(Console.ReadLine());
            return volume;
        }
    }
}

