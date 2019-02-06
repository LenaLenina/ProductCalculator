using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.Models.Entities;

namespace WebUI.Models.Calculator
{
    public abstract class ICalculator
    {
        public virtual List<Product> Products { get; set; }

        public abstract decimal GetSum();

        public abstract decimal GetSumWithDiscount();
    }
}
