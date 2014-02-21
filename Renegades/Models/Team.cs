using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renegades.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; } 
        public int TypeId { get; set; }
        public string TeamName { get; set; }
        public virtual TeamType Type { get; set; }
        public ICollection<Player> Players { get; set; } 
        public ICollection<Coach> Coaches { get; set; }
        public ICollection<News> Newses { get; set; } 
    }
}