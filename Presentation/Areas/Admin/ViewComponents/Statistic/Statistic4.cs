using System;
using System.Linq;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.ViewComponents.Statistic
{
	public class Statistic4:ViewComponent
	{
		Context c = new Context();

		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = c.Admins.Where(x => x.AdminId == 1).Select(y => y.Name).FirstOrDefault();
			ViewBag.v2 = c.Admins.Where(x => x.AdminId == 1).Select(y => y.ImageURL).FirstOrDefault();
			ViewBag.v2 = c.Admins.Where(x => x.AdminId == 1).Select(y => y.Description).FirstOrDefault();
			return View();
		}
	}
}

