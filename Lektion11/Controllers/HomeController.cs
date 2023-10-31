using Lektion11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Web;

namespace Lektion11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;

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
        private List<SelectListItem> CountriesList = new List<SelectListItem>();
        public IActionResult Countries(string Country)
        {
            CountriesList.Add(new SelectListItem { Text = "China", Value = "CN" });
            CountriesList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
            CountriesList.Add(new SelectListItem { Text = "United Kingdom", Value = "UK" });
            CountriesList.Add(new SelectListItem { Text = "United States of America", Value = "US" });
            CountriesList.Add(new SelectListItem { Text = "France", Value = "FR" });

            ViewBag.Countries = CountriesList;    
            ViewBag.CountryCode = Country;

           
            return View();
        }

        [HttpPost]
        public IActionResult Countries(IFormCollection formCollection)
        {
            string countryName = formCollection["CName"];
            string countryCode = formCollection["CCode"];

            if (countryName != null && countryCode != null)
            {
                SelectListItem c = new SelectListItem { Text = countryName, Value = countryCode };
                CountriesList.Add(new SelectListItem { Text = countryName, Value = countryCode});
                Countries(c.Text);
            }
            ViewBag.Countries = CountriesList;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}