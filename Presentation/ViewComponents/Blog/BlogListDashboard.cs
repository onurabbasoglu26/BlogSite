using System;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Blog
{
	public class BlogListDashboard : ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogDal());

		public IViewComponentResult Invoke()
		{
			var values = blogManager.GetBlogListWithCategory().OrderByDescending(x=>x.BlogId).Take(5).ToList();
			return View(values);
		}
	}
}

