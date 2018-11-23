using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Roles
{
    public class Graphic
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int Day { get; set; }
        public String Begining { get; set; }
        public String Ending { get; set; }
    }

    public class GraphicMap : IEntityTypeConfiguration<Graphic>
    {
        public void Configure(EntityTypeBuilder<Graphic> b)
        {
            //to do fluent api
        }
    }
}
