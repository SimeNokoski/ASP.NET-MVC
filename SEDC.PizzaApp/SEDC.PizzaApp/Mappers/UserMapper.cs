using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class UserMapper
    {
        public static UserFullName UserName(this User user)
        {
            return new UserFullName()
            {
                FullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
