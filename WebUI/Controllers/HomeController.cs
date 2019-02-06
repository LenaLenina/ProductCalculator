using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebUI.Models;
using WebUI.Models.Entities;
using WebUI.Models.Calculator;
using WebUI.Models.Repository;
using WebUI.Models.ViewModels;
using WebUI.Models.Calculator.Discount;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;
        ICalculator calc;

        public HomeController(IRepository repo, ICalculator calc)
        {
            this.repo = repo;
            this.calc = calc;
        }

        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(calc) { Products = repo.GetProducts() };

            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Sum = cart.GetSum(),
                SumWithDiscount = cart.GetSumWithDiscount()
            };

            return View(model);
        }
    }
}