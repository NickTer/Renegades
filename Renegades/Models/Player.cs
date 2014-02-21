using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renegades.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public string TeamNumber { get; set; }
        public virtual Team Team { get; set; }
        
    }
}