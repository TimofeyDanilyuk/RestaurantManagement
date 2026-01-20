using RestaurantManagement.Domain.Entities;
using RestaurantManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Repositories.Tables
{
    public interface ITableRepository : IRepository<Table>
    {
        Task<Table?> GetByNumberAsync(int number);
    }
}
