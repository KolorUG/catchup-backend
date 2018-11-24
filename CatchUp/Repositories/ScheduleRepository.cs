using System.Collections.Generic;
using CatchUp.DbContexts;
using CatchUp.Models.Roles;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class ScheduleRepository : EfRepository<Schedule> ,IScheduleRepository
    {
        public ScheduleRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}