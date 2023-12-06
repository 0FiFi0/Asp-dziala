using Labratorium1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Labratorium1.Controllers
{
    public class HomeController : Controller
    {
        public enum operators{
            ADD,SUB,MUL,DIV
        }
        private readonly ILogger<HomeController> _logger;

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
        public IActionResult About([FromQuery(Name ="app-author")]string author)
        {
            //string author=Request.Query["author"];
            ViewBag.Author = author;
            return View();
        }
        public IActionResult Calculator([FromQuery(Name ="operator")]operators? op, double? x, double? y)
        {
            if(x==null || y == null)
            {
                return View("ERROR");
            }
            double? result=0;
            switch (op)
            {
                case operators.ADD:
                    result = x + y;
                    break;

                case operators.SUB:
                    result = x - y;
                    break;

                case operators.MUL:
                    result = x * y;
                    break;

                case operators.DIV:
                    result = x / y;
                    break;

                default:
                    return View("ERROR");
                    
            }
            
            ViewBag.Result = result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}