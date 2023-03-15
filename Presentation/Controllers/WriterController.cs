using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialWriterSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialWriterNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialWriterFooter()
        {
            return PartialView();
        }
    }
}