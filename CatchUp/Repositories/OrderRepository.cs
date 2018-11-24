using System.Collections.Generic;
using CatchUp.DAL;
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