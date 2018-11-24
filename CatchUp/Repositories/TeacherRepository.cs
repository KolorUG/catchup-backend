using System.Collections.Generic;
using CatchUp.DbContexts;
using CatchUp.Models.Roles;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class TeacherRepository : EfRepository<Teacher> ,ITeacherRepository
    {
        public TeacherRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}