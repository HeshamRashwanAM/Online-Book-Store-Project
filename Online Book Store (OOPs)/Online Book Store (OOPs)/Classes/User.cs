using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Online_Book_Store__OOPs_
{
    abstract class User
    {
        private string UserName;
        private string Mail;
        private string Password;
        private static List<Book> Books;
        private static List<Reader> Readers;
        private static List<Admin> Admins;
        private static FileStream File;
        private static StreamReader Reading;
        private static StreamWriter Writeing;
        // Begin Constructors
        static User()
        {
            Admins = new List<Admin>();
            Readers = new List<Reader>();
            Books = new List<Book>();
            File = new FileStream("Admins.txt" , FileMode.Open);
            Reading = new StreamReader(File);
            while(Reading.Peek() != -1)
            {
                string[] record = Reading.ReadLine().Split('|');
                Admins.Add(new Admin(record[0], record[1], record[2]));
            }
            Reading.Close();
            File.Close();


            File = new FileStream("Readers.txt", FileMode.Open);
            Reading = new StreamReader(File);
            while (Reading.Peek() != -1)
            {
                string[] record = Reading.ReadLine().Split('|');
                Readers.Add(new Reader(record[0], record[1], record[2], record[3], record[4]));
            }
            Reading.Close();
            File.Close();


            File = new FileStream("Books.txt", FileMode.Open);
            Reading = new StreamReader(File);
            while (Reading.Peek() != -1)
            {
                string[] record = Reading.ReadLine().Split('|');
                Books.Add(new Book(record[0], record[1], Convert.ToDouble(record[2]), record[3]));
            }
            Reading.Close();
            File.Close();
        }
        public User(string Username, string Password, string Mail)
        {
            this.UserName = Username;
            this.Password = Password;
            this.Mail = Mail;
        }
        // End Constructors
        public void DisplayBooks()
        {
            for(int i = 0; i < Books.Count(); i++)
            {
                Console.WriteLine(
                    "Name : {0}\tAuthor : {1}\tPrice : {2}\tCategory : {3}"
                    ,Books[i].GetName(), Books[i].GetAuthor(), Books[i].GetPrice(), Books[i].GetCategory());
                Console.WriteLine("---------------------------------------------------------");
            }
        }
        ~User()
        {
            Console.WriteLine("destr");
        }
    }
}