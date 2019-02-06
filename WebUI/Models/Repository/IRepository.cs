﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebUI.Models.Entities;

namespace WebUI.Models.Repository
{
    public interface IRepository
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
        void RemoveProduct(int id);
        void ClearAll();
    }
}
