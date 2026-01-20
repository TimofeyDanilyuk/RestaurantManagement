using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.OrderItems
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
        Task<IEnumerable<OrderItem>> GetByOrderAsync(int orderId);
    }
}
