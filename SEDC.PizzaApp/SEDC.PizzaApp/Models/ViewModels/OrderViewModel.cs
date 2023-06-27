using SEDC.PizzaApp.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza Name")]
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }
        public decimal Price { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string UserAddress { get; set; }
        public bool IsDelivered { get; set; }
    }
}
