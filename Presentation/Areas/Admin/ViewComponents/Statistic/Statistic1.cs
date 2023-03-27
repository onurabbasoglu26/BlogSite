using System;
using System.Linq;
using System.Xml.Linq;
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
			string api = "08da66a00ed7266e9a81f4df9dc2b133";
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=eskisehir&mode=xml&lang=tr&units=metric&appid=" + api;
			XDocument document = XDocument.Load(connection);
			ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            ViewBag.v1 = blogManager.GetList().Count();
			ViewBag.v2 = c.Contacts.Count();
			ViewBag.v3 = c.Comments.Count();
			return View();
		}
	}
}

