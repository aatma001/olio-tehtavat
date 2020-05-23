using System;
using System.Linq;

namespace T4_Palindromi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna merkkijono");
            string merkkijono = Console.ReadLine();
            string merkkijonoLowerCase = merkkijono.ToLower();
            char[] testattava = merkkijonoLowerCase.ToCharArray();
            char[] käännetty = stringKääntäjä(merkkijonoLowerCase);

            if (käännetty.SequenceEqual(testattava))
            {
                Console.WriteLine(merkkijono + " on palindromi");
            }
            else
            {
                Console.WriteLine(merkkijono + " ei ole palindromi, sana väärinpäin on " + new string(käännetty));
            }
        }
        static char[] stringKääntäjä(string merkkijono)
        {
            char[] käännettävä = merkkijono.ToCharArray();
            Array.Reverse(käännettävä);
            return käännettävä;
        }
    }

}


