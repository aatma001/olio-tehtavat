using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace T18_Tavarat
{
    class Item
    {
        public int PublishYear { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set;}

        public Item()
        {

        }

        public Item(int publishYear, string name, string publisher, int price)
        {
            PublishYear = publishYear;
            Name = name;
            Publisher = publisher;
            Price = price;
        }

        public string IsValuable()
        {
            if(Price > 80)
            {
                return "Item is quite valuable";
            }
            else
            {
                return "Item is quite cheap";
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Publisher: " + Publisher
                + "\n" + "Published: " + PublishYear + "\n";
        }

    }
}
