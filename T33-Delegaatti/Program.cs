using System;
using System.Globalization;

namespace T33_Delegaatti
{
    class Program
    {
        delegate void FormatString(string s);
        static void Main(string[] args)
        {

            Console.WriteLine("Anna sana");
            string word = Console.ReadLine();

            bool repeat = true;
            while (repeat)
            {
                FormatString format = null;

                Console.WriteLine("Käsitellään sanaa: " + word);
                Console.WriteLine("Valitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla"
                                + " yhtenä merkkijonona esim '123'");

                Console.WriteLine("1: isoiksi kirjaimiksi\n" + "2: pieniksi kirjaimiksi\n" +
                                "3: otsikoksi\n" + "4: palindromiksi\n" + "0: lopetus");

                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i])
                    {
                        case '1':
                             format += ChangeUpper;
                            break;
                            
                        case '2':
                            format += ChangeLower;
                            break;

                        case '3':
                            format += ChangeTitleCase;
                            break;

                        case '4':
                            format += ChangeBackWards;
                            break;

                        case '0':
                            Console.WriteLine("Lopetetaan");
                            repeat = false;
                            break;
                    }
                }
                if(format != null)
                {
                    format(word);
                    Console.WriteLine();
                }
            }  
        }

        static void ChangeUpper(string word)
        {
            Console.WriteLine(word + " Muutettu: " + word.ToUpper());
        }
        
        static void ChangeLower(string word)
        {
            Console.WriteLine(word + " Muutettu: " + word.ToLower());
        }

        static void ChangeTitleCase(string word)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine(word + " Muutettu: "  + myTI.ToTitleCase(word));
        }

        static void ChangeBackWards(string word)
        {
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(word + " Muutettu: "  + new string(array));
        }
    }
}
