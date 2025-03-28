﻿using Domain.Entities;
using Domain.ViewModel.Cart;
using Domain.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
    }
}
