﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public int Quality {  get; set; }
        [Required]
        public required Guid OrderDetailId { get; set; }
        public OrderDetail? OrderDetail { get; set; }
        [Required]
        public required Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
