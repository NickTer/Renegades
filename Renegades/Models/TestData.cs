using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Renegades.Models
{
    public class TestData : DropCreateDatabaseIfModelChanges<RenegadeEntities>
    {
        protected override void Seed(RenegadeEntities context)
        {

           
            getTeamTypes().ForEach(c => context.TeamTypes.Add(c));
            getTeams().ForEach(p => context.Teams.Add(p));
            getPlayers().ForEach(p => context.Players.Add(p));
            GetCoaches().ForEach(p => context.Coaches.Add(p));
            GetNewses().ForEach(p => context.Newses.Add(p));
        }

        private static List<TeamType> getTeamTypes()
        {
            var teamTypes = new List<TeamType>
            {
                new TeamType {TypeId = 1,TypeName = "18U"},
                new TeamType {TypeId = 2,TypeName = "16U"},
                new TeamType {TypeId = 3,TypeName = "14U"},
                new TeamType {TypeId = 4,TypeName = "12U"},
                new TeamType {TypeId = 5,TypeName = "10U"},
                new TeamType {TypeId = 6,TypeName = "8U"}
            };
            return teamTypes;
        }

        private static List<Team> getTeams()
        {
            var t = new List<Team>
            {
                new Team {TeamId = 1, TypeId = 1, TeamName = "18U - Gold"},
                new Team {TeamId = 2, TypeId = 1, TeamName = "18A"},
                new Team {TeamId = 3,TypeId = 2,TeamName = "16U - Gold"},
                new Team {TeamId = 4,TypeId = 2,TeamName = "16U - Black"},
                new Team {TeamId = 5,TypeId = 2,TeamName = "16U - Red"},
                new Team {TeamId = 6,TypeId = 2,TeamName = "16U - White"},
                    new Team {TeamId = 7,TypeId = 3,TeamName = "14U - Gold"},
                new Team {TeamId = 8,TypeId = 3,TeamName = "14U - Black"},
                new Team {TeamId = 9,TypeId = 3,TeamName = "14U - Red"},
                new Team {TeamId = 10,TypeId = 3,TeamName = "14U - White"},
                new Team {TeamId = 11,TypeId = 4,TeamName = "12U - Gold"},
                new Team {TeamId = 12,TypeId = 4,TeamName = "12U - Black"},
                new Team {TeamId = 13,TypeId = 4,TeamName = "12U - Red"},
                new Team {TeamId = 14,TypeId = 4,TeamName = "12U - White"},
                new Team {TeamId = 15,TypeId = 5,TeamName = "10U - Gold"},
                new Team {TeamId = 16,TypeId = 5,TeamName = "10U - Black"},
                new Team {TeamId = 17,TypeId = 5,TeamName = "10U - Red"},
                new Team {TeamId = 18,TypeId = 5,TeamName = "10U - White"},
                new Team {TeamId = 19,TypeId = 6,TeamName = "8U - Black"}
                
            };
            return t;
        }

        private static List<Player> getPlayers()
        {
            var p = new List<Player>
            {
                new Player{Fname="Bailey",LName = "Holt",PlayerId = 1,TeamId = 1,TeamNumber = "#00"},
                new Player{Fname="Morgan",LName = "Myers",PlayerId = 2,TeamId = 1,TeamNumber = "#28"},
                new Player{Fname="Breanna",LName = "Pingry",PlayerId = 3,TeamId = 1,TeamNumber = "#27"},
                new Player{Fname="Kelsey",LName = "Sterneker",PlayerId = 4,TeamId = 1,TeamNumber = "#11"},
                new Player{Fname="Taylor",LName = "Mannis",PlayerId = 5,TeamId = 1,TeamNumber = "#9"},
                new Player{Fname="Gabby",LName = "Sandoval",PlayerId = 6,TeamId = 1,TeamNumber = "#8"},
                new Player{Fname="Becca",LName = "Schulte",PlayerId = 7,TeamId = 1,TeamNumber = "#"},
                new Player{Fname="Morgan",LName = "Kirk",PlayerId = 8,TeamId = 1,TeamNumber = "#"},
                new Player{Fname="Brynn",LName = "Minor",PlayerId = 9,TeamId = 1,TeamNumber = "#"},
                new Player{Fname="Bradli",LName = "Nowak",PlayerId = 10,TeamId = 1,TeamNumber = "#"},
                new Player{Fname="Cassidy",LName = "Kelsheimer",PlayerId = 11,TeamId = 1,TeamNumber = "#12"},
                new Player{Fname="McJenzie",LName = "Young",PlayerId = 12,TeamId = 1,TeamNumber = "#22"}
                
            };
            return p;
        }

        public static List<Coach> GetCoaches()
        {
            var c = new List<Coach>
            {
                new Coach{CoachEmail = "steve@kansasrenegades.com",CoachId = 1,CoachName = "Steve Rorebeck",CoachType = "Head Coach",TeamId = 1},
                new Coach{CoachEmail = "kerry@kansasrenegades.com",CoachId = 2,CoachName = "Kerry Burns",CoachType = "Assistance Coach",TeamId = 1},
                new Coach{CoachEmail = "Kate@kansasrenegades.com",CoachId = 3,CoachName = "Kate James",CoachType = "Assistance Coach",TeamId = 1},
                new Coach{CoachEmail = "Ajk@kansasrenegades.com",CoachId = 4,CoachName = "Aj kirk",CoachType = "Assistance Coach",TeamId = 1}
            };
            return c;
        }

        public static List<News> GetNewses()
        {
            var n = new List<News>
            {
                new News{DefPhoto=0,Headder="18 Gold team at the 2012 NCAA Women's World Series",NewsId = 1,Photo="1.jpg",PublishDate = DateTime.Now,TeamId = 1,Text = "The 2012 summer Gold team took 2nd place in the Triple Crown event in Oklahoma City this past summer. They outscored their oponents 74-9 but lost 6-5 in the championship game. This event was held during the NCAA D1 college world series. There were 5 Renegades teams in this tournament and they all took time to attend the series while they were there."},
                new News{DefPhoto=0,Headder="2012 National Gold Qualifier",NewsId = 2,Photo="2.jpg",PublishDate = DateTime.Now.AddDays(-1),TeamId = 1,Text = "The Gold team had a 5th place finish in the 2012 National Gold Qualifier at Hall of Fame Stadium in OKC winning their first 3 games then loosing to the Oklahoma Diamond Girls and the KC Peppers and who took 1st and 2nd respectivly."},
                new News{DefPhoto=0,Headder="ASA 18 2012 Regional Gold Qualifier Runner-up",NewsId = 3,Photo="3.jpg",PublishDate = DateTime.Now.AddDays(-2),TeamId = 1,Text = "The Gold team finished as the runner at the ASA Gold regional qualifier. The girls won all the way through to the winner’s bracket final where they beat St Louis Esprit in 5 innings. The girls hit the ball hard all weekend and kept our pitching staff fresh. In the championship games the KC Peppers Engle, had to beat us twice. It was the Peppers afternoon. Our big bats went silent and the girls came up one win short of Gold nationals for the second straight year. "},
                 new News{DefPhoto=0,Headder="2012 ASA 18 Gold Division Champions, KC Memorial",NewsId = 4,Photo="4.jpg",PublishDate = DateTime.Now.AddDays(-3),TeamId = 1,Text = "After a 3rd place finish in 2011, the girls ran the table in bracket play and won the ASA Gold division championship in style beating Team Power 9-0 in the final. We pitched very well and hit the ball hard all weekend. Things really came together in bracket play with victories over the Tulsa Elite Gold, St Louis Fusion and the KC Zephers."},
                 new News{DefPhoto=0,Headder="2013 Top Gun Invitational - 18Gold team",NewsId = 5,Photo="5.jpg",PublishDate = DateTime.Now.AddDays(-4),TeamId = 1,Text = "The Gold team finished 3rd in the 2013 Top Gun Invitational. In bracket play they beat the Missouri Rattlers Gold and the KC Peppers Gold but lost to the Louisiana Redsticks Gold in the winner’s bracket final. The Peppers won their way back and although the girls held a 1 -0 lead going into the 5th inning the Peppers mounted a rally and won the game 3-1. Kelsey had a great day in the circle and Bailey had an outstanding weekend at the plate going 13 for 27 with 5 home runs and 12 RBI’s."},
                   new News{DefPhoto=0,Headder="Former Renegade Maddi Holub goes Pro!!",NewsId = 6,Photo="6.jpg",PublishDate = DateTime.Now.AddDays(-5),TeamId = 1,Text = "Former Renegade and Fort Hays State softball player Maddie Holub to play professional softball in Collecchio, Italy. Maddi earned 20 career awards including 1st team all American; 32 individual Ft Hayes records including: HR, career 46, total wins, lowest season ERA 1.03, and no hitters. Maddi was the first player in NCAA Division II history to throw perfect games in back-to-back starts. Maddi is one of the kindest, most unselfish players to ever play. Congrats Maddi we are proud of you. "}
            };
            return n;
        }

    }
}