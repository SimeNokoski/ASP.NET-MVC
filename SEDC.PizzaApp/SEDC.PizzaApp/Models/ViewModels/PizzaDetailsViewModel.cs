using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class PizzaDetailsViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public PizzaSize PizzaSize { get; set; }
    }
}
