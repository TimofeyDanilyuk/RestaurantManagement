using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.OrderItems
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public int Dish_ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
