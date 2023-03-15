using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Blog
{
	public class LastBlogsList : ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogDal());

		public IViewComponentResult Invoke()
		{
			var values = blogManager.GetLastBlogsList();
			return View(values);
		}
	}
}

