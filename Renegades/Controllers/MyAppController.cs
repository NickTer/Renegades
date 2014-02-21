using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renegades.Models;

namespace Renegades.Controllers
{
    public abstract class MyAppController : Controller
    {
        //
        // GET: /MyApp/
        private RenegadeEntities db = new RenegadeEntities();

        public RenegadeEntities DataContext
        {
            get { return db; }
        }

        public MyAppController()
        {
            ViewBag.TeamList = db.TeamTypes.Include("Teams").ToList();
        }
    }
}
