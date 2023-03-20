using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Presentation.Models
{
    public class AddProfileImage
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterTitle { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

        public static string ImageAdd(IFormFile image)
        {
            var extension = Path.GetExtension(image.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/",
                newImageName);
            var stream = new FileStream(location, FileMode.Create);
            image.CopyTo(stream);
            return newImageName;
        }
    }
}

