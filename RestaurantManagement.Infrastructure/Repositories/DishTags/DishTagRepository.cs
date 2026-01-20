using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.DishTags
{
    public class DishTagRepository
        : Repository<DishTag>, IDishTagRepository
    {
        public DishTagRepository(RestaurantDbContext context)
            : base(context) { }

        public async Task<IEnumerable<DishTag>> GetActiveAsync()
        {
            return await dbSet
                .Where(t => t.IsActive)
                .ToListAsync();
        }

        public async Task<DishTag?> GetWithDishesAsync(int tagId)
        {
            return await dbSet
                .Include(t => t.DishTagLinks)
                    .ThenInclude(l => l.Dish)
                .FirstOrDefaultAsync(t => t.ID == tagId);
        }
    }
}
