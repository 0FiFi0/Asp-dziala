using Microsoft.AspNetCore.Mvc;
using System.Reflection;

/*
 *  1.Wysłanie żądania do formularze (potrzebna akcja w kontrolerze do formularza)
 *  2.wypełnienie formularza i submit 
 *  3.wysłanie żądania z danymi formularza (potrzebna akcja odbierjąca dane)
 *  4.obliczenie i zwrócenie widoku z wynikami
 */
namespace Laboratorium2.Controllers
{
    public enum operators
    {
        ADD, SUB, MUL, DIV
    }
    public class CalkulatorController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Result1([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
