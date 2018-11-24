using System.Collections.Generic;
using CatchUp.DbContexts;
using CatchUp.Models.Lessons;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class OrderRepository : EfRepository<Order> ,IOrderRepository
    {
        public OrderRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}