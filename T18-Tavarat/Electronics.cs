using System;
using System.Collections.Generic;
using System.Text;

namespace T18_Tavarat
{
    class Electronics : Item
    {
        public int Power { get; set; }
        public bool IsWorking { get; set; }

        public Electronics(int publishYear, string name, string publisher, int price, int power, bool isWorking)
            : base(publishYear, name, publisher, price)
        {
            Power = power;
            IsWorking = isWorking;
        }

        public string CheckIfBroken()
        {
            if (IsWorking)
            {
                return "Working";
            }
            else
            {
                return "broken";
            }
        }

        public override string ToString()
        {
            return "Electronic device\n" + base.ToString() + "Power: " + Power + "W" 
                + "\n" + CheckIfBroken() + "\n" + IsValuable();
        }


    }
}
