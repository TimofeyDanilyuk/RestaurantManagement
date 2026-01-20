using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.OrderItems
{
    public class UpdateOrderItemDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
    }
}
