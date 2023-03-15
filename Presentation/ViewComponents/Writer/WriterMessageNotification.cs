using System;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

