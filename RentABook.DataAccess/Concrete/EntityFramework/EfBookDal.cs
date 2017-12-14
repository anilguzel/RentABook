using RentABook.DataAccess.Abstract;
using RentABook.Entity.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentABook.Entity.ComplexTypes;

namespace RentABook.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal:EfEntityRepositoryBase<Book,RentABookDbContext>,IBookDal
    {
        public List<BookDetail> GetBookDetails()
        {
            using (RentABookDbContext context =new RentABookDbContext())
            {
                var result = from b in context.Book
                             join c in context.Category on b.CategoryId equals c.Id
                             select new BookDetail
                             {
                                 BookId = b.Id,
                                 BookName = b.Name,
                                 BookWriter = b.Writer,
                                 Stock = b.Stok
                             };
                return result.ToList();
            }
        }
    }
}
