using System;

namespace T1_Koulunumero
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Paljon tuli pisteitä (0-11)?");
                string strpisteet = Console.ReadLine();
                int pisteet;

                if (Int32.TryParse(strpisteet, out pisteet))
                {
                    switch (pisteet)
                    {
                        case 0:
                        case 1:
                            Console.WriteLine("Sait numeron 0");
                            break;

                        case 2:
                        case 3:
                            Console.WriteLine("Sait numeron 1");
                            break;

                        case 4:
                        case 5:
                            Console.WriteLine("Sait numeron 2");
                            break;

                        case 6:
                        case 7:
                            Console.WriteLine("Sait numeron 3");
                            break;

                        case 8:
                        case 9:
                            Console.WriteLine("Sait numeron 4");
                            break;

                        case 10:
                        case 11:
                            Console.WriteLine("Sait numeron 5");
                            break;

                        default:
                            Console.WriteLine("11 pistettä oli jaossa\n");
                            continue;
                    }
                    break;  // breakkaa ulos while loopista kun oikea pistemäärä löytyy            
                }

                else
                {
                    Console.WriteLine(strpisteet + " ei ole numero\n");
                    continue;
                }
            }
        }

    }
}