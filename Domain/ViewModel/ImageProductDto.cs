﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class ImageProductDto
    {
        public Guid ImageId { get; set; }
        public String ImageUrl { get; set; }
        public int IsThumbnail { get; set; }
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public String ColorName { get; set; }
    }
}
