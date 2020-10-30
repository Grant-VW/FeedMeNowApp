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

        public IActionResult RestuarantList()
        {
            //hard code foodType and location variables until input on view works
            //var foodtype = "Tacos";
            var location = "Cape Town";
            
            //'build' string for JSON file location
            string contentRootPath = _env.ContentRootPath;
            string filePath = contentRootPath + @"\AppMockData\SampleData.json";
            string jsonString = System.IO.File.ReadAllText(filePath);
            var restuarantsT = JsonConvert.DeserializeObject<List<Restuarant>>(jsonString);

            List<Restuarant> restuarants = restuarantsT.FindAll(restuarant => (restuarant.City == location));

            //ViewData["Message"] = "You searched for " + foodAndLocation;

            //ViewBag.TopMessage = foodAndLocation;
            ViewBag.Message = restuarants;
            return View(); 
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
