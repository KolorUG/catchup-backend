using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;
using CatchUp.Models.Roles;

namespace CatchUp.DAL
{
    public class RolesContext : DbContext
    {
        public RolesContext(DbContextOptions<RolesContext> options)
            :base(options)
        {
            
        }
        DbSet<Address> Addresses {get; set; }
<<<<<<< HEAD:CatchUp/DAL/RolesContext.cs
        DbSet<Schedule> Schedule {get; set ;}
=======
        DbSet<Schedule> Graphics {get; set ;}
>>>>>>> 4e90fceffda79f7622c4e6bbc82bf097e25450c6:CatchUp/DbContexts/RolesContext.cs
        DbSet<Role> Role {get; set ;}
        DbSet<Student> Students {get; set ;}
        DbSet<Teacher> Teachers {get; set ;}
    }
}