using System;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

