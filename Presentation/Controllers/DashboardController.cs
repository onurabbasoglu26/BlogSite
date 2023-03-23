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
    public class DashboardController : Controller
    {
        readonly BlogManager blogManager = new BlogManager(new EfBlogDal());
        readonly CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            ViewBag.Statistic1 = blogManager.GetList().Count();
            ViewBag.Statistic2 = blogManager.GetList().Where(x => x.WriterId == 1).Count();
            ViewBag.Statistic3 = categoryManager.GetList().Count();
            return View();
        }
    }
}