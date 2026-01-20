using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.Tables
{
    public class TableRepository
        : Repository<Table>, ITableRepository
    {
        public TableRepository(RestaurantDbContext context)
            : base(context) { }

        public async Task<Table?> GetByNumberAsync(int number)
        {
            return await dbSet
                .FirstOrDefaultAsync(t => t.Number == number);
        }
    }
}
