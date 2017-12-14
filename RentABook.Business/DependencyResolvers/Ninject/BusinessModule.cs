using RentABook.Business.Abstract;
using RentABook.Business.Concrete.Managers;
using RentABook.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABook.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<EfBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<DbContext>().To<RentABookDbContext>();
        }
    }
}
