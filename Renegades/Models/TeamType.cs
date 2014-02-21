using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renegades.Models
{
    public class TeamType
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        
        public virtual ICollection<Team> Teams { get; set; } 
    }
}