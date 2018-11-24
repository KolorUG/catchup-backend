using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Offers
{
    public class Subject : BaseEntity
    {
        public virtual SubjectType SubjectType { get; set; }
        public virtual Level Level { get; set; }
        public decimal Price { get; set; }
        public int LessonMinutes {get; set; }
    }

    public class SubjectMap : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> b)
        {
            //to do fluent api
        }
    }

    public class SubjectType : BaseEntity
    {
        public String SubjectName { get; set; }
    }

    public class SubjectTypeMap : IEntityTypeConfiguration<SubjectType>
    {
        public void Configure(EntityTypeBuilder<SubjectType> b)
        {
            //to do fluent api
        }
    }

    public class Level : BaseEntity
    {
        public String LevelName { get; set; }
    }

    public class LevelMap : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> b)
        {
            //to do fluent api
        }
    }
}
