using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Denize_Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Somar(int a, int b)
        {
            ViewData["result"] = a+b;
            return View();
        }
        public IActionResult Subtrair(int a, int b)
        {
            ViewData["result"] = a - b;
            return View();
        }
        public IActionResult Dividir(int a, int b)
        {
            if(a > 0 && b > 0)
            {
                ViewData["result"] = a / b;
            }
            ViewData["result"] = 0;

            return View();
        }
        public IActionResult Multiplicar(int a, int b)
        {
            ViewData["result"] = a * b;
            return View();
        }
    }
}
