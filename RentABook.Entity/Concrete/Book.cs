using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABook.Entity.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public int CategoryId { get; set; }
        public int Stok { get; set; }
        public Category Category { get; set; }
        public ICollection<Rent> Rents { get; set; }
    }
}
