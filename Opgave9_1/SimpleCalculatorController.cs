using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Opgave9_1
{
    public class SimpleCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View("SimpleCalculator");
        }
        [HttpPost]
        public IActionResult Index(IFormCollection formcollection)
        {
            int number1 = Int32.Parse(formcollection["number1"]);
            int number2 = Int32.Parse(formcollection["number2"]);
            double result = 0;
            string operatorSymbol = formcollection["operator"];
            if (number1 != null && number2 != null)
            {
                if (operatorSymbol == "/")
                {
                    if (number1 == 0 || number2 == 0)
                    {
                        ViewBag.result = "Division by zero";
                        return View("SimpleCalculator");
                    }
                    else
                    {
                        result = number1 / number2;
                    }
                } else if (operatorSymbol == "*") {
                    result = number1 * number2;
                } else if (operatorSymbol == "-")
                {
                    result = number1 - number2;
                } else
                {
                    result = number1 + number2; 
                }
            }
            ViewBag.result = result.ToString();
            return View("SimpleCalculator");
        }
    }
}
