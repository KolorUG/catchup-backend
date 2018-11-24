using System;
using System.Collections.Generic;
using CatchUp.Models.Offers;
using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CatchUp.Models.Roles
{
    public class Teacher : BaseEntity
    {
        public virtual Address Address { get; set;}
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Description { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> b)
        {
            b.HasKey(t => t.Id);
            b.HasOne(t => t.Address).WithOne(a => a.Teacher);
        }
    }

}
