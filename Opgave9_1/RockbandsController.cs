using Microsoft.AspNetCore.Mvc;

namespace Opgave9_1
{
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {
            List<String> bands = new List<String> { "Beatles", "Bon Jovi", "Pink Floyd", };
            ViewBag.bands = bands;
            return View();
        }
    }
}
