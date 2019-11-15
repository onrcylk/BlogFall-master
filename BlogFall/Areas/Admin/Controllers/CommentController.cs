using BlogFall.Attributes;
using BlogFall.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogFall.Areas.Admin.Controllers
{
    [Breadcrumb("Yorumlar")]
    public class CommentController : AdminBaseController
    {
        // GET: Admin/Comment
        [Breadcrumb("İndeks")]
        public ActionResult Index()
        {
            return View(db.Comments.ToList());
        }
    }
}