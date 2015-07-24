﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClusterCart.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext() : base("ClusterCart") { } 
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
    }
}