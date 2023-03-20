using System;
using System.IO;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

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

        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newImageName;
            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterPassword = BCrypt.Net.BCrypt.HashPassword(w.WriterPassword);
            w.WriterStatus = p.WriterStatus;
            w.WriterAbout = p.WriterAbout;
            writerManager.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}