using Microsoft.AspNetCore.Mvc;

namespace Conversion.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult FirstPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FirstPage(Models.Conversion conversion)
        {
            if (ModelState.IsValid)
                return RedirectToAction("ConversionPage", conversion);
            return View();
        }
        public IActionResult ConversionPage(Models.Conversion conversion)
        {

            if (conversion.InitialMetric == "Celsius")
            {
                conversion.FinalMetric = "Fahrenheit";
                conversion.FinalValue = (conversion.InitialValue * 9/ 5) +32;
            }
            if (conversion.InitialMetric == "Fahrenheit")
            {
                conversion.FinalMetric = "Celsius";
                conversion.FinalValue = (conversion.InitialValue -32)*5/9;
            }
            return View(conversion);
        }
    }
}
