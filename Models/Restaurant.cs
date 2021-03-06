﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedMeNow.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string LogoPath { get; set; }
        public int Rank { get; set; }
        public List<Category> Categories { get; set; }

        public List<Category> GetCategories()
        {
            return Categories;
        }

        public int GetMenuItemCount()
        {
            var _categories = Categories;
            int menuItemCount = _categories.Sum(x => x.MenuItems.Count);
            return menuItemCount;
        }
    }   
}
