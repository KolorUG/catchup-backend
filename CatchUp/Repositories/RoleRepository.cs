using System.Collections.Generic;
using CatchUp.DbContexts;
using CatchUp.Models.Roles;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class RoleRepository : EfRepository<Role> ,IRoleRepository
    {
        public RoleRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}