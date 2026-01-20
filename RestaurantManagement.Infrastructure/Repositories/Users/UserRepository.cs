using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Domain.Enums;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.Users
{
    public class UserRepository
        : Repository<User>, IUserRepository
    {
        public UserRepository(RestaurantDbContext context)
            : base(context) { }

        public async Task<User?> GetByFullNameAsync(string firstName, string lastName)
        {
            return await dbSet
                .FirstOrDefaultAsync(u =>
                    u.FirstName == firstName &&
                    u.LastName == lastName);
        }

        public async Task<IEnumerable<User>> GetByRoleAsync(RoleType role)
        {
            return await dbSet
                .Where(u => u.Role == role)
                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetActiveAsync()
        {
            return await dbSet
                .Where(u => u.IsActive)
                .ToListAsync();
        }
    }
}
