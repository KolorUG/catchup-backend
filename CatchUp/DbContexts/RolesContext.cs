using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;
using CatchUp.Models.Roles;

namespace CatchUp.DbContexts
{
    public class RolesContext : DbContext
    {
        public RolesContext(DbContextOptions<RolesContext> options)
            :base(options)
        {
            
        }
        DbSet<Address> Addresses {get; set; }
        DbSet<Schedule> Schedule {get; set ;}
        DbSet<Role> Role {get; set ;}
        DbSet<Student> Students {get; set ;}
        DbSet<Teacher> Teachers {get; set ;}
        DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new AddressMap());
            //builder.ApplyConfiguration(new RoleMap());
            //builder.ApplyConfiguration(new ScheduleMap());
            //builder.ApplyConfiguration(new TeacherMap());
            //builder.ApplyConfiguration(new StudentMap());
        }
    }
}