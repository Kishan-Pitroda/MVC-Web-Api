using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Models;
using ProductApi.Services;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("PolicyOne")]
    public class ProductsController : ControllerBase
    {
        private ILoggerManager _logger;
        private IProductService _service;

        public ProductsController(ILoggerManager logger, IProductService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/products")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _service.GetProducts();
        }

        [HttpGet("/api/products/{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            return _service.GetProduct(id);
        }

        [HttpPost("/api/products")]
        public ActionResult<Product> AddProduct(Product product)
        {
           return _service.AddProduct(product);
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<Product> UpdateProduct(Product product)
        {
            return _service.UpdateProduct(product);
        }

        [HttpDelete("/api/products/{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            return _service.DeleteProduct(id);
        }

    }
}