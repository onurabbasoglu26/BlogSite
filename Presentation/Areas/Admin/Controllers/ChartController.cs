using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.Areas.Admin.Models;

namespace Presentation.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                CategoryName = "Teknoloji",
                CategoryCount = 10
            });

            list.Add(new CategoryClass
            {
                CategoryName = "Spor",
                CategoryCount = 15
            });

            list.Add(new CategoryClass
            {
                CategoryName = "Oyun",
                CategoryCount = 20
            });

            list.Add(new CategoryClass
            {
                CategoryName = "Dizi",
                CategoryCount = 21
            });

            list.Add(new CategoryClass
            {
                CategoryName = "Film",
                CategoryCount = 35
            });

            return Json(new { jsonlist = list });
        }
    }
}