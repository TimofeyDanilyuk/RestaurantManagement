using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Domain.Enums;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.Orders
{
    public class OrderRepository
        : Repository<Order>, IOrderRepository
    {
        public OrderRepository(RestaurantDbContext context)
            : base(context) { }

        public async Task<IEnumerable<Order>> GetByStatusAsync(OrderStatus status)
        {
            return await dbSet
                .Where(o => o.Status == status)
                .ToListAsync();
        }

        public async Task<Order?> GetWithItemsAsync(int orderId)
        {
            return await dbSet
                .Include(o => o.Items)
                .FirstOrDefaultAsync(o => o.ID == orderId);
        }

        public async Task<IEnumerable<Order>> GetByWaiterAsync(int waiterId)
        {
            return await dbSet
                .Where(o => o.Waiter_ID == waiterId)
                .ToListAsync();
        }
    }
}
