using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaViewModel()
            {
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price,
            };
        }
        public static PizzaDetailsViewModel PizzaToPizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel()
            {
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price,
            };
        }
    }
}
