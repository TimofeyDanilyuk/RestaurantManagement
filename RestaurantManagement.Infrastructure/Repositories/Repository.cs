using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly RestaurantDbContext context;
        protected readonly DbSet<T> dbSet;

        public Repository(RestaurantDbContext context)
        {
            this.context = context;
            dbSet = this.context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await dbSet.ToListAsync();

        public async Task<T?> GetByIdAsync(int id) => await dbSet.FindAsync(id);

        public async Task AddAsync(T entity) => await dbSet.AddAsync(entity);

        public void Update(T entity) => dbSet.Update(entity);

        public void Remove(T entity) => dbSet.Remove(entity);
    }
}
