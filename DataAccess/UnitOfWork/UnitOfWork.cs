﻿using DataAccess.DbContext;
using DataAccess.Repositories;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SneakersDbContext _context;
        public IUserRepository User{  get; private set; }
        public IProductRepository Product { get; private set; }
        public IProductCartRepository ProductCart { get; private set; }
        public ICartRepository Cart { get; private set; }
        public IProductQuantityRepository ProductQuantity { get; private set; }
        public ISizeRepository Size { get; private set; }
        public IColorRepository Color { get; private set; }
        public IOrderRepository Order { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public IOrderStatusHistoryRepository OrderStatusHistory { get; private set; }


        public UnitOfWork(SneakersDbContext context)
        {
            _context = context;
            User = new UserRepository(_context);
            Product = new ProductRepository(_context);
            ProductCart = new ProductCartRepository(_context);
            Cart = new CartRepository(_context);
            ProductQuantity = new ProductQuantityRepository(_context);
            Size = new SizeRepository(_context);
            Color = new ColorRepository(_context);
            Order = new OrderRepository(_context);
            OrderDetail = new OrderDetailRepository(_context);
            OrderStatusHistory = new OrderStatusHistoryRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
