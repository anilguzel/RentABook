﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace RentABook.Entity.Concrete
{
    public class UserRoles:IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }
    }
}
