using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using CatchUp.Models.Lessons;

namespace CatchUp.Models.Roles
{
    public class Role : BaseEntity
    {
        public String RoleType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> b)
        {
            b.HasKey(r => r.Id);
            b.Property(r => r.RoleType).HasColumnType("varchar").HasMaxLength(40).IsRequired();
        }
    }
}
