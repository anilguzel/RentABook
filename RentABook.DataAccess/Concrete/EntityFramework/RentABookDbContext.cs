using RentABook.DataAccess.Concrete.EntityFramework.Mappings;
using RentABook.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABook.DataAccess.Concrete.EntityFramework
{
    public partial class RentABookDbContext:DbContext
    {
        public RentABookDbContext()
            :base("name=RentABookDbContext")
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new RentMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRolesMap());

            modelBuilder.Entity<Category>()
                .HasMany(x => x.Books)
                .WithRequired(x => x.Category)
                .WillCascadeOnDelete(false);
        }

    }
}
