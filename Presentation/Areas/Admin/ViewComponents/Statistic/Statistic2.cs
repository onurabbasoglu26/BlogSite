using System;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.ViewComponents.Statistic
{
	public class Statistic2 : ViewComponent
	{
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.BlogTitle).Take(1).FirstOrDefault();

            var blogid = c.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.WriterId).Take(1).FirstOrDefault();
            ViewBag.v2 = c.Writers.Where(x => x.WriterId == blogid).Select(x => x.WriterName).FirstOrDefault();
            return View();
        }
    }
}

