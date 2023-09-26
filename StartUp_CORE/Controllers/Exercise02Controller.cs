using Microsoft.AspNetCore.Mvc;
using StartUp_CORE.Models;

namespace StartUp_CORE.Controllers
{
    public class Exercise02Controller : Controller
    {
        public IActionResult Index()
        {
            Person p1 = new Person("Mike", "Tyson", "Sunshine blvd", "6900", "Los Angeles", "69696969");
            Person p2 = new Person("Virgil", "Van Dijk", "Defence av.", "1234", "Liverpool", "86896598");
            ViewBag.P1 = p1;
            ViewBag.P2 = p2;
            return View();
        }
    }
}
