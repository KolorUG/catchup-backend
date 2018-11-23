using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Models
{
    public class CatchUpDbContext : DbContext
    {
        public CatchUpDbContext(DbContextOptions<CatchUpDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            // to do add fluent api's
        }

    }
}
