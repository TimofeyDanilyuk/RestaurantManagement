using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.DishCategories
{
    public interface IDishCategoryRepository : IRepository<DishCategory>
    {
        Task<IEnumerable<DishCategory>> GetActiveAsync();
        Task<IEnumerable<DishCategory>> GetByParentAsync(int? parentId);
    }
}
