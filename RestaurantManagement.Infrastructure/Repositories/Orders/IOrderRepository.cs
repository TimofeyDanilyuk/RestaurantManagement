using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Domain.Enums;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.Orders
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetByStatusAsync(OrderStatus status);
        Task<Order?> GetWithItemsAsync(int orderId);
        Task<IEnumerable<Order>> GetByWaiterAsync(int waiterId);
    }
}
