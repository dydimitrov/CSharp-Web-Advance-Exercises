using Chuska.Models;
using Chuska.Models.Enum;
using Chuska.Services.Contracts;
using System;
using System.Linq;
using Chuska.Web.Data;
using Chuska.Models.ViewModels.Product;
using System.Collections.Generic;

namespace Chuska.Services
{
    public class ProductService : IProductService
    {
        private readonly ChuskaDbContext db;
        public ProductService(ChuskaDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ProductListViewModel> GetAllProducts()
        {
            var list = db.Products.Select(p => new ProductListViewModel()
            {
                Id = p.Id,
                Description = p.Description,
                Name = p.Name,
                Price = p.Price
            }).ToList();

            return list;
        }

        public void Create(string name,
                           decimal price,
                           string description,
                           string productType)
        {
            var product = new Product()
            {
                Name = name,
                Price = price,
                Description = description,
                Type = Enum.Parse<ProductType>(productType, true)
            };

            db.Products.Add(product);
            db.SaveChanges();
        }
        public ProductEditViewModel FindById(int id)
        {
            var product = db.Products.First(p => p.Id == id);
            var productDto = new ProductEditViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ProductType = product.Type.ToString()
            };
            return productDto;
        }

        public void EditById(ProductEditViewModel model, int id)
        {
            var productDb = db.Products.First(p => p.Id == id);
            productDb.Name = model.Name;
            productDb.Price = model.Price;
            productDb.Description = model.Description;
            productDb.Type = Enum.Parse<ProductType>(model.ProductType);

            db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var productDb = db.Products.First(p => p.Id == id);
            db.Products.Remove(productDb);
            db.SaveChanges();
        }

        public void Order(int id, string username)
        {
            var product = db.Products.First(p => p.Id == id);
            var user = db.Users.First(u => u.UserName == username);

            var order = new Order()
            {
                Client = user,
                Product = product,
                OrderedOn = DateTime.UtcNow
            };

            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}
