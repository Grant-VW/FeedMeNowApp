using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedMeNow.Models
{
    public class ViewModel
    {
        public List<Restaurant> Restaurants { get; set; }
        public List<Category> Categories { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public ViewModel(List<Restaurant> restaurants, List<Category> categories, List<MenuItem> menuItems)
        {
            Restaurants = restaurants;
            Categories = categories;
            MenuItems = menuItems;
        }
    }
}
