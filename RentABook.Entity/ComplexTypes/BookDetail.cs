using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABook.Entity.ComplexTypes
{
    public class BookDetail
    {
        public virtual int BookId{ get; set; }
        public virtual string BookName { get; set; }
        public virtual string BookWriter { get; set; }
        public virtual int Stock { get; set; }

    }
}
