﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccess.DbContext
{
    public class SneakersDbContext : IdentityDbContext<User, Role, Guid>
    {
        public SneakersDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCart> ProductCart { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<ShippingInfor> ShippingInfor { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties()) {
                    if (property.ClrType == typeof(Guid) && property.IsPrimaryKey())
                    {
                        property.SetDefaultValueSql("NewID()");
                    } 
                }
            }

            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });

            builder.Entity<Role>(entity =>
            {
                entity.ToTable(name: "Role");
            });

            base.OnModelCreating(builder);
        }

    }
}
