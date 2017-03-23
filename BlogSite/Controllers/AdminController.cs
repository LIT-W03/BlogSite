using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Data;

namespace BlogSite.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitPost(BlogPost post)
        {
            BlogDb db = new BlogDb(Properties.Settings.Default.ConStr);
            post.DateCreated = DateTime.Now;
            db.AddPost(post);
            return Redirect("/");
        }
    }
}