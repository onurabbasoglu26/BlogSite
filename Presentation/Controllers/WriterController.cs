using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());

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

        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var values = writerManager.GetByTId(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer, string confirmPassword)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult validationResult = validationRules.Validate(writer);
            if (validationResult.IsValid)
            {
                if (writer.WriterPassword == confirmPassword)
                {
                    writer.WriterStatus = true;
                    writer.WriterPassword = BCrypt.Net.BCrypt.HashPassword(writer.WriterPassword);
                    writerManager.TUpdate(writer);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("WriterPassword", "Girdiğiniz şifreler eşleşmedi. Lütfen tekrar deneyiniz...");
                }
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}