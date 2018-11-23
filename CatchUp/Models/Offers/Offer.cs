using System;
using System.Collections.Generic;

namespace CatchUp.Models.Offers
{
    public class Offer
    {
        public int Id { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public bool HomeVisits { get; set; }
        public float? VisitRange { get; set; }
    }
}
