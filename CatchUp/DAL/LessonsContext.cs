using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.DAL
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
    