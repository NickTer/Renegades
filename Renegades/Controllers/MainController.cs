    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renegades.Models;

namespace Renegades.Controllers
{
    public class MainController : MyAppController
    {
        //
        // GET: /Main/
        public RenegadeEntities db = new RenegadeEntities();

        public ActionResult Index()
        {

            var NewsView = db.Newses.Take(3).OrderByDescending(n=>n.PublishDate).ToList();
            return View(NewsView);
        }
        [HttpGet]
        public ActionResult ContactUs()
        {
            
            return View(new ContactMessage());
        }
        [HttpPost]
        public ActionResult ContactUs(ContactMessage post)
        {
            
            if ( ModelState.IsValid)
            {
                post.MessageDate = DateTime.Now;
               db.ContactMessages.Add(post);

               db.SaveChanges();


                TempData["SuccessMes"] = post;
                return RedirectToAction("SuccessMessage");
            }
            return View(post);
        }

        public ActionResult SuccessMessage()
        {
            if (!TempData.ContainsKey("SuccessMes"))
            {
                return RedirectToAction("ContactUs");
            }
            else
            {
                var message = (ContactMessage)TempData["SuccessMes"];

                
                return View("ContactUs", message);    
            }
            
            
            
        }
        

    }
}
