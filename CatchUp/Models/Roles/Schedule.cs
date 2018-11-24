using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Roles
{
    public class Schedule : BaseEntity
    {
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int Day { get; set; }
        public String Begining { get; set; }
        public String Ending { get; set; }
    }

    public class GraphicMap : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> b)
        {
            //to do fluent api
        }
    }
}
