using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        [DataType(DataType.Password)]
        public string WriterPassword { get; set; }
        [DataType(DataType.Password)]
        [Compare("WriterPassword", ErrorMessage = "Şifreler eşleşmiyor. Lütfen tekrar deneyin!")]
        public string ConfirmPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}

