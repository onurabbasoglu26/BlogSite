using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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

        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentLisByBlog(int id)
        {
            var values = commentManager.GetCommentList(id);
            return PartialView(values);
        }
    }
}