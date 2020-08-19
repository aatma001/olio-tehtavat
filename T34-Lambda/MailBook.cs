using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;


namespace T34_Lambda
{
    class MailBook
    {
        private const string path = @"c:\temp\tutut.csv";
        private readonly List<Friend> friends;

        public List<Friend> Friends
        {
            get
            {
                return friends;
            }
        }

        public MailBook()
        {
            friends = ReadFromFile();
        }

        private List<Friend> ReadFromFile()
        {
            List<Friend> friendList = new List<Friend>();
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();
                    string name = fields[0];
                    string email = fields[1];
                    friendList.Add(new Friend(name, email));
                }
                return friendList;
            }
        }

        public string AddFriend(string name, string email)
        {
            try
            {

                if (File.Exists(path))
                {
                    using (StreamWriter w = File.AppendText(path))
                    {
                        w.WriteLine(name + ";" + email);
                        w.Close();
                    }
                }
                return "Ystävä lisätty";
                new Friend(name, email);

            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
        public List<Friend> FindFriend(string letters)
        {
            return friends.FindAll(s => s.Name.Contains(letters));
        }
    }
}

