using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleFactoryPattern.Helper;

namespace SimpleFactoryPattern.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SimpleFactoryHelper factory = new SimpleFactoryHelper();
            
            // 給我一個箱子
            ViewBag.Box = factory.GetProduct(SimpleFactoryHelper.ProductType.Box);
            // 給我一個玩具
            ViewBag.Toy = factory.GetProduct(SimpleFactoryHelper.ProductType.Toy);
            // 給我一個食物
            ViewBag.Food = factory.GetProduct(SimpleFactoryHelper.ProductType.Food);

            return View();
        }
    }
}