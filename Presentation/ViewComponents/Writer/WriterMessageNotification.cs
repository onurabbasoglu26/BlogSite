using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Dal());

        public IViewComponentResult Invoke()
        {
            int id = 4;
            var values = message2Manager.GetInboxListByWriter(id);
            return View(values);
        }
    }
}

