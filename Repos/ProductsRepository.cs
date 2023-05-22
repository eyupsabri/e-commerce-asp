﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repos
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly AppDbContext _db;

        public ProductsRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Product> AddProduct(Product prod)
        {
            _db.Products.Add(prod);
            await _db.SaveChangesAsync();

            return prod;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            _db.Products.RemoveRange(_db.Products.Where(temp => temp.ProductId == id));
            int rowsDeleted = await _db.SaveChangesAsync();

            return rowsDeleted > 0;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<List<Product>> GetAllProductsByCategoryId(int categoryId)
        {
           return await _db.Products.Where(temp => temp.CategoryId == categoryId).ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _db.Products.FirstOrDefaultAsync(temp => temp.ProductId == id);
        }

        public async Task<Product> UpdateProduct(Product prod)
        {
            Product? matchingProduct = await _db.Products.FirstOrDefaultAsync(temp => temp.ProductId == prod.ProductId);

            if (matchingProduct == null)
                return prod;

            matchingProduct.ProductName = prod.ProductName;
            matchingProduct.ProductPrice = prod.ProductPrice;
            matchingProduct.ProductDescription = prod.ProductDescription;
            matchingProduct.ProductName = prod.ProductName;
            matchingProduct.CategoryId = prod.CategoryId;


            int countUpdated = await _db.SaveChangesAsync();

            return matchingProduct;
        }

        public async Task<List<Product>> GetFilteredProducts(Expression<Func<Product, bool>> predicate)
        {
            return await _db.Products
             .Where(predicate)
             .ToListAsync();
        }
    }
}