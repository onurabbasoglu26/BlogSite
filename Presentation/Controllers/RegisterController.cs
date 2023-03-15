using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer, string confirmPassword)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult results = validationRules.Validate(writer);

            if (results.IsValid)
            {
                if (writer.WriterPassword == confirmPassword)
                {
                    writer.WriterStatus = true;
                    writer.WriterAbout = "Deneme";
                    writer.WriterPassword = BCrypt.Net.BCrypt.HashPassword(writer.WriterPassword);
                    writerManager.TAdd(writer);
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    ModelState.AddModelError("WriterPassword", "Girdiğiniz şifreler eşleşmedi. Lütfen tekrar deneyiniz...");
                }
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}