using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order> orderList = StaticDb.Orders;
            return View(orderList);
        }
        [Route("Order/Details/{id?}")]
        public IActionResult Details(int? id)
        { 
            Order order = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            if(order == null)
            {
                return new EmptyResult();
            }
            if(id == null)
            {
                return new EmptyResult();
            }
            return View(order);
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
    }
}
