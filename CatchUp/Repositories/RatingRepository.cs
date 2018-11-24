using System.Collections.Generic;
using CatchUp.DAL;
using CatchUp.Models.Lessons;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class RatingRepository : EfRepository<Rating> ,IRatingRepository
    {
        public RatingRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}