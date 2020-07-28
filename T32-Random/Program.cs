using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace T32_Random
{
    class Program
    {

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static Random random = new Random();

        static void Main(string[] args)
        {
            List <Person> personList = new List<Person>();

            var startListTimer = Stopwatch.StartNew();

            for (int i = 0; i < 10000; i++)
            {
                personList.Add(new Person(RandomEtuNimi(), RandomSukuNimi()));
            }
            startListTimer.Stop();

            Console.WriteLine("List Collection");
            Console.WriteLine("Adding time: " + startListTimer.ElapsedMilliseconds);
            Console.WriteLine("Persons count: " + personList.Count);
            
            var startFindPersonList = Stopwatch.StartNew();
            FindPersonFromList(personList); ;
            startFindPersonList.Stop();

            Console.WriteLine("Find time: " + startFindPersonList.ElapsedMilliseconds + "\n");

            Dictionary<string, Person> personDictionary = new Dictionary<string, Person>();

            var startDictTimer = Stopwatch.StartNew();

            for (int i = 0; i < 10000; i++)
            {
                string etuNimi = RandomEtuNimi();

                if (!personDictionary.ContainsKey(etuNimi))
                {
                    personDictionary.Add(etuNimi, new Person(etuNimi, RandomSukuNimi()));
                }
                else
                {
                    i--;
                }
            }
         
            startDictTimer.Stop();

            Console.WriteLine("Dictionary");
            Console.WriteLine("Adding time: " + startDictTimer.ElapsedMilliseconds);
            Console.WriteLine("Persons count: " + personDictionary.Count);

            var startFindPersonDict = Stopwatch.StartNew();
            FindPersonFromDictionary(personDictionary);
            startFindPersonDict.Stop();
            Console.WriteLine("Find Time " + startFindPersonDict.ElapsedMilliseconds);
        }

        public static string RandomEtuNimi()
        {
            return new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomSukuNimi()
        {
            return new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void FindPersonFromList(List<Person> personlist)
        {
            int match = 0;

            for (int i = 0; i < 1000; i++) 
            {
                string name = RandomEtuNimi();
                foreach (Person item in personlist)
                {
                    if (name == item.EtuNimi)
                    {
                        Console.WriteLine("Found person: " + name + " " +  item.ToString());
                    }
                }    
            }
            Console.WriteLine("tried to find 1000 persons");
        }

        public static void FindPersonFromDictionary(Dictionary<string, Person>persondictionary)
        {
            for(int i = 0; i < 1000; i++)
            {
                string name = RandomEtuNimi();

                if(persondictionary.TryGetValue(name, out  Person value)) 
                {
                    Console.WriteLine("Found person: " + name + " "
                        + value.ToString());    
                }
            }
            Console.WriteLine("tried to find 1000 persons");
        }
    }
}
