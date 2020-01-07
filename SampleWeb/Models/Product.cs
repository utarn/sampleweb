﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWeb.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableUnits { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
