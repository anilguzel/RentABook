using RentABook.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentABook.Entity.Concrete;
using RentABook.DataAccess.Concrete.EntityFramework;
using RentABook.DataAccess.Abstract;

namespace RentABook.Business.Concrete.Managers
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public Book Add(Book book)
        {
            return _bookDal.Add(book);
        }

        public void Delete(int id)
        {
            _bookDal.Delete(new Book { Id = id });
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(x => x.Id == id);
        }

        public Book Update(Book book)
        {
            return _bookDal.Update(book);
        }
    }
}
