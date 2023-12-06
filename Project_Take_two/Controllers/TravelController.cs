using Microsoft.AspNetCore.Mvc;
using Project_Take_two.Models;
using System.Diagnostics;
using Project_Take_two.Models;
namespace Project_Take_two.Controllers
{
    public class TravelController : Controller
    {

        private readonly ITravelService _travelService;
        public TravelController(ITravelService contactService)
        {
            _travelService = contactService;
        }
        static DateTime tempD1 = new DateTime(2022,10,10);
        static DateTime tempD2 = new DateTime(2022, 10, 15);
        static Travel tt = new Travel();
        
        
        
        public IActionResult Index()
        {
            if(_travelService.Count() == 0)
            {
                tt.Id = 0;
                tt.Name= "Egipt";
                tt.StartPlace = "Kraków";
                tt.EndPlace = "Warszawa";
                tt.StartDate = tempD1;
                tt.EndDate = tempD2;
                tt.Participants = "Kamil";
                tt.Guide = Guides.Grzegorz;
               // _travelService.Add(tt);
            }
            return View(_travelService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Travel model)
        {
            if(ModelState.IsValid)
            {
                _travelService.Add(model);
                return RedirectToAction("Index");
                
                //zapisz obiekt do bazy/kolekcji albo wykonaj operacje
            }
            return View();
        }
        public IActionResult Details(int id) {
            return View(_travelService.FindById(id));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_travelService.FindById(id));
        }
        [HttpPost]
        public IActionResult Delete(Travel model)
        {
            _travelService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            
                return View(_travelService.FindById(id));
        }
            

        
        [HttpPost]
        public IActionResult Update(Travel model)
        {
            _travelService.Update(model);

            return RedirectToAction("Index");
    }

        /*[HttpGet]
        public String Update(int? id)
        {
            return "Edycja " + id;
        }*/
    }
}
