using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order> ordersFromDb = StaticDb.Orders;

            List<OrderViewModel> orderViewModels =  ordersFromDb.Select(order=> order.ToOrderViewModelExtension()).ToList();

            ViewBag.NumberOfOrders = orderViewModels.Count;
            ViewBag.Date = DateTime.Now.ToShortDateString();
            ViewBag.FirstUser = StaticDb.Orders.First().User;
            return View(orderViewModels);
            
        }
        [Route("Order/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error","Pizza");
            }
            Order order = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            if(order == null)
            {
                return RedirectToAction("Error", "Pizza");
            }
             OrderDetailsViewModel orderDetailsViewModel = order.ToOrderDetailsViewModelExtension();
            return View(orderDetailsViewModel);
        }
        [Route("Order/Json")]
        public IActionResult Json()
        {
            List<Order> orders = StaticDb.Orders;
            return new JsonResult(orders);
        }
        [Route("RedirectToHome")]
        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index","Home");
        }
        public IActionResult Delete(int id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }
            Order order = StaticDb.Orders.FirstOrDefault(x=>x.Id == id);
            if( order == null)
            {
                return new EmptyResult();
            }
            OrderDetailsViewModel viewModel = order.ToOrderDetailsViewModelExtension();
            return View(viewModel);
        }
        public IActionResult ConfirmDelete(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Order order = StaticDb.Orders.FirstOrDefault(order => order.Id == id);

            if (order == null)
            {
                return new EmptyResult();
            }

            StaticDb.Orders.Remove(order);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateOrder()
        {
            OrderViewModel viewModel = new OrderViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreteOrderPost(OrderViewModel viewModel)
        {



            return RedirectToAction("Index");
        }
    }
}
