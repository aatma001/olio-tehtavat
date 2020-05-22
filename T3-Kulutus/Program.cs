using System;

namespace T3_Kulutus
{
    class Program
    {

        public const float kulutus = 7.5f;
        public const float bensanHinta = 1.55f;
        static void Main(string[] args)
        {
            float matka = 0;
            float hinta = 0;
            float määrä = 0;

            while (true)
            {
                Console.WriteLine("Anna matka kilometreinä");
                string strmatka = Console.ReadLine();
                if (Single.TryParse(strmatka, out matka))
                {
                    KulutusLaskuri(matka, ref hinta, ref määrä);
                    break;
                }
                else
                {
                    Console.WriteLine("Ei onnistu!\n");
                    continue;
                }
            }

            hinta = (float)Math.Round(hinta, 2);
            määrä = (float)Math.Round(määrä, 2);
            Console.WriteLine("bensaa kuluu {0} litraa ja se maksaa {1} euroa", määrä, hinta);
        }

        public static void KulutusLaskuri(float matka, ref float hinta, ref float käytettyBensa)
        {
            hinta = (kulutus * bensanHinta * matka) / 100;
            käytettyBensa = (kulutus * matka) / 100;
        }
    }
}
