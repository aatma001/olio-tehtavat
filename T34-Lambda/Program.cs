using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace T34_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            MailBook mailBook = new MailBook();
            ShowFriends(mailBook.Friends);

            Console.WriteLine("Anna haettavan tutun nimi tai sen osa\n");
            string nimi = Console.ReadLine();
            ShowFoundFriends(mailBook.FindFriend(nimi));

        }

        static void ShowFriends(List<Friend> friends)
        {
            Console.WriteLine("Osoitekirjassa " + friends.Count + " nimeä:");
            foreach (Friend item in friends)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void ShowFoundFriends(List<Friend> foundFriends)
        {
            if (foundFriends.Count >= 1)
            {
                Console.WriteLine("Löydettiin:");
                foreach (Friend item in foundFriends)
                {
                    Console.WriteLine(item.Name + " " + item.Email);
                }
            }
            else
            {
                Console.WriteLine("Eipä löytyny");
            }
        }
    }
}
