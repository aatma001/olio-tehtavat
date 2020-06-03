using System;
using System.Linq;

namespace T4_Palindromi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna merkkijono");
            string merkkijonoLowerCase = Console.ReadLine().ToLower();
            char[] testattava = merkkijonoLowerCase.ToCharArray();
            char[] käännetty = KäännäString(merkkijonoLowerCase);

            if (käännetty.SequenceEqual(testattava))
            {
                Console.WriteLine(merkkijonoLowerCase + " on palindromi");
            }
            else
            {
                Console.WriteLine(merkkijonoLowerCase + " ei ole palindromi, sana väärinpäin on " + new string(käännetty));
            }
        }
        static char[] KäännäString (string merkkijono)
        {
            char[] käännettävä = merkkijono.ToCharArray();
            Array.Reverse(käännettävä);
            return käännettävä;
        }
    }

}


