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
        [Route("Home/RestaurantList/")]

        public IActionResult RestaurantList(string findMenuItemNameInCity)
        {
            try
            {
                //split search string
                var menuItemName = findMenuItemNameInCity.Split(" in ", 2, StringSplitOptions.None).ToList()[0];
                var city = findMenuItemNameInCity.Split(" in ", 2, StringSplitOptions.None).ToList()[1];

                //'build' string for JSON file location
                string contentRootPath = _env.ContentRootPath;
                string filePath = contentRootPath + @"\AppMockData\SampleData.json";
                string jsonString = System.IO.File.ReadAllText(filePath);
                var restaurantsT = JsonConvert.DeserializeObject<List<Restaurant>>(jsonString);

                List<Restaurant> restaurants = restaurantsT.FindAll(restaurant => restaurant.GetCategories()
                                                           .Any(category => category.GetMenuItems()
                                                           .Any(menuItem => menuItem.Name.Contains(menuItemName) && 
                                                                restaurant.City == city)))
                                                           .ToList();

                /*
                var sortTest = "";

                foreach(var restaurant in restaurants.OrderByDescending(restaurant => restaurant.GetMenuItemCount()))
                {
                    sortTest += "[Items: " + restaurant.GetMenuItemCount() + ", Rank: " + restaurant.Rank + "] ";
                }

                ViewBag.menuItemNameInCity = sortTest;
                */

                ViewBag.menuItemNameInCity = findMenuItemNameInCity;
                //sort restaraunts by descending highest number of menuitems, then ascending rank
                return View(restaurants.OrderByDescending(restaurant => restaurant.GetMenuItemCount())
                                       .ThenBy(restaurant => restaurant.Rank).ToList());
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
