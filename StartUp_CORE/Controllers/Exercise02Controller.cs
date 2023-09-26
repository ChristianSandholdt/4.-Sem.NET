using Microsoft.AspNetCore.Mvc;
using StartUp_CORE.Models;

namespace StartUp_CORE.Controllers
{
    public class Exercise02Controller : Controller
    {
        public IActionResult Index()
        {
            Person p1 = new Person("Mike", "Tyson", "Sunshine blvd", "6900", "Los Angeles");
            Person p2 = new Person("Virgil", "Van Dijk", "Defence av.", "1234", "Liverpool");
            p1.addPhone("75482904");
            p2.addPhone("64726495");
            p2.addPhone("324763746");

            //Test af at fødselsdagen ikke kan være større end den nuværende dag
            //p1.Birthday = DateTime.Now.AddDays(1);

            ViewBag.P1 = p1;
            ViewBag.P2 = p2;
            var list = new List<Person> { p1,p2 };
            ViewBag.List = list;
            return View("Index");
        }
    }
}
