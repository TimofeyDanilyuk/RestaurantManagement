using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Application.DTOs.Orders
{
    public class CreateOrderDto
    {
        public int Table_ID { get; set; }
        public int Waiter_ID { get; set; }
    }
}
