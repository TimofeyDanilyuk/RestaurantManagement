using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.DishTagLinks
{
    public class DishTagLinkRepository
        : Repository<DishTagLink>, IDishTagLinkRepository
    {
        public DishTagLinkRepository(RestaurantDbContext context)
            : base(context) { }

        public async Task<IEnumerable<DishTagLink>> GetByDishAsync(int dishId)
        {
            return await dbSet
                .Where(l => l.Dish_ID == dishId)
                .ToListAsync();
        }

        public async Task<IEnumerable<DishTagLink>> GetByTagAsync(int tagId)
        {
            return await dbSet
                .Where(l => l.Tag_ID == tagId)
                .ToListAsync();
        }
    }
}
