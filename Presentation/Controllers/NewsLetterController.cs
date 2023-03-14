using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class NewsLetterController : Controller
    {
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            return PartialView();
        }
    }
}