using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Calculator.Discount
{
    public class DiscountA:IDiscount
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.9m;
        }
    }
}