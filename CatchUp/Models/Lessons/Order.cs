using System;
using CatchUp.Models.Roles;
using CatchUp.Models.Offers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Lessons
{
    public class Order : BaseEntity
    {
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public DateTime Date { get; set; }
        public int OfferId { get; set; }
        public virtual Offer Offer { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }

    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> b)
        {
            //to do fluent api
        }
    }
}
