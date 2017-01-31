
using Okike.Model;
using Okike.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Okike.Controllers
{
    public class HomeController : Controller
    {

        private IFoodItemService _foodservice;

        public HomeController(IFoodItemService _foodServ)
        {
            _foodservice = _foodServ;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            _foodservice.AddFoodItem(new FoodItem { ID ="ewrwe", Name = " "});
            return View();
        }
        [HttpPost]
        public ActionResult AddFood(FoodItem md)
        {
            if(ModelState.IsValid)
            {
                _foodservice.AddFoodItem(md);
            }
            return View(md);
        }
        
    }
}
