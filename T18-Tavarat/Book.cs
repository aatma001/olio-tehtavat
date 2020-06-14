using System;
using System.Collections.Generic;
using System.Text;

namespace T18_Tavarat
{
    class Book : Item
    {

        public string Genre { get; set; }
        public string Writer { get; set; }

        public Book(int publishYear, string name, string publisher, int price, string genre, string writer)
            :base(publishYear, name, publisher, price)
                    
        {
            Genre = genre;
            Writer = writer;
        }

        public override string ToString()
        {
            return "Book \n" + base.ToString() + Genre + "\n" + Writer + "\n" + IsValuable();
        }

    }
}
