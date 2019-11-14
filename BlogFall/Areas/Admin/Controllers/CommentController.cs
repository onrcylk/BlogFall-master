using BlogFall.Attributes;
using BlogFall.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogFall.Areas.Admin.Controllers
{
    public class CommentController : BaseController
    {
        // GET: Admin/Comment
        [Breadcrumb("Yorumlar")]
        public ActionResult Index()
        {
            return View(db.Comments.ToList());
        }
    }
}