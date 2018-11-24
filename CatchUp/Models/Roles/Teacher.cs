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
        public int AddressId { get; set; }
        public virtual Address Address { get; set;}
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Description { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Schedule> Graphic { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> b)
        {
            //to do 
        }
    }
}
