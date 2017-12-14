using RentABook.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABook.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RentMap:EntityTypeConfiguration<Rent>
    {
        public RentMap()
        {
            ToTable(@"Rent", @"dbo");

            Property(x => x.BookId).HasColumnName("BookId");
            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.ReceiptTime).HasColumnName("ReceiptTime");
            Property(x => x.DeliveryTime).HasColumnName("DeliveryTime");
            Property(x => x.IsOk).HasColumnName("IsOk");



        }
    }
}
