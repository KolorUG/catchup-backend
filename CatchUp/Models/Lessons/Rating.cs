using System;
using CatchUp.Models.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Lessons
{
    public class Rating : BaseEntity
    {
        public virtual Lesson Lesson {get; set;}
        public virtual Role Role { get; set; }
        public short Rate { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }

    public class RatingMap : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> b)
        {
            b.HasKey(r => r.Id);
            b.HasOne(r => r.Lesson).WithMany(l => l.Ratings);
            b.HasOne(r => r.Role).WithMany(ro => ro.Ratings);
            b.Property(r => r.Rate).HasMaxLength(1).IsRequired();
            b.HasOne(r => r.Student).WithMany(s => s.Ratings);
            b.HasOne(r => r.Teacher).WithMany(t => t.Ratings);
        }
    }
}
