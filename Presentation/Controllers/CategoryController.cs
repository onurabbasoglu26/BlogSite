using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
    }
}

