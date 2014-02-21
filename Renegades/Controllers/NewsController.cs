using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Renegades.Controllers
{
    public class NewsController : MyAppController
    {
        //
        // GET: /News/

        public ActionResult Index(int? team_sort=0)
        {
            var ViewNews = from s in DataContext.Newses select s;
            if (team_sort != 0)
            {
                ViewNews = ViewNews.Where(m => m.TeamId == team_sort).OrderByDescending(m => m.PublishDate);
                ViewBag.currTeam = team_sort;
            }
            else
            {
                ViewBag.currTeam = team_sort;
            }
            
            return View(ViewNews);
        }

        public ActionResult NDeteils(int? newsId = null, int? teamid=0)
        {
            if (!newsId.HasValue)
            {
                return RedirectToAction("Index");

            }
            if (teamid != 0)
            {
                ViewBag.team_sort = teamid;
            }
            else
            {
                ViewBag.team_sort = 0;
            }
            var newslist = DataContext.Newses.Take(3).OrderByDescending(m => m.PublishDate);
            ViewBag.NewsDetail = DataContext.Newses.SingleOrDefault(n => n.NewsId == newsId);
            return View(newslist);
        }

    }
}
