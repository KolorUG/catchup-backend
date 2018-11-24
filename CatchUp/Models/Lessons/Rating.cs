using System;
using CatchUp.Models.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Lessons
{
    public class Rating : BaseEntity
    {
        public int LessonId { get; set; }
        public virtual Lesson Lesson {get; set;}
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public short Rate { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }

    public class RatingMap : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> b)
        {
            // to do fluent api
        }
    }
}
