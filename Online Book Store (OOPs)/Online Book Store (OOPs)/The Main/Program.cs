using Online_Book_Store__OOPs_.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store__OOPs_
{
    /*
    ❖ << A system for managing online shopping of books >>
    ❖ A user should have a username, a mail and a password.
    ❖ There are 2 types of users: Admin and reader.
    ❖ A reader should have: a phone number, an address and a payment method.
    ❖ A book should have a name, an author, a price and a category.
    ❖ System Functionalities:
        o Admin
            ▪ Add new book.
            ▪ Edit existing book.
            ▪ Delete book.
            ▪ Add new reader.
            ▪ Edit existing reader.
            ▪ Delete reader.
            ▪ Display all reader.
            ▪ Display all books.
        o Reader
            ▪ Edit his information.
            ▪ Search for a book and order it.
            ▪ Display all books.
    */
    class Program
    {
        static List<User_Object> users;
        static void Main(string[] args)
        {
            //User admin = new Reader("Hesham","01142428227","heshamrashwanali@gmail.com");
            //admin.DisplayBooks();

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "users.txt"))
            {
                File.Create(AppDomain.CurrentDomain.BaseDirectory + "users.txt");
            }
            users = new List<User_Object>();
            users = Parser.ReadUser_Objects();

            Console.WriteLine("Type L to list all users");
            Console.WriteLine("Type N to add a new User");

            string cmd = Console.ReadLine();
            if (cmd == "L")
            {
                ListUsers();
                Main(null);
            }
            if (cmd == "N")
            {
                CreateNewUser();
                Main(null);
            }
        }

        static void ListUsers()
        {
            users = new List<User_Object>();
            users = Parser.ReadUser_Objects();
            foreach (var item in users)
            {
                Console.WriteLine("\nUser:\n Username: " + item.Username + "\n Password: " + item.Password);
            }
        }
        static void CreateNewUser()
        {
            users = new List<User_Object>();
            users = Parser.ReadUser_Objects();
            Console.WriteLine("New username: ");
            string n_username = Console.ReadLine();

            Console.WriteLine("New password: ");
            string n_password = Console.ReadLine();
            User_Object u = new User_Object();
            u.Username = n_username;
            u.Password = n_password;
            users.Add(u);
            update();
            Parser.WriteUser_Objects();

        }
        static void update()
        {
            Parser.User_Objects = users;
        }
    }
}
