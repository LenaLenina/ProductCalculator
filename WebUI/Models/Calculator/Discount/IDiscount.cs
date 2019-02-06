using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models.Calculator.Discount
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal price);
    }
}
