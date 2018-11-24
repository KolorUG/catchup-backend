using System;
using CatchUp.Models.Lessons;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Roles
{
    public class Student : BaseEntity, IUser
    {
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    
}
