using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

		public IViewComponentResult Invoke()
		{
			var values = categoryManager.GetList();
			return View(values);
		}
	}
}

