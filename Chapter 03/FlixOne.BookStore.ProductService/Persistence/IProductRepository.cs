﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlixOne.BookStore.ProductService.Models;

namespace FlixOne.BookStore.ProductService.Persistence
{
    public interface IProductRepository
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
        Task<IEnumerable<Product>> GetAllAsync();
        Product GetBy(Guid id);
        void Remove(Guid id);
        void Update(Product product);
    }
}