
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Renegades.Models;
using Renegades.ViewModel;


namespace Renegades.Controllers
{
    public class TeamController : MyAppController
    {
        //
        // GET: /Team/
       
        public RenegadeEntities db = new RenegadeEntities();

        public ActionResult Index()
        {

            var viewTeams = db.TeamTypes.Include("Teams.Coaches").Include("Teams.Players").ToList();//db.TeamTypes.SqlQuery("SELECT tt.*,t.*,COuNT(*) as  FROM dbo.TeamTypes as tt LEFT JOIN dbo.Teams as t WHERE TypeId!=0").ToList();
            return View(viewTeams);
        }

        public ActionResult ShTeam(int? teamid = null)
        {
            if (!teamid.HasValue)
            {
                return RedirectToAction("Index");

            }
           
            try
            {
                var viewModel = new TeamDataVM
                {
                    Coaches = db.Coaches.Where(c => c.TeamId == teamid),
                    Players = db.Players.Where(p => p.TeamId == teamid),
                    Newses = db.Newses.Where(n => n.TeamId==teamid).Take(3).OrderByDescending(n =>n.PublishDate)
                };
            ViewBag.TeamId = teamid;
            ViewBag.TitleTeam = DataContext.Teams.SingleOrDefault(t => t.TeamId==teamid).TeamName;
            return View(viewModel);
            
            }
            catch (NullReferenceException)
            {

                return new HttpNotFoundResult();
            }
           
            
        }

        public ActionResult Player(int teamid, int playerid)
        {
            ViewBag.TeamId = teamid;
            ViewBag.Player = db.Players.SingleOrDefault(p => p.PlayerId == playerid && p.TeamId == teamid);
            
            return View();
        }

    }
}
