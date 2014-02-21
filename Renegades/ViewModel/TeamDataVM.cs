using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renegades.Models;

namespace Renegades.ViewModel
{
    public class TeamDataVM
    {
 public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Coach> Coaches { get; set; } 
        public IEnumerable<News> Newses { get; set; } 
    }
}
