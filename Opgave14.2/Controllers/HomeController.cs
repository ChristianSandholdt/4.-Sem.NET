using Microsoft.AspNetCore.Mvc;
using Opgave14._2.Models;
using System.Diagnostics;

namespace Opgave14._2.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult VisAlle() 
        {
            return View("Personer",HentPersoner());
        }

        private List<Person> HentPersoner()
        {
            List<Person> personer = new List<Person>();
            Person p1 = new Person("Lewis", "Hamilton", 36);
            Person p2 = new Person("Daniel", "Riccardo", 35);
            Person p3 = new Person("Yuki", "Tsunoda", 27);
            Person p4 = new Person("Kevin", "Magnussen", 30);
            Person p5 = new Person("Max", "Verstappen", 25);
            personer.Add(p1);
            personer.Add(p2);
            personer.Add(p3);
            personer.Add(p4);
            personer.Add(p5);
            return personer;
        }

        public IActionResult VisEn()
        {
            return View("VisEnPerson",HentPersoner().ElementAt(3));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}