using System.Collections.Generic;
using CatchUp.Models.Lessons;

namespace CatchUp.Models.Roles
{
    public interface IUser
    {
         int AddressId {get; set;}
         string Name{get; set;}
         string Surname{get; set;}
         ICollection<Rating> Ratings {get; set;}
         ICollection<Order> Orders {get; set;}         
        
    }
}