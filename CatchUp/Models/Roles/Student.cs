using System;
using CatchUp.Models.Lessons;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Roles
{
    public class Student
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> b)
        {
            
        }
    }
}
