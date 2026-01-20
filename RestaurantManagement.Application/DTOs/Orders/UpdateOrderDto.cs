using RestaurantManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.Orders
{
    public class UpdateOrderDto
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
