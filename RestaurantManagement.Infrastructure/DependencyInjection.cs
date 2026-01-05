using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantManagement.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Persistence.RestaurantDbContext>(options =>
                options.UseInMemoryDatabase("RestaurantDB"));

            // Здесь позже репозитории
            return services;
        }
    }
}
