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

                List<Restaurant> restaurants = JsonConvert.DeserializeObject<List<Restaurant>>(jsonString).ToList()
                                                          .Where(r => r.City.Contains(city) &&
                                                                      r.MenuItemInRestaurant(menuItemName) &&
                                                                      r.Categories
                                                           .All(c => c.FilterMenuItems(menuItemName)
                                                           .All(m => m.Name.Contains(menuItemName))))
                                                           .ToList();

                ViewBag.menuItemNameInCity = findMenuItemNameInCity;
                //sort restaraunts by descending highest number of menuitems, then ascending rank
                return View(restaurants.OrderByDescending(r => r.FilteredMenuItemCount(menuItemName)).ThenBy(r => r.Rank).ToList());
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
