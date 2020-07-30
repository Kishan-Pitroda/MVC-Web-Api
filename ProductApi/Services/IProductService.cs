using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Services
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public Product GetProduct(int id);
        public Product AddProduct(Product productItem);
        public Product UpdateProduct(Product productItem);
        public Product DeleteProduct(int id);
    }
}
