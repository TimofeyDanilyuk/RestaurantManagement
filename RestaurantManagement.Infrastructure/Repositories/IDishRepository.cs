using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories
{
    public interface IDishRepository : IRepository<Dish>
    {
        Task<IEnumerable<Dish>> GetDishesByCategoryAsync(int categoryId);
    }

    public class DishRepository : Repository<Dish>, IDishRepository
    {
        public DishRepository(RestaurantDbContext context) : base(context) { }

        public async Task<IEnumerable<Dish>> GetDishesByCategoryAsync(int categoryId)
        {
            return await dbSet
                .Where(d => d.Category_ID == categoryId)
                .ToListAsync();
        }
    }
}
