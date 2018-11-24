using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CatchUp.Models.Lessons
{
    public class Lesson : BaseEntity
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }
       // public virtual Order Order { get; set; }
        //public virtual ICollection<Rating> Ratings { get; set; }
    }

    public class LessonMap : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> b)
        {
            
            b.HasKey(l => l.Id);
           // b.HasOne(l => l.Order).WithMany(o => o.Lessons);
            b.Property(l => l.Id).UseSqlServerIdentityColumn();
        }
    }
}
