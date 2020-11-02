using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FeedMeNow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Immutable;

namespace FeedMeNow.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }
        /*
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RestaurantList(string menuItemNameInCity)
        {
            try
            {
                //hard code foodType and location variables until input on view works
                var menuItemName = "Taco";
                var city = "Cape Town";

                //'build' string for JSON file location
                string contentRootPath = _env.ContentRootPath;
                string filePath = contentRootPath + @"\AppMockData\SampleData.json";
                string jsonString = System.IO.File.ReadAllText(filePath);
                var restaurantsT = JsonConvert.DeserializeObject<List<Restaurant>>(jsonString);

                List<Restaurant> restaurants = restaurantsT.FindAll(restaurant => restaurant.Categories
                                                           .Any(category => category.MenuItems
                                                           .Any(menuItem => menuItem.Name.Contains(menuItemName) && 
                                                                restaurant.City == city)))
                                                           .ToList();

                ViewBag.restaurants = restaurants;
                ViewBag.menuItemNameInCity = menuItemNameInCity;

                return View();
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View();
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
