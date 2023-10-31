using Microsoft.AspNetCore.Mvc;
using Opgave13._1.Models;

namespace Opgave13._1.Controllers
{
    public class PersonController : Controller
    {
        [Route("{id}")]
        public IActionResult Findperson(int id)
        {
            ViewBag.Id = id;
            return View("Index");
        }

        //[Route("{fornavn}/{efternavn}")]
        public IActionResult Find(String fornavn, String efternavn) {
            ViewBag.Fornavn = fornavn;
            ViewBag.Efternavn = efternavn;
            return View("findPerson");        
        }

        [Route("Create")]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [Route("PersonCreated")]
        public IActionResult PersonCreatedCollection(IFormCollection formCollection)
        {
            string fornavn = formCollection["fornavn"];
            string efternavn = formCollection["efternavn"];
            string alder = formCollection["alder"];

            Person person = new Person();
            person.Alder = Int32.Parse(alder);
            person.Efternavn = efternavn;
            person.Navn = fornavn;

            ViewBag.Navn = fornavn;

            return View();
        }
    }
}
