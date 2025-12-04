
using Microsoft.AspNetCore.Mvc;
using projectqa.Models;



   namespace projectqa.Controllers
{
        public class CalculatorController : Controller
        {
            private readonly Calculator _calculator = new Calculator();

            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Calculate(double a, double b, string operation)
            {
                double result = operation switch
                {
                    "Add" => _calculator.Add(a, b),
                    "Subtract" => _calculator.Subtract(a, b),
                    "Multiply" => _calculator.Multiply(a, b),
                    "Divide" => _calculator.Divide(a, b),
                    _ => 0
                };

                ViewBag.Result = result;
                return View("Index");
            }
        }
    }


