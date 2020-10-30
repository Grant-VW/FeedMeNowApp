using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedMeNow.Models
{
    public class ViewModel
    {
        public List<Restuarant> Restuarants { get; set; }
        public List<Category> Categories { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}
