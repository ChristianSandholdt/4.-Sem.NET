using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace StartUp_CORE.Controllers
{
    public class Exercise01Controller : Controller
    {


        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50, "grandcru.jpg", "Bilka");
            ViewBag.Glass = glass;

            Product knife = new Product("Knife", 50.50, "st_knife.jpg", "Lidl");
            ViewBag.Knife = knife;

            Product bin = new Product("Bin", 10.69, "bin_35l.jpg", "Ikea");
            ViewBag.Bin = bin;

            return View();
        }

    }
}
