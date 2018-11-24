using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Lesson> Lessons{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Rating> Rating { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
    