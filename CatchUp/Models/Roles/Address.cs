using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Roles
{
    public class Address : BaseEntity
    {
        public String City { get; set; }
        public String PostalCode { get; set; }
        public String Street { get; set; }
        public String Number { get; set; }
        public String Flat { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
    }
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> b)
        {
            b.HasKey(a => a.Id);
            b.Property(a => a.City).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            b.Property(a => a.PostalCode).HasColumnType("varcahr").HasMaxLength(6).IsRequired();
            b.Property(a => a.Street).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            b.Property(a => a.Number).HasColumnType("varchar").HasMaxLength(10).IsRequired();
            b.Property(a => a.Flat).HasColumnType("varchar").HasMaxLength(10);
            b.Property(a => a.Latitude).HasColumnType("double").IsRequired();
            b.Property(a => a.Longitude).HasColumnType("double").IsRequired();
        }
    }
}
