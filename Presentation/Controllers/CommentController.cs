using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddComment(Comment comment)
        {
            comment.CommentStatus = true;
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.BlogId = 4;
            commentManager.TAdd(comment);
            return PartialView();
        }

        public PartialViewResult CommentLisByBlog(int id)
        {
            var values = commentManager.GetCommentList(id);
            return PartialView(values);
        }
    }
}