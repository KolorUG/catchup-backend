using CatchUp.Models.Lessons;
using Microsoft.EntityFrameworkCore;
using CatchUp.Models.Roles;

namespace CatchUp.DAL
{
    public class RolesContext : DbContext
    {
        DbSet<Address> Addresses {get; set; }
        DbSet<Graphic> Graphics {get; set ;}
        DbSet<Reward> Rewards {get; set ;}
        DbSet<Role> Role {get; set ;}
        DbSet<Student> Students {get; set ;}
        DbSet<Teacher> Teachers {get; set ;}
    }
}