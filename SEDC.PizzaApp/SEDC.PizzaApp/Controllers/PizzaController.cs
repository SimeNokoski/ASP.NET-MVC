using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetPizzas() 
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaViewModels = pizzas.Select(x => x.PizzaToPizzaViewModel()).ToList();
            ViewBag.TotalPizzas = pizzaViewModels.Count;
            return View(pizzaViewModels);
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Details(int? id) 
        { 
            if(id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if(pizza == null)
            {
                return RedirectToAction("Error");
            }
            PizzaDetailsViewModel pizzaDetailsViewModel = pizza.PizzaToPizzaDetailsViewModel();
            return View(pizzaDetailsViewModel);
        }
     
    }
}
