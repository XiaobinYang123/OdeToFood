using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Web.Models
{   
    // ViewModel
    // Not persistent at database but all the information I need for specfic view.
    public class GreetingViewModel
    {   
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}