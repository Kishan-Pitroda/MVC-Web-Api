using Microsoft.EntityFrameworkCore;
using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Context
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var userOne = new User()
            {
                Id = 1,
                Name = "kishan",
                Email = "pitrodak1@gmail.com",
                Password = "pitshanp"
            };
            var userTwo = new User()
            {
                Id = 2,
                Name = "shakti",
                Email = "zalas@gmail.com",
                Password = "pitshanp"
            };
            modelBuilder.Entity<User>().HasData(userOne, userTwo);
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Smartphone",
                        Brand = "Nokia",
                        UserId = userOne.Id
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Smartphone",
                        Brand = "Samsung",
                        UserId = userTwo.Id
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "A.C.",
                        Brand = "Toshiba",
                        UserId = userTwo.Id
                    }
                );
        }

    }
}
