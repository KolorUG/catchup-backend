using System.Collections.Generic;
using CatchUp.DAL;
using CatchUp.Models.Lessons;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class LessonRepository : EfRepository<Lesson> ,ILessonRepository
    {
        public LessonRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}