using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Infrastructure.Persistence
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        #region Основные сущности
        public DbSet<User> Users => Set<User>();
        public DbSet<Table> Tables => Set<Table>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        #endregion

        #region Меню
        public DbSet<Dish> Dishes => Set<Dish>();
        public DbSet<DishCategory> DishCategories => Set<DishCategory>();
        public DbSet<DishTag> DishTags => Set<DishTag>();
        public DbSet<DishTagLink> DishTagLinks => Set<DishTagLink>();
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureUser(modelBuilder);
            ConfigureDish(modelBuilder);
            ConfigureDishCategory(modelBuilder);
            ConfigureDishTag(modelBuilder);
            ConfigureDishTagLink(modelBuilder);
            ConfigureOrder(modelBuilder);
            ConfigureOrderItem(modelBuilder);
        }

        private static void ConfigureUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(x => x.ID);

                entity.Property(x => x.FirstName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.LastName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.Role)
                      .IsRequired();

                entity.Property(x => x.PasswordHash)
                      .IsRequired();

                entity.Property(x => x.PasswordSalt)
                      .IsRequired();
            });
        }

        private static void ConfigureDish(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>(entity =>
            {
                entity.ToTable("Dishes");

                entity.HasKey(x => x.ID);

                entity.Property(x => x.Name)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(x => x.Price)
                      .HasColumnType("decimal(10,2)")
                      .IsRequired();

                entity.Property(x => x.Category_ID)
                      .IsRequired();
            });
        }

        private static void ConfigureDishCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishCategory>(entity =>
            {
                entity.ToTable("DishCategories");

                entity.HasKey(x => x.ID);

                entity.Property(x => x.Name)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(x => x.ParentCategory_ID)
                      .IsRequired(false);
            });
        }

        private static void ConfigureDishTag(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishTag>(entity =>
            {
                entity.ToTable("DishTags");

                entity.HasKey(x => x.ID);

                entity.Property(x => x.Name)
                      .IsRequired()
                      .HasMaxLength(100);
            });
        }

        private static void ConfigureDishTagLink(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishTagLink>(entity =>
            {
                entity.ToTable("DishTagLinks");

                entity.HasKey(x => x.ID);

                entity.HasIndex(x => new { x.Dish_ID, x.Tag_ID })
                      .IsUnique();
            });
        }

        private static void ConfigureOrder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders");

                entity.HasKey(x => x.ID);

                entity.Property(x => x.Table_ID)
                      .IsRequired();

                entity.Property(x => x.Waiter_ID)
                      .IsRequired();

                entity.Property(x => x.Status)
                      .IsRequired();

                entity.Property(x => x.PaymentStatus)
                      .IsRequired();
            });
        }

        private static void ConfigureOrderItem(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItems");

                entity.HasKey(x => x.ID);

                entity.Property(x => x.Quantity)
                      .IsRequired();

                entity.Property(x => x.Price)
                      .HasColumnType("decimal(10,2)")
                      .IsRequired();
            });
        }
    }
}
