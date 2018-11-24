using System;
using System.Collections.Generic;

namespace CatchUp.Models.Offers
{
    public class Offer : BaseEntity
    {
        public ICollection<Subject> Subjects { get; set; }
        public bool HomeVisits { get; set; }
        public float? VisitRange { get; set; }
    }
}
