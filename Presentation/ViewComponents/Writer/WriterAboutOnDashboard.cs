using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Writer
{
	public class WriterAboutOnDashboard : ViewComponent
	{
		WriterManager writerManager = new WriterManager(new EfWriterDal());

		public IViewComponentResult Invoke()
		{
			var values = writerManager.GetWriterById(1);
			return View(values);
		}
	}
}

