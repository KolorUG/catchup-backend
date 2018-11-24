using System.Collections.Generic;
using CatchUp.DbContexts;
using CatchUp.Models.Roles;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class StudentRepository : EfRepository<Student> ,IStudentRepository
    {
        public StudentRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}