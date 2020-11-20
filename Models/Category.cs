using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedMeNow.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public List<MenuItem> FilterMenuItems(string menuItemName)
        {
            List<MenuItem> _menuItems = MenuItems.Where(m => m.Name.Contains(menuItemName)).ToList();
            MenuItems = _menuItems;
            return _menuItems;
        }
    }
}

