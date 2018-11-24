using System;
using System.Collections.Generic;
using CatchUp.Models.Lessons;

namespace CatchUp.Models.Offers
{
    public class Offer : BaseEntity
    {
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Order> Orders { get; set; } 
        public bool HomeVisits { get; set; }
        public float? VisitRange { get; set; }
    }
}
