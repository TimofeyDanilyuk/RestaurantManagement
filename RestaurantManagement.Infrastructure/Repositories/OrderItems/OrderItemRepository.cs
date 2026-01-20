using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.OrderItems
{
    public class OrderItemRepository
        : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(RestaurantDbContext context)
            : base(context) { }

        public async Task<IEnumerable<OrderItem>> GetByOrderAsync(int orderId)
        {
            return await dbSet
                .Where(i => i.Order_ID == orderId)
                .ToListAsync();
        }
    }
}
