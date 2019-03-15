using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
            User admin = new Reader("Hesham","01142428227","heshamrashwanali@gmail.com");
            admin.DisplayBooks();
        }
    }
}
