using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.Dishes
{
    public interface IDishRepository : IRepository<Dish>
    {
        Task<IEnumerable<Dish>> GetDishesByCategoryAsync(int categoryId);
        Task<IEnumerable<Dish>> GetAvailableDishesAsync();
        Task<Dish?> GetDishWithTagsAsync(int dishId);
        Task<IEnumerable<Dish>> GetDishesByTagsAsync(IEnumerable<int> tagIds);
    }

    public class DishRepository : Repository<Dish>, IDishRepository
    {
        public DishRepository(RestaurantDbContext context) : base(context) { }

        public async Task<IEnumerable<Dish>> GetAvailableDishesAsync()
        {
            return await dbSet.
                Where(d => d.IsAvailable)
                .ToListAsync();
        }

        public async Task<IEnumerable<Dish>> GetDishesByCategoryAsync(int categoryId)
        {
            return await dbSet
                .Where(d => d.Category_ID == categoryId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Dish>> GetDishesByTagsAsync(IEnumerable<int> tagIds)
        {
            return await dbSet
                .Include(d => d.DishTagLinks)
                    .ThenInclude(link => link.Tag)
                .Where(d => d.DishTagLinks.Any(link => tagIds.Contains(link.Tag_ID)))
                .ToListAsync();
        }

        public async Task<Dish?> GetDishWithTagsAsync(int dishId)
        {
            return await dbSet
                .Include(d => d.DishTagLinks)
                    .ThenInclude(link => link.Tag)
                .FirstOrDefaultAsync(d => d.ID == dishId);
        }
    }
}
