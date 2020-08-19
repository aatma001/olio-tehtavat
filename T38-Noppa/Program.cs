using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace T38_Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Noppa noppa = new Noppa(rand.Next(1, 7));
            Console.WriteLine("Dice, one test throw value is " + noppa.Value);

            Console.WriteLine("How many times you want to throw a dice");
            int howMany = int.Parse(Console.ReadLine());

            List<Noppa> nopat = ThrowDices(howMany);
            Console.WriteLine("Dice is now thrown " + howMany + " times");

            Console.WriteLine("Average is: " + CountAverage(nopat));
            Console.WriteLine("Count of different values:\n" + ShowValues(nopat));

        }
        static List<Noppa> ThrowDices(int howManyTimes)
        {
            List<Noppa> nopat = new List<Noppa>();
            Random rand = new Random();

            for (int i = 0; i <= howManyTimes; i++)
            {
                int random = rand.Next(1, 7);
                nopat.Add(new Noppa(random));
            }
            return nopat;
        }
        
        static double CountAverage(List<Noppa> nopat)
        {
            double total = 0;
            foreach(Noppa item in nopat)
            {
                total += item.Value;
            }
            return Math.Round(total / nopat.Count, 4);
        }
        static string ShowValues(List<Noppa> nopat)
        {
            
            int yksi = 0, kaksi = 0, kolme = 0, neljä = 0, viisi = 0, kuusi = 0;

            foreach(Noppa item in nopat)
            {
                switch (item.Value)
                {
                    case 1:
                        yksi++;
                        break;

                    case 2:
                        kaksi++;
                        break;
                    case 3:
                        kolme++;
                        break;
                    case 4:
                        neljä++;
                        break;
                    case 5:
                        viisi++;
                        break;
                    case 6:
                        kuusi++;
                        break;
                }
            }
            return "1: " + yksi + "\n2: " + kaksi + "\n3: " + kolme
                + "\n4: " + neljä + "\n5: " + viisi + "\n6; " + kuusi;
        }
    }
}
