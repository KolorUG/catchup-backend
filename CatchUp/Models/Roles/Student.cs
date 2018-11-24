using System;
using CatchUp.Models.Lessons;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Roles
{
    public class Student : BaseEntity
    {
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> b)
        {
            b.HasKey(s => s.Id);
            b.Property(s => s.Name).HasColumnType("varchar").HasMaxLength(15).IsRequired();
            b.Property(s => s.Surname).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            b.HasOne(s => s.Address).WithOne(a => a.Student);
        }
    }

}
