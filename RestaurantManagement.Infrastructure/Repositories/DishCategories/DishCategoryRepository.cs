using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.DishCategories
{
    public class DishCategoryRepository
        : Repository<DishCategory>, IDishCategoryRepository
    {
        public DishCategoryRepository(RestaurantDbContext context)
            : base(context) { }

        public async Task<IEnumerable<DishCategory>> GetActiveAsync()
        {
            return await dbSet
                .Where(c => c.IsActive)
                .ToListAsync();
        }

        public async Task<IEnumerable<DishCategory>> GetByParentAsync(int? parentId)
        {
            return await dbSet
                .Where(c => c.ParentCategory_ID == parentId)
                .ToListAsync();
        }
    }
}
