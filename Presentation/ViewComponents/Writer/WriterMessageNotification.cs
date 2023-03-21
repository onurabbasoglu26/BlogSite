using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IViewComponentResult Invoke()
        {
            string mail;
            mail = "deneme@gmail.com";
            var values = messageManager.GetInboxListByWriter(mail);
            return View(values);
        }
    }
}

