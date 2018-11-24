using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CatchUp.Models.Roles
{
    public class Schedule : BaseEntity
    {
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        //public virtual Teacher Teacher { get; set; }
        public int Day { get; set; }
        [MinLength(5),MaxLength(5)]
        public String Begining { get; set; }
        [MinLength(5), MaxLength(5)]
        public String Ending { get; set; }
    }

    public class ScheduleMap : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> b)
        {
            b.HasKey(s => s.Id);
            b.Property(s => s.Day).HasColumnType("int").HasMaxLength(1).IsRequired();
            b.Property(s => s.Begining).IsRequired();
            b.Property(s => s.Ending).IsRequired();
        }
    }
}
