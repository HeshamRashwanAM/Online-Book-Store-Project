using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store__OOPs_
{
    interface IReader_Functionality<B>
    {
        void Edit();
        void Search(B Book);
    }
}