using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantManagement.Infrastructure.Persistence;
using RestaurantManagement.Infrastructure.Repositories.Common;
using RestaurantManagement.Infrastructure.Repositories.DishCategories;
using RestaurantManagement.Infrastructure.Repositories.Dishes;
using RestaurantManagement.Infrastructure.Repositories.DishTagLinks;
using RestaurantManagement.Infrastructure.Repositories.DishTags;
using RestaurantManagement.Infrastructure.Repositories.OrderItems;
using RestaurantManagement.Infrastructure.Repositories.Orders;
using RestaurantManagement.Infrastructure.Repositories.Tables;
using RestaurantManagement.Infrastructure.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RestaurantDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IDishRepository, DishRepository>();
            services.AddScoped<IDishCategoryRepository, DishCategoryRepository>();
            services.AddScoped<IDishTagRepository, DishTagRepository>();
            services.AddScoped<IDishTagLinkRepository, DishTagLinkRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<ITableRepository, TableRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
