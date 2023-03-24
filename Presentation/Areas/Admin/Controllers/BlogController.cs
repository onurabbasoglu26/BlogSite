using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.Areas.Admin.Models;

namespace Presentation.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(2, 2).Value = "Blog Id";
                worksheet.Cell(2, 3).Value = "Blog Adı";

                int BlogRowCount = 3;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 2).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 3).Value = item.BlogName;
                    BlogRowCount++;
                }

                using(var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Document.xlsx");
                }
            }
        }

        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> blogModels = new List<BlogModel>
            {
                new BlogModel{Id=1, BlogName="C# Programlama"},
                new BlogModel{Id=2, BlogName="İzlenmesi Gereken Filmler"},
                new BlogModel{Id=3, BlogName="2023 Avrupa Futbol Şampiyona Elemeleri"}
            };
            return blogModels;
        }

        public IActionResult BlogListExcel()
        {
            return View();
        }
    }
}