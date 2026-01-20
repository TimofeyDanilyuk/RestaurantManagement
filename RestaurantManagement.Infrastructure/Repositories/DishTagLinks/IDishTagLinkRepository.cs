using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.DishTagLinks
{
    public interface IDishTagLinkRepository : IRepository<DishTagLink>
    {
        Task<IEnumerable<DishTagLink>> GetByDishAsync(int dishId);
        Task<IEnumerable<DishTagLink>> GetByTagAsync(int tagId);
    }
}
