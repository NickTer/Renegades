using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Renegades.Models
{
    public class Coach
    {
        public int CoachId   { get; set; }
        public int TeamId { get; set; }
        public string CoachName { get; set; }
        public string CoachType { get; set; }
        public string CoachEmail { get; set; }
        public virtual Team Team { get; set; }
    }
}