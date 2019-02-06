using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;

using WebUI.Models;
using WebUI.Models.Entities;
using WebUI.Controllers;
using WebUI.Models.Repository;
using WebUI.Models.Calculator;
using WebUI.Models.Calculator.Discount;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        List<Product> list = new List<Product>(){
            new Product(){Id= 1, Price = 10},
            new Product(){Id= 2, Price = 20},
            new Product(){Id= 3, Price = 30},
            new Product(){Id= 4, Price = 40},
        };

        [TestMethod]
        public void Can_CalculatorA_GetSum()
        {
            Mock<IDiscount> mock = new Mock<IDiscount>();

            mock.Setup(x => x.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(x => x * 0.9m);

            CalculatorA calc = new CalculatorA(mock.Object){Products = list};

            decimal res = calc.GetSum();

            Assert.AreEqual(100, res);
        }

        [TestMethod]
        public void Can_CalculatorA_GetSumWithDiscount()
        {
            Mock<IDiscount> mock = new Mock<IDiscount>();

            mock.Setup(x => x.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(x => x * 0.9m);

            CalculatorA calc = new CalculatorA(mock.Object) { Products = list };

            decimal res = calc.GetSumWithDiscount();

            Assert.AreEqual(90, res);
        }

        [TestMethod]
        public void Can_DiscountA_ApplyDiscount()
        {
            DiscountA dis = new DiscountA();

            decimal res = dis.ApplyDiscount(100);

            Assert.AreEqual(90, res);
        }

        [TestMethod]
        public void Can_ShoppingCart_GetSum()
        {
            Mock<ICalculator> mock = new Mock<ICalculator>();
            
            //mock.Setup(x => x.Products).Returns<List<Product>>(x=>x);
            //mock.Setup(x => x.GetSum()).Returns<decimal>(m =>
            //{
            //    mock.Object.Products = list;
            //    return mock.Object.Products.Sum(x => x.Price);
            // });
            //mock.Setup(x => x.GetSum()).Returns<List<Product>,decimal>((x,y) => x.Sum(m => m.Price));

            //Нам нужно только возвращаемое значение, логика не важна
            mock.Setup(x => x.GetSum()).Returns(90m);
            
            ShoppingCart cart = new ShoppingCart(mock.Object);

            cart.Products = list;

            decimal res = cart.GetSum();

            Assert.AreEqual(90, res);

        }

        [TestMethod]
        public void Can_ShoppingCart_GetSumWithDiscount()
        {
            Mock<ICalculator> mock = new Mock<ICalculator>();

            mock.Setup(x => x.GetSumWithDiscount()).Returns(80m);

            ShoppingCart cart = new ShoppingCart(mock.Object);

            cart.Products = list;

            decimal res = cart.GetSumWithDiscount();

            Assert.AreEqual(80, res);
        }
    }
}
