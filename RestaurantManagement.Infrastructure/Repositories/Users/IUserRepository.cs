using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Domain.Enums;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.Users
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByFullNameAsync(string firstName, string lastName);
        Task<IEnumerable<User>> GetByRoleAsync(RoleType role);
        Task<IEnumerable<User>> GetActiveAsync();
    }
}
