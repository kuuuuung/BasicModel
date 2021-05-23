using BasicModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BasicModel.ViewModels;

namespace BasicModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //สร้างอ้อบเจ้ค Book ที่ชื่อ b โดยกำหนดข้อมูลของหนังสือ และส่งไปส่วนแสดงผลผ่านฟังก์ชัน View
            /* Book b = new Book();
             b.ISBN = "0001";
             b.Title = "การพัฒนา web app ";
             b.Price = 123;

             return View(b);*/

            BooksStore bs = new BooksStore();
            var bLists = bs.GetAllBooks();

            return View(bLists);

        }

        public IActionResult Details(String Id)
        {
            var model = new BooksStore();
            var ps = model.GetBookById(Id);

            if(ps == null)
            {
                return RedirectToAction("Index");
            }
            return View(ps);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
