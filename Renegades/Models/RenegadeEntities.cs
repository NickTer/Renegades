using System.Data.Entity;

namespace Renegades.Models
{
    public partial class RenegadeEntities : DbContext
    {
        public RenegadeEntities() : base("name=Renegades")
        {
            
        }

        public DbSet<TeamType> TeamTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<News> Newses { get; set; }
       
    }
}