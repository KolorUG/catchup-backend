using System.Collections.Generic;
using CatchUp.DAL;
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