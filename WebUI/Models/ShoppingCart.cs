using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebUI.Models;
using WebUI.Models.Entities;
using WebUI.Models.Repository;
using WebUI.Models.Calculator;
using WebUI.Models.Calculator.Discount;

namespace WebUI.Models
{
    public class ShoppingCart
    {
        ICalculator calculator;

        public ShoppingCart(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public List<Product> Products { get; set; }

        public decimal GetSum()
        {
            calculator.Products = Products;
            return calculator.GetSum();
        }

        public decimal GetSumWithDiscount()
        {
            calculator.Products = Products;
            return calculator.GetSumWithDiscount();
        }
    }
}