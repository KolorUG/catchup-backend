using System.Collections.Generic;
using CatchUp.DbContexts;
using CatchUp.Models.Offers;
using CatchUp.ReposInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CatchUp.Repositories
{
    public class OfferRepository : EfRepository<Offer> ,IOfferRepository
    {
        public OfferRepository(RolesContext dbContext) : base(dbContext)
        {
        }
    }
}