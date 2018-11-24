using System.Collections.Generic;
using CatchUp.DAL;
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