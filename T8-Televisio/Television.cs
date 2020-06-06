using System;
using System.Collections.Generic;
using System.Text;

namespace T8_Televisio
{
    class Television
    {
        public int Volume { get; set; }
        public int Channel { get; set; }  
        public string ShowChannel { get; set; }
        public bool IsOn { get; set; }
        public Dictionary<int, string> Channels { get; set; }
        private const int maxVolume = 99;
        private const int minVolume = 0;

        

        public Television(int _volume, int _channel, bool _isOn)
        {
            Volume = _volume;
            Channel = _channel;
            IsOn = _isOn;
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

        public bool ChangeChannel(int _channel)
        {
            
            Channel = _channel;
            return true;
        }

        public bool ChangeVolume(int _volume)
        {
            if(_volume <= maxVolume && _volume >= minVolume)
            {
                Volume = _volume;
                return true;
            }
            else
            {
                return false;
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
