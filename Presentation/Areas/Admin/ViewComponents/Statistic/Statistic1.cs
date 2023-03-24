using System;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.ViewComponents.Statistic
{
	public class Statistic1:ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogDal());
		Context c = new Context();

		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = blogManager.GetList().Count();
			ViewBag.v2 = c.Contacts.Count();
			ViewBag.v3 = c.Comments.Count();
			return View();
		}
	}
}

