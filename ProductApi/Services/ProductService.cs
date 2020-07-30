using ProductApi.Context;
using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Services
{
    public class ProductService : IProductService
    {
        public readonly ProductDbContext dbContext;

        public ProductService(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            Product product = dbContext.Products.Find(id);
            return product;
        }

        public Product AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return product;
        }

        public Product DeleteProduct(int id)
        {
            Product product = dbContext.Products.Find(id);
            dbContext.Remove(product);
            dbContext.SaveChanges();
            return product;
        }
    }
}