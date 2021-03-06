using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;
using CatchUp.Models.Offers;

namespace CatchUp.DAL
{
    public class OffersContext : DbContext
    {
        public OffersContext(DbContextOptions<OffersContext> options)
            :base(options)
        {

        }

        public DbSet<Offer> Offers {get; set; }
        public DbSet<Subject> Subjects {get; set; }
        public DbSet<Level> Levels { get; set; }
    }
}