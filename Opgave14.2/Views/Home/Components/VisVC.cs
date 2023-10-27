using Microsoft.AspNetCore.Mvc;
using Opgave14._2.Models;

namespace Opgave14._2.Views.Home.Components
{
    public class VisVC : ViewComponent
    {
        public IViewComponentResult Invoke(Person p)
        {
            string temp = p.Firstname;
            p.Firstname = p.Lastname;
            p.Lastname = temp;
            return View(p);
        }
    }
}
