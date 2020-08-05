using System;
using System.Collections.Generic;
using System.Text;

namespace T8_Televisio
{
    class Television
    {
        private int volume { get; set; }
        private int channel { get; set; }  

        public bool IsOn { get; set; }
        public Dictionary<int, string> Channels { get; set; }

        public int Volume
        {
            get { return volume; }
            set
            {
                if ((value > 0) && (value < 100))
                {
                    volume = value;
                }
            }
        }
        public int Channel
        {
            get { return channel; }
            set
            {
                if ((value > 0) && (value < 7))
                {
                    channel = value;
                }
            }
        }


        public Television(int volume, int channel, bool isOn)
        {
            Volume = volume;
            Channel = channel;
            IsOn = isOn;
        }

        public string IsOnOff()
        {
            if (IsOn)
            {
                return "Tv is On.";
            }
            else
            {
                return "Tv is Off.";
            }
        }

        public string CheckStatus()
        {
            return  IsOnOff() + " Channel: " + ShowChannels() +" Volume: " + Volume + "\n";
        }

        public string ShowChannels()
        {
            Dictionary<int, string> channels = new Dictionary<int, string>();
            channels.Add(1, "YLE1");
            channels.Add(2, "YLE2");
            channels.Add(3, "MTV3");
            channels.Add(4, "NELONEN");
            channels.Add(5, "YLEFEM");
            channels.Add(6, "SUBTV");

            if(channels.TryGetValue(Channel, out string ShowChannel))
            {
                return ShowChannel;
            }

            else
            {
                return "You dont have pay tv";
            }
            
        }







    }   

}
