﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel.Order
{
    public class OrderDetailDto
    {
        public required int Quantity { get; set; }
        public Decimal PriceAtOrder { get; set; }
        public Guid OrderId { get; set; }
        public required Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ImageUrl { get; set; }
        public Guid ColorId { get; set; }
        public string? ColorName { get; set; }
        public Guid SizeId { get; set; }
        public float SizeNumber { get; set; }
    }
}
