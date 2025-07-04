﻿using SimpleProductApi.Models;
using SimpleProductApi.Data.Repositories.Interfaces;
using SimpleProductApi.Data;

namespace SimpleProductApi.Data.Repositories.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        // Here in the future you can add any custom functions.
    }
}
