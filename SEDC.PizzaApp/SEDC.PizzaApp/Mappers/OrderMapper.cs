﻿using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(Order order)
        {
            return new OrderViewModel()
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price + 50
            };
        }
        public static OrderViewModel ToOrderViewModelExtension(this Order order)
        {
            return new OrderViewModel()
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price + 50,
                Id = order.Id
            };
        }
        public static OrderDetailsViewModel ToOrderDetailsViewModelExtension(this Order order)
        {
            return new OrderDetailsViewModel()
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price + 50,
                UserAddress = order.User.Address,
                Id = order.Id,
                IsDelivered = order.Delivered
            };
        }
    }
}
    