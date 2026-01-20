using RestaurantManagement.Application.DTOs.OrderItems;
using RestaurantManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.Orders
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int Table_ID { get; set; }
        public int Waiter_ID { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public List<OrderItemDto> Items { get; set; } = new();
    }
}
