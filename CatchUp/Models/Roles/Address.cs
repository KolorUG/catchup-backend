using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatchUp.Models.Roles
{
    public class Address
    {
        public int Id { get; set; }
        public String City { get; set; }
        public String PostalCode { get; set; }
        public String Street { get; set; }
        public String Number { get; set; }
        public String Flat { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> b)
        {
            //to do fluent api
        }
    }
}
