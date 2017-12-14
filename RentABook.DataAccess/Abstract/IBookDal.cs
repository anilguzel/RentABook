using Core.DataAccess;
using RentABook.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABook.DataAccess.Abstract
{
    public interface IBookDal:IEntityRepository<Book>
    {
    }
}
