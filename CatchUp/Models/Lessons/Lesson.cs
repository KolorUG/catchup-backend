using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchUp.Models.Lessons
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }

    public class LessonMap : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> b)
        {
            b.HasKey(l => l.Id);
            b.Property(l => l.Id).UseSqlServerIdentityColumn();
            //b.Property(l => l.Id).ForSqlServerUseSequenceHiLo<int>("DbSequence").StartsAt(1).IncremetsBy(1);
            b.Property(l => l.OrderId);
            b.Property(l => l.Order).IsRequired();
            b.HasOne(l => l.Order);
        }
    }
}
