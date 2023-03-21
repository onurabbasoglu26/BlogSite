using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationDal());

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AllNotification()
        {
            var values = notificationManager.GetList();
            return View(values);
        }
    }
}