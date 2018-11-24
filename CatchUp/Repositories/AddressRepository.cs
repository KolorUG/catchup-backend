using System.Collections.Generic;
using CatchUp.DAL;
using CatchUp.Models.Roles;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class AddressRepository : EfRepository<Address> ,IAddressRepository
    {
        public AddressRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}