using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Models.Entities;

namespace WebUI.Models.Repository
{
    public class RepositorySimple:IRepository
    {
        List<Product> products = new List<Product>(){
            new Product(){Id= 1, Price = 10},
            new Product(){Id= 2, Price = 20},
            new Product(){Id= 3, Price = 30},
            new Product(){Id= 4, Price = 50}
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int id)
        {
            products.RemoveAt(id);
        }

        public void ClearAll()
        {
            products.Clear();
        }
    }
}