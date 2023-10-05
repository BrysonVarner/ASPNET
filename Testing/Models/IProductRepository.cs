﻿using System.Collections.Generic;
using Testing.Models;

namespace Testing.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
