using Microsoft.AspNetCore.Mvc;

namespace Opgave9_1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string navn = "Nehtin";
            int alder = 69;
            DateTime birthday = new DateTime(2069,04,20);
            //ViewBag.Person = (navn, alder, birthday);

            ViewBag.navn = navn;
            ViewBag.birthday = birthday;
            ViewBag.alder = alder;
            return View();
        }
    }
}
