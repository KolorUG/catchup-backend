using System.Collections.Generic;
using CatchUp.DAL;
using CatchUp.Models.Offers;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class SubjectRepository : EfRepository<Subject> ,ISubjectRepository
    {
        public SubjectRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}