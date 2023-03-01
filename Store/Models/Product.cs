﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace OnlineStore
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
       // public Category Category { get; set; }
        //public ICollection<Order> Orders { get; set; }
    }
}

