using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.DishTags
{
    public interface IDishTagRepository : IRepository<DishTag>
    {
        Task<IEnumerable<DishTag>> GetActiveAsync();
        Task<DishTag?> GetWithDishesAsync(int tagId);
    }
}
