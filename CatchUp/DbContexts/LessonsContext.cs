using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.DbContexts
{
    public class LessonsContext : DbContext
    {
        public LessonsContext(DbContextOptions<LessonsContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Lesson> Lessons{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Rating> Rating { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        //    builder.ApplyConfiguration(new LessonMap());
        //    builder.ApplyConfiguration(new OrderMap());
        //    builder.ApplyConfiguration(new RatingMap());
        }
    }
}
    