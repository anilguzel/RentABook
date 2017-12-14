using RentABook.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABook.DataAccess.Concrete.EntityFramework.Mappings
{
    public class BookMap:EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable(@"Book", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Stok).HasColumnName("Stok");
            Property(x => x.Writer).HasColumnName("Writer");
            Property(x => x.CategoryId).HasColumnName("CategoryId");

        }
    }
}
