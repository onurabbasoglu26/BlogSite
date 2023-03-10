using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
    }
}

