using System;
using CatchUp.Models.Roles;
using CatchUp.Models.Offers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CatchUp.Models.Lessons
{
    public class Order : BaseEntity
    {
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public DateTime Date { get; set; }
        public virtual Offer Offer { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }

    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> b)
        {
            b.HasKey(o => o.Id);
            b.HasOne(o => o.Teacher).WithMany(t => t.Orders);
            b.HasOne(o => o.Student).WithMany(s => s.Orders);
            b.Property(o => o.Date).IsRequired();
            b.HasOne(o => o.Offer).WithMany(of => of.Orders);
            b.HasOne(o => o.Role).WithMany(r => r.Orders);
        }
    }
}
