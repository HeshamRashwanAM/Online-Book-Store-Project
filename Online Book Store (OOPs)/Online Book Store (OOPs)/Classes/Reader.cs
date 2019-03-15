using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store__OOPs_
{
    class Reader : User , IReader_Functionality<Book>
    {
        private string PhoneNumber;
        private string Address;
        private string PaymentMethod;
        // Begin Constructors
        #region
        public Reader(string Username, string Password, string Mail) : base(Username, Password, Mail)
        {
        }
        public Reader(string Username, string Password, string Mail, string PhoneNumber) : base(Username, Password, Mail)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public Reader(string Username, string Password, string Mail, string PhoneNumber, string Address) : base(Username, Password, Mail)
        {
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }
        public Reader(string Username, string Password, string Mail, string PhoneNumber , string Address, string PaymentMethod):base(Username, Password, Mail)
        {
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.PaymentMethod = PaymentMethod;
        }
        #endregion
        // End Constructors
        public void Edit(){}
        public void Search(Book Book){}
    }
}
