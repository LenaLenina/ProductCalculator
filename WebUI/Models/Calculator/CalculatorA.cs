using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebUI.Models.Entities;
using WebUI.Models.Calculator;
using WebUI.Models.Calculator.Discount;

namespace WebUI.Models.Calculator
{
    public class CalculatorA:ICalculator
    {
        IDiscount discount;

        public CalculatorA(IDiscount discount)
        {
            this.discount = discount;
        }

        public override List<Product> Products { get; set; }

        public override decimal GetSum()
        {
            return Products.Sum(x => x.Price);
        }

        public override decimal GetSumWithDiscount()
        {
            return discount.ApplyDiscount(GetSum());
        }
    }
}