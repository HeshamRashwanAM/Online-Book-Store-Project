using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Online_Book_Store__OOPs_
{
    class Admin : User, IAdmin_Functionality<Reader, Book>
    {
        public Admin(string Usernam, string Password, string Mail):base(Usernam, Password, Mail){}
        public void Add(Book Book)
        {

        }
        public void Edit(Book Book){}
        public void Delete(Book Book){}
        public void Add(Reader Reader){}
        public void Edit(Reader Reader){}
        public void Delete(Reader Reader){}
        public void DisplayReaders(){}
    }
}
