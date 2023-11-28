using BusinessLayer.BLL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using MVCGUI.Models;
using System.Diagnostics;

namespace MVCGUI.Controllers
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
            StuderendeBLL bll = new StuderendeBLL();
            Studerende studerende = bll.findStuderende(1);
            return View(new IndexModel(studerende.Navn));
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