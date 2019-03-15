using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store__OOPs_
{
    interface IAdmin_Functionality<R, B>
    {
        void Add(R Reader);
        void Edit(R Reader);
        void Delete(R Reader);
        void Add(B Book);
        void Edit(B Book);
        void Delete(B Book);
        void DisplayReaders();
    }
}
