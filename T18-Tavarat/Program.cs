using System;

namespace T18_Tavarat
{
    class Program
    {
        static void Main(string[] args)
        {
            Item book = new Book(2003, "Pahan Perimä", "WSOY", 30, "Jännitys", "Ilkka Remes");
            Console.WriteLine(book.ToString());
            Console.WriteLine("");
            Item book1 = new Book(2020, "Marjatan erikoiset", "Tammi", 50, "Ruoanlaittokirjat", "Marjatta Kauppinen");
            Console.WriteLine(book1.ToString());
            Console.WriteLine("");
            Item phone = new Electronics(2018, "Iphone", "Apple", 800, 50, true);
            Console.WriteLine(phone.ToString());
            Console.WriteLine("");
            Item walkman = new Electronics(2002, "Walkman", "Sony", 30, 10, false);
            Console.WriteLine(walkman.ToString());
        }
    }
}
