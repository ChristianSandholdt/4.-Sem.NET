using Microsoft.AspNetCore.Mvc;

namespace Opgave9_1
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View("TimeCalculator");
        }
        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            int hours = Int32.Parse(formCollection["Hours"]);
            int minutes = Int32.Parse(formCollection["Minutes"]);
            int seconds = Int32.Parse(formCollection["Seconds"]);
            ViewBag.Hours = hours;
            ViewBag.Minutes = minutes;
            ViewBag.Seconds = seconds;


            TimeSpan ts = new TimeSpan(0,hours, minutes, seconds);
            double total = ts.TotalSeconds;

            ViewBag.Total = total;
            return View("TimeCalculatorResult");
        }
    }
}
